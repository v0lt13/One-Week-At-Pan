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
    [SerializeField] private Text nightHourText;
    [Space]
    [SerializeField] private Button[] buttons; // Buttons: Cam01AButton -> Cam07BButton, CamButtonOn, CamButtonOff, MuteCallButton
    private CameraSystem cameraSys;
    private PanAI panAI;
    private MikeyAI mikeyAI;
    private OwlAI owlAI;

    [Header ("GameObjects:")]
    [SerializeField] private GameObject callButton;
    [SerializeField] private GameObject framerate;
    [SerializeField] private GameObject owlObject;
    [Space]
    [SerializeField] private GameObject[] callObjects; // Objetcs: Call, MuteCallButton
    private GameObject mikeyObject;
    private GameObject panObject;

    void Awake()
    {
        amountOfTime = 360f;
        nightHour = 12;
        isJumpscare = false;
        OwlAI.owlJumpscare = false;

        if (PlayerPrefs.GetInt("Night") != 0)
		{
            night = PlayerPrefs.GetInt("Night");
		}

		if (night == 7)
		{
            night = 6;
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

        print(PanAI.panAIlevel);
        print(MikeyAI.mikeyAIlevel);
        print(TravisAI.travisAILevel);
        print(OwlAI.owlAILevel);
    }

    void Start()
    {
        mikeyObject = GameObject.Find("Mikey");
        panObject = GameObject.Find("Pan");

        cameraSys = GetComponent<CameraSystem>();
        mikeyAI = mikeyObject.GetComponent<MikeyAI>();
        panAI = panObject.GetComponent<PanAI>();

        if (owlObject != null)
		{
            owlAI = owlObject.GetComponent<OwlAI>();
		}

        Invoke(nameof(ActivateCallButton), 7f);
        Invoke(nameof(RemoveCallButton), 20f);
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
            PanAI.panAIlevel = 1;
            MikeyAI.mikeyAIlevel = 1;
        }
        else if (night == 2)
        {
            PanAI.panAIlevel = 3;
            MikeyAI.mikeyAIlevel = 4;
            TravisAI.travisAILevel = 6;
        }
        else if (night == 3)
        {
            PanAI.panAIlevel = 5;
            MikeyAI.mikeyAIlevel = 5;
            TravisAI.travisAILevel = 8;
            OwlAI.owlAILevel = 6;
        }
        else if (night == 4)
        {
            PanAI.panAIlevel = 9;
            MikeyAI.mikeyAIlevel = 7;
            TravisAI.travisAILevel = 10;
            OwlAI.owlAILevel = 8;
        }
        else if (night == 5)
        {
            PanAI.panAIlevel = 13;
            MikeyAI.mikeyAIlevel = 15;
            TravisAI.travisAILevel = 13;
            OwlAI.owlAILevel = 10;
        }
        else if (night == 6)
        {
            PanAI.panAIlevel = 15;
            MikeyAI.mikeyAIlevel = 16;
            TravisAI.travisAILevel = 15;
            OwlAI.owlAILevel = 14;
        }
        else if (night == 7)
        {
            PanAI.panAIlevel = 17;
            MikeyAI.mikeyAIlevel = 18;
            TravisAI.travisAILevel = 18;
            OwlAI.owlAILevel = 19;
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
            AIlevel.OwlMovingTime();

            if (panAI.currentCamera != 4 && mikeyAI.currentCamera != 5)
            {
                panAI.timeBetwenMovement = Random.Range(PanAI.minTimeBetwenMovement, PanAI.maxTimeBetwenMovement);
                mikeyAI.timeBetwenMovement = Random.Range(MikeyAI.minTimeBetwenMovement, MikeyAI.maxTimeBetwenMovement);
            }

            if (owlAI != null && owlAI.currentCamera != 6)
            {
                owlAI.timeBetwenMovement = Random.Range(OwlAI.minTimeBetwenMovement, OwlAI.maxTimeBetwenMovement);
            }

            nightHourText.text = $"{nightHour} AM";
        }
        else if (Mathf.Floor(amountOfTime) == 240f)
        {
            amountOfTime = 240f;
            nightHour = 2;

            AIlevel.PanMovingTime();
            AIlevel.MikeyMovingTime();
            AIlevel.OwlMovingTime();

            if (panAI.currentCamera != 4 && mikeyAI.currentCamera != 5)
            {
                panAI.timeBetwenMovement = Random.Range(PanAI.minTimeBetwenMovement, PanAI.maxTimeBetwenMovement);
                mikeyAI.timeBetwenMovement = Random.Range(MikeyAI.minTimeBetwenMovement, MikeyAI.maxTimeBetwenMovement);
            }

            if (owlAI != null && owlAI.currentCamera != 6)
            {
                owlAI.timeBetwenMovement = Random.Range(OwlAI.minTimeBetwenMovement, OwlAI.maxTimeBetwenMovement);
            }

            nightHourText.text = $"{nightHour} AM";
        }
        else if (Mathf.Floor(amountOfTime) == 180f)
        {
            amountOfTime = 180f;
            nightHour = 3;

            AIlevel.PanMovingTime();
            AIlevel.MikeyMovingTime();
            AIlevel.OwlMovingTime();

            if (panAI.currentCamera != 4 && mikeyAI.currentCamera != 5)
            {
                panAI.timeBetwenMovement = Random.Range(PanAI.minTimeBetwenMovement, PanAI.maxTimeBetwenMovement);
                mikeyAI.timeBetwenMovement = Random.Range(MikeyAI.minTimeBetwenMovement, MikeyAI.maxTimeBetwenMovement);
            }

			if (owlAI != null && owlAI.currentCamera != 6)
			{
                owlAI.timeBetwenMovement = Random.Range(OwlAI.minTimeBetwenMovement, OwlAI.maxTimeBetwenMovement);
			}

            nightHourText.text = $"{nightHour} AM";
        }
        else if (Mathf.Floor(amountOfTime) == 120f)
        {
            amountOfTime = 120f;
            nightHour = 4;

            AIlevel.PanMovingTime();
            AIlevel.MikeyMovingTime();
            AIlevel.OwlMovingTime();

            if (panAI.currentCamera != 4 && mikeyAI.currentCamera != 5)
            {
                panAI.timeBetwenMovement = Random.Range(PanAI.minTimeBetwenMovement, PanAI.maxTimeBetwenMovement);
                mikeyAI.timeBetwenMovement = Random.Range(MikeyAI.minTimeBetwenMovement, MikeyAI.maxTimeBetwenMovement);
            }

            if (owlAI != null && owlAI.currentCamera != 6)
            {
                owlAI.timeBetwenMovement = Random.Range(OwlAI.minTimeBetwenMovement, OwlAI.maxTimeBetwenMovement);
            }

            nightHourText.text = $"{nightHour} AM";
        }
        else if (Mathf.Floor(amountOfTime) == 60f)
        {
            amountOfTime = 60f;
            nightHour = 5;

            AIlevel.PanMovingTime();
            AIlevel.MikeyMovingTime();
            AIlevel.OwlMovingTime();

            if (panAI.currentCamera != 4 && mikeyAI.currentCamera != 5)
            {
                panAI.timeBetwenMovement = Random.Range(PanAI.minTimeBetwenMovement, PanAI.maxTimeBetwenMovement);
                mikeyAI.timeBetwenMovement = Random.Range(MikeyAI.minTimeBetwenMovement, MikeyAI.maxTimeBetwenMovement);
            }

            if (owlAI != null && owlAI.currentCamera != 6)
            {
                owlAI.timeBetwenMovement = Random.Range(OwlAI.minTimeBetwenMovement, OwlAI.maxTimeBetwenMovement);
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
