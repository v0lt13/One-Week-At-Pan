using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private int currentTexture;
    private int vsync;
    private int fullscreen;
    private int showFPS;
    private int controlsType;
    private int currentPanTexture;
    private int currentStaticImageTexture;
    private float timeBetwenPanTextures;
    private float timeBetwenTextures;
    private float timeBetwenStaticImageTextures;
    private float timeUntilDataDeleted = 3f;
    private bool isMenu;

    [Header ("Components:")]
    [SerializeField] private AudioMixer mainMenuAudioMixer;
    [Space]
    [SerializeField] private Slider volumeSlider;
    [Space]
    [SerializeField] private Toggle vsyncToggle;
    [SerializeField] private Toggle fullscreenToggle;
    [SerializeField] private Toggle fpsToogle;
    [SerializeField] private Toggle controlsToogle;
    [Space]
    [SerializeField] private Text controlsText;
    [SerializeField] private Text nightNumberText;
    [Space]
    [SerializeField] private Dropdown resolutionDropdown;
    [Space]
    [SerializeField] private Texture[] panFaceTextures;
    [SerializeField] private Texture[] staticEffectTextures;
    private RawImage panFace;
    private RawImage staticEffect;
    private ButtonPointer buttonPointer;

    [Header ("GameObjects:")]
    [SerializeField] private GameObject continueButtonObject;
    [SerializeField] private GameObject optionsObjects;
    [SerializeField] private GameObject mainMenuObjects;
    [Space]
    [SerializeField] private GameObject[] resolutionDropdownObjects;
    [SerializeField] private GameObject[] staticEffectImageObjects;
    private GameObject panFaceObject;
    private GameObject staticEffectObject;

	void Awake()
	{
        SetSettings();
    }

	void Start()
    {
        panFaceObject = GameObject.Find("PanFace");
        staticEffectObject = GameObject.Find("Static");

        panFace = panFaceObject.GetComponent<RawImage>();
        buttonPointer = gameObject.GetComponent<ButtonPointer>();
        staticEffect = staticEffectObject.GetComponent<RawImage>();

        nightNumberText.text = PlayerPrefs.GetInt("Night").ToString();
        
		isMenu = true;

        timeBetwenPanTextures = Random.Range(1f, 5f);

		if (PlayerPrefs.GetInt("Night") > 1)
		{
            continueButtonObject.SetActive(true);
		}
    }

    void Update()
    {
        StaticEffect();
        StartCoroutine(PanEffect());
		StartCoroutine(StaticImageEffect());

		if (Input.GetKeyDown(KeyCode.Escape) && isMenu == true)
        {
            Application.Quit();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isMenu == false)
        {
            Menu();
        }

		if (PlayerPrefs.GetInt("fullScreen") == 0)
		{
            foreach (var resDropdown in resolutionDropdownObjects)
            {
                resDropdown.SetActive(false);
            }
        } 
        else
		{
            foreach (var resDropdown in resolutionDropdownObjects)
            {
                resDropdown.SetActive(true);
            }
        }

		if (Input.GetKey(KeyCode.Delete))
		{
            timeUntilDataDeleted -= Time.deltaTime;

			if (timeUntilDataDeleted <= 0)
			{
                PlayerPrefs.DeleteAll();
                SceneManager.LoadScene("Warning");
                timeUntilDataDeleted = 3f;
            }
		}
		else
		{
            timeUntilDataDeleted = 3f;
		}
    }

    public void NewGame()
    {
        SceneManager.LoadScene("Night01S");
        PlayerPrefs.SetInt("Night", 1);
    }

    public void Continue()
	{
        PlayerPrefs.SetInt("Night", 2);

        switch (PlayerPrefs.GetInt("Night"))
        {
            case 2:
                SceneManager.LoadScene("Night02S");
                break;

            default:
                SceneManager.LoadScene("Night02S");
                break;
        }
    }

    public void Options()
    {
        isMenu = false;

		foreach (var arrow in buttonPointer.arrows)
		{
            arrow.SetActive(false);
		}

        optionsObjects.SetActive(true);
        mainMenuObjects.SetActive(false);
    }

    public void Menu()
    {
        isMenu = true;

        foreach (var arrow in buttonPointer.arrows)
        {
            arrow.SetActive(false);
        }

        optionsObjects.SetActive(false);
        mainMenuObjects.SetActive(true);
    }

    public void MusicVolume(float volume)
    {
        mainMenuAudioMixer.SetFloat("Volume", volume);

        PlayerPrefs.SetFloat("Vol", volume);
        PlayerPrefs.Save();
    }

    public void SwitchControls(bool controlsType_)
    {
        if (controlsType_)
        {
            MainCamera.isMouseControls = false;
            controlsText.text = "Keyboard";
            controlsType = 1;
        }
        else if (!controlsType_)
        {
            MainCamera.isMouseControls = true;
            controlsText.text = "Mouse";
            controlsType = 0;
        }

        PlayerPrefs.SetInt("controlsType", controlsType);
        PlayerPrefs.Save();
    }

    public void SetFullScreen(bool fullScreen_)
    {
        Screen.fullScreen = fullScreen_;

        if (fullScreen_)
        {
            fullscreen = 0;
            Screen.SetResolution(1920, 1080, fullScreen_);
        }
        else
        {
            fullscreen = 1;
            resolutionDropdown.value = PlayerPrefs.GetInt("Res");
            SetResolution(PlayerPrefs.GetInt("Res"));
        }

        PlayerPrefs.SetInt("fullScreen", fullscreen);
        PlayerPrefs.Save();
    }

    public void ToogleVsync(bool vsync_)
    {
        if (vsync_)
        {
            QualitySettings.vSyncCount = 1;
            vsync = 1;
        }
        else
        {
            QualitySettings.vSyncCount = 0;
            vsync = 0;
        }

        PlayerPrefs.SetInt("isVsync", vsync);
        PlayerPrefs.Save();
    }

    public void ShowFPS(bool fps)
	{
		if (fps)
		{
            Framerate.showFPS = true;
            showFPS = 1;
		}
		else if (!fps)
		{
            Framerate.showFPS = false;
            showFPS = 0;
		}

        PlayerPrefs.SetInt("showFPS", showFPS);
        PlayerPrefs.Save();
    }

    public void SetResolution(int resolution)
	{
		switch (resolution)
		{
            case 0:
                Screen.SetResolution(1920, 1080, false);
                break;

            case 1:
                Screen.SetResolution(1768, 992, false);
                break;

            case 2:
                Screen.SetResolution(1600, 900, false);
                break;

            case 3:
                Screen.SetResolution(1366, 768, false);
                break;

            case 4:
                Screen.SetResolution(1280, 720, false);
                break;

            case 5:
                Screen.SetResolution(1176, 664, false);
                break;
        }

        PlayerPrefs.SetInt("Res", resolution);
        PlayerPrefs.Save();
	}

    private void SetSettings()
	{
        volumeSlider.value = PlayerPrefs.GetFloat("Vol");
        MusicVolume(PlayerPrefs.GetFloat("Vol"));

        if (PlayerPrefs.GetInt("isVsync") == 0)
        {
            vsyncToggle.isOn = false;
            ToogleVsync(false);
        }
        else
        {
            vsyncToggle.isOn = true;
            ToogleVsync(true);
        }

        if (PlayerPrefs.GetInt("fullScreen") == 1)
        {
            fullscreenToggle.isOn = false;
            SetFullScreen(false);
        }
        else
        {
            fullscreenToggle.isOn = true;
            SetFullScreen(true);
        }

        if (PlayerPrefs.GetInt("showFPS") == 1)
        {
            fpsToogle.isOn = true;
            ShowFPS(true);
        }
        else
        {
            fpsToogle.isOn = false;
            ShowFPS(false);
        }

        if (PlayerPrefs.GetInt("controlsType") == 1)
        {
            controlsToogle.isOn = true;
            controlsText.text = "Keyboard";
            SwitchControls(true);
        }
        else
        {
            controlsToogle.isOn = false;
            controlsText.text = "Mouse";
            SwitchControls(false);
        }
    }

    private void StaticEffect()
	{
        timeBetwenTextures -= Time.deltaTime;

        if (timeBetwenTextures < 0)
        {
            timeBetwenTextures = 0;
        }

        if (timeBetwenTextures == 0)
        {
            currentTexture++;
            currentTexture %= staticEffectTextures.Length;
            staticEffect.texture = staticEffectTextures[currentTexture];
            timeBetwenTextures = 0.08f;
        }
    }

    private IEnumerator StaticImageEffect()
	{
        timeBetwenStaticImageTextures -= Time.deltaTime;

        if (timeBetwenStaticImageTextures < 0)
        {
            timeBetwenStaticImageTextures = 0;
        }

        if (timeBetwenStaticImageTextures == 0)
        {
            currentStaticImageTexture = Random.Range(0, 2);
            staticEffectImageObjects[currentStaticImageTexture].SetActive(true);
            timeBetwenStaticImageTextures = Random.Range(.3f, 2f);

            yield return new WaitForSeconds(0.1f);

            staticEffectImageObjects[Random.Range(0, 3)].SetActive(true);

            yield return new WaitForSeconds(0.1f);

			foreach (var staticEffectImage in staticEffectImageObjects)
			{
                staticEffectImage.SetActive(false);
			}
        }
    }

    private IEnumerator PanEffect()
    {
        timeBetwenPanTextures -= Time.deltaTime;

        if (timeBetwenPanTextures < 0)
        {
            timeBetwenPanTextures = 0;
        }

        if (timeBetwenPanTextures == 0)
        {
            currentPanTexture = Random.Range(1, 3);
            panFace.texture = panFaceTextures[currentPanTexture];
            timeBetwenPanTextures = Random.Range(1f, 5f);

            yield return new WaitForSeconds(0.1f);

            panFace.texture = panFaceTextures[Random.Range(0, 2)];

            yield return new WaitForSeconds(0.1f);

            panFace.texture = panFaceTextures[0];
        }
    }
}
