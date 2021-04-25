using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public static bool isJumpscare = false;
    public static int night = 1;
    public static int nightHour = 12;
    private float amountOfTime;
    private bool isPhoneCallMuted = false;

    [Header("Components:")]
    [HideInInspector] public PanAI panAI;
    [HideInInspector] public MikeyAI mikeyAI;
    [Space]
    [SerializeField] private Text nightHourText;
    [Space]
    [SerializeField] private Button[] buttons; // Buttons: Cam01AButton -> Cam07BButton, CamButtonOn, CamButtonOff, MuteCallButton
    private CameraSystem cameraSys;

    [Header ("GameObjects:")]
    [SerializeField] private GameObject callButton;
    [SerializeField] private GameObject framerate;
    [Space]
    [SerializeField] private GameObject[] callObjects; // Objetcs: Call, MuteCallButton
    private GameObject mikeyObject;
    private GameObject panObject;

    void Awake()
    {
		if (PlayerPrefs.GetInt("Night") != 0)
		{
            night = PlayerPrefs.GetInt("Night");
		}

		if (Framerate.showFPS)
		{
            framerate.SetActive(true);
		}
		else
		{
            framerate.SetActive(false);
		}

        PlayerPrefs.DeleteKey("cam");
        PlayerPrefs.DeleteKey("camName");

        SetAIlevel();
    }

    void Start()
    {
        mikeyObject = GameObject.Find("Mikey");
        panObject = GameObject.Find("Pan");

        cameraSys = gameObject.GetComponent<CameraSystem>();
        mikeyAI = mikeyObject.GetComponent<MikeyAI>();
        panAI = panObject.GetComponent<PanAI>();

        amountOfTime = 360f;

        Invoke(nameof(ActivateCallButton), 7f);
        Invoke(nameof(RemoveCallButton), 30f);
    }

    void Update()
    {
        amountOfTime -= Time.deltaTime;

        NightTime();

        // Used to skip the nights, DEBUG ONLY
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                SceneManager.LoadScene("6AM");
            }
        }

		if (PauseMenu.isPaused && !isPhoneCallMuted)
		{
			GameObject.Find("Call").GetComponent<AudioSource>().Pause();

			foreach (var button in buttons)
			{
                button.interactable = false;
            }
		}
		else if (!PauseMenu.isPaused && !isPhoneCallMuted)
		{
            GameObject.Find("Call").GetComponent<AudioSource>().UnPause();

            foreach (var button in buttons)
            {
                button.interactable = true;
            }
        }
    }

    public void MuteCall()
    {
        cameraSys.mainAudioSource.clip = cameraSys.mainAudioClip[2];
        cameraSys.mainAudioSource.Play();

        isPhoneCallMuted = true;

        foreach (var call in callObjects)
        {
            call.SetActive(false);
        }
    }

    private void SetAIlevel()
    {
        if (night == 1)
        {
            PanAI.PanAIlevel = 1;
            MikeyAI.MikeyAIlevel = 1;
        }
        else if (night == 2)
        {
            PanAI.PanAIlevel = 3;
            MikeyAI.MikeyAIlevel = 4;
            TravisAI.TravisAILevel = 6;
        }
        else if (night == 3)
        {
            PanAI.PanAIlevel = 5;
            MikeyAI.MikeyAIlevel = 5;
            TravisAI.TravisAILevel = 8;
        }
        else if (night == 4)
        {
            PanAI.PanAIlevel = 9;
            MikeyAI.MikeyAIlevel = 7;
            TravisAI.TravisAILevel = 10;
        }
        else if (night == 5)
        {
            PanAI.PanAIlevel = 13;
            MikeyAI.MikeyAIlevel = 15;
            TravisAI.TravisAILevel = 13;
        }
        else if (night == 6)
        {
            PanAI.PanAIlevel = 15;
            MikeyAI.MikeyAIlevel = 16;
            TravisAI.TravisAILevel = 15;
        }
        else if (night == 7)
        {
            PanAI.PanAIlevel = 17;
            MikeyAI.MikeyAIlevel = 18;
            TravisAI.TravisAILevel = 18;
        }
    }

    private void NightTime()
    {
        if (Mathf.Floor(amountOfTime) == 300f)
        {
            amountOfTime = 300f;
            nightHour = 1;

            AIlevel.PanMovingTime();
            AIlevel.MikeyMovingTime();

            if (panAI.currentCamera != 4 && mikeyAI.currentCamera != 5)
            {
                panAI.timeBetwenMovement = Random.Range(PanAI.minTimeBetwenMovement, PanAI.maxTimeBetwenMovement);
                mikeyAI.timeBetwenMovement = Random.Range(MikeyAI.minTimeBetwenMovement, MikeyAI.maxTimeBetwenMovement);
            }

            nightHourText.text = $"{nightHour} AM";
        }
        else if (Mathf.Floor(amountOfTime) == 240f)
        {
            amountOfTime = 240f;
            nightHour = 2;

            AIlevel.PanMovingTime();
            AIlevel.MikeyMovingTime();

            if (panAI.currentCamera != 4 && mikeyAI.currentCamera != 5)
            {
                panAI.timeBetwenMovement = Random.Range(PanAI.minTimeBetwenMovement, PanAI.maxTimeBetwenMovement);
                mikeyAI.timeBetwenMovement = Random.Range(MikeyAI.minTimeBetwenMovement, MikeyAI.maxTimeBetwenMovement);
            }

            nightHourText.text = $"{nightHour} AM";
        }
        else if (Mathf.Floor(amountOfTime) == 180f)
        {
            amountOfTime = 180f;
            nightHour = 3;

            AIlevel.PanMovingTime();
            AIlevel.MikeyMovingTime();

            if (panAI.currentCamera != 4 && mikeyAI.currentCamera != 5)
            {
                panAI.timeBetwenMovement = Random.Range(PanAI.minTimeBetwenMovement, PanAI.maxTimeBetwenMovement);
                mikeyAI.timeBetwenMovement = Random.Range(MikeyAI.minTimeBetwenMovement, MikeyAI.maxTimeBetwenMovement);
            }

            nightHourText.text = $"{nightHour} AM";
        }
        else if (Mathf.Floor(amountOfTime) == 120f)
        {
            amountOfTime = 120f;
            nightHour = 4;

            AIlevel.PanMovingTime();
            AIlevel.MikeyMovingTime();

            if (panAI.currentCamera != 4 && mikeyAI.currentCamera != 5)
            {
                panAI.timeBetwenMovement = Random.Range(PanAI.minTimeBetwenMovement, PanAI.maxTimeBetwenMovement);
                mikeyAI.timeBetwenMovement = Random.Range(MikeyAI.minTimeBetwenMovement, MikeyAI.maxTimeBetwenMovement);
            }

            nightHourText.text = $"{nightHour} AM";
        }
        else if (Mathf.Floor(amountOfTime) == 60f)
        {
            amountOfTime = 60f;
            nightHour = 5;

            AIlevel.PanMovingTime();
            AIlevel.MikeyMovingTime();

            if (panAI.currentCamera != 4 && mikeyAI.currentCamera != 5)
            {
                panAI.timeBetwenMovement = Random.Range(PanAI.minTimeBetwenMovement, PanAI.maxTimeBetwenMovement);
                mikeyAI.timeBetwenMovement = Random.Range(MikeyAI.minTimeBetwenMovement, MikeyAI.maxTimeBetwenMovement);
            }

            nightHourText.text = $"{nightHour} AM";
        }
        else if (Mathf.Floor(amountOfTime) == 0f)
        {
            amountOfTime = 0f;
            nightHour = 6;

            nightHourText.text = $"{nightHour} AM";
            SceneManager.LoadSceneAsync("6AM");
        }
    }

    private void ActivateCallButton()
    {
        callButton.SetActive(true);
    }

    private void RemoveCallButton()
    {
        callButton.SetActive(false);
    }
}
