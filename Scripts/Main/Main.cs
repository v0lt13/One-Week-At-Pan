using UnityEngine;
using UnityEngine.UI;
using OneWeekAtPan.AI;
using OneWeekAtPan.Systems;
using UnityEngine.SceneManagement;

namespace OneWeekAtPan.Core
{
	public class Main : MonoBehaviour
	{
		public static bool isJumpscare = false;
		public static int night = 1;
		public static int nightHour = 12;
		[SerializeField] private float amountOfTime;
		private bool isPhoneCallMuted = false;

		[Header("Components:")]
		[SerializeField] private Text nightHourText;
		[Space]
		[SerializeField] private Button[] buttons; // Buttons: Cam01AButton -> Cam07BButton, CamButtonOn, CamButtonOff, MuteCallButton
		private CameraSystem cameraSystem;
		private PanAI panAI;
		private MikeyAI mikeyAI;
		private OwlAI owlAI;
		private EyeDemonAI eyeDemonAI;

		[Header("GameObjects:")]
		[SerializeField] private GameObject callButton;
		[SerializeField] private GameObject framerate;
		[SerializeField] private GameObject owlObject;
		[SerializeField] private GameObject eyeDemonObject;
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

			if (night == 8)
			{
				night = 7;
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

			// For debug
			print(PanAI.panAIlevel);
			print(MikeyAI.mikeyAIlevel);
			print(TravisAI.travisAILevel);
			print(OwlAI.owlAILevel);
			print(night);
		}

		void Start()
		{
			mikeyObject = GameObject.Find("Mikey");
			panObject = GameObject.Find("Pan");

			cameraSystem = GetComponent<CameraSystem>();
			mikeyAI = mikeyObject.GetComponent<MikeyAI>();
			panAI = panObject.GetComponent<PanAI>();

			if (owlObject != null)
			{
				owlAI = owlObject.GetComponent<OwlAI>();
			}

			if (eyeDemonObject != null)
			{
				eyeDemonAI = eyeDemonObject.GetComponent<EyeDemonAI>();
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
			cameraSystem.mainAudioSource.clip = cameraSystem.mainAudioClip[2];
			cameraSystem.mainAudioSource.Play();

			isPhoneCallMuted = true;

			foreach (var call in callObjects)
			{
				call.SetActive(false);
			}
		}

		private void SetAIlevel()
		{
			switch (night)
			{
				case 1:
					PanAI.panAIlevel = 1;
					MikeyAI.mikeyAIlevel = 1;
					break;

				case 2:
					PanAI.panAIlevel = 3;
					MikeyAI.mikeyAIlevel = 4;
					TravisAI.travisAILevel = 6;
					break;

				case 3:
					PanAI.panAIlevel = 5;
					MikeyAI.mikeyAIlevel = 5;
					TravisAI.travisAILevel = 8;
					OwlAI.owlAILevel = 6;
					break;

				case 4:
					PanAI.panAIlevel = 9;
					MikeyAI.mikeyAIlevel = 7;
					TravisAI.travisAILevel = 10;
					OwlAI.owlAILevel = 8;
					break;

				case 5:
					PanAI.panAIlevel = 13;
					MikeyAI.mikeyAIlevel = 15;
					TravisAI.travisAILevel = 13;
					OwlAI.owlAILevel = 10;
					break;

				case 6:
					PanAI.panAIlevel = 15;
					MikeyAI.mikeyAIlevel = 16;
					TravisAI.travisAILevel = 15;
					OwlAI.owlAILevel = 14;
					break;

				case 7:
					PanAI.panAIlevel = 17;
					MikeyAI.mikeyAIlevel = 18;
					TravisAI.travisAILevel = 18;
					OwlAI.owlAILevel = 19;
					break;
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
				AIlevel.EyeDemonMovingTime();

				if (panAI.currentCamera != 4 && mikeyAI.currentCamera != 5)
				{
					panAI.timeBetwenMovement = Random.Range(PanAI.minTimeBetwenMovement, PanAI.maxTimeBetwenMovement);
					mikeyAI.timeBetwenMovement = Random.Range(MikeyAI.minTimeBetwenMovement, MikeyAI.maxTimeBetwenMovement);
				}

				if (owlAI != null && owlAI.currentCamera != 6)
				{
					owlAI.timeBetwenMovement = Random.Range(OwlAI.minTimeBetwenMovement, OwlAI.maxTimeBetwenMovement);
				}

				if (eyeDemonObject != null && !isJumpscare)
				{
					eyeDemonObject.SetActive(true);
					eyeDemonAI.timeBetwenMovement = Random.Range(EyeDemonAI.minTimeBetwenMovement, EyeDemonAI.maxTimeBetwenMovement);
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
				AIlevel.EyeDemonMovingTime();

				if (panAI.currentCamera != 4 && mikeyAI.currentCamera != 5)
				{
					panAI.timeBetwenMovement = Random.Range(PanAI.minTimeBetwenMovement, PanAI.maxTimeBetwenMovement);
					mikeyAI.timeBetwenMovement = Random.Range(MikeyAI.minTimeBetwenMovement, MikeyAI.maxTimeBetwenMovement);
				}

				if (owlAI != null && owlAI.currentCamera != 6)
				{
					owlAI.timeBetwenMovement = Random.Range(OwlAI.minTimeBetwenMovement, OwlAI.maxTimeBetwenMovement);
				}

				if (eyeDemonObject != null && eyeDemonAI.currentCamera != 6 && eyeDemonAI.currentCamera != 4)
				{
					eyeDemonAI.timeBetwenMovement = Random.Range(EyeDemonAI.minTimeBetwenMovement, EyeDemonAI.maxTimeBetwenMovement);
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
				AIlevel.EyeDemonMovingTime();

				if (panAI.currentCamera != 4 && mikeyAI.currentCamera != 5)
				{
					panAI.timeBetwenMovement = Random.Range(PanAI.minTimeBetwenMovement, PanAI.maxTimeBetwenMovement);
					mikeyAI.timeBetwenMovement = Random.Range(MikeyAI.minTimeBetwenMovement, MikeyAI.maxTimeBetwenMovement);
				}

				if (owlAI != null && owlAI.currentCamera != 6)
				{
					owlAI.timeBetwenMovement = Random.Range(OwlAI.minTimeBetwenMovement, OwlAI.maxTimeBetwenMovement);
				}

				if (eyeDemonObject != null && eyeDemonAI.currentCamera != 6 && eyeDemonAI.currentCamera != 4)
				{
					eyeDemonAI.timeBetwenMovement = Random.Range(EyeDemonAI.minTimeBetwenMovement, EyeDemonAI.maxTimeBetwenMovement);
				}

				nightHourText.text = $"{nightHour} AM";
			}
			else if (Mathf.Floor(amountOfTime) == 0f)
			{
				amountOfTime = 0f;
				nightHour = 6;

				if (night == 7 && MainMenu.starNumber == 0)
				{
					MainMenu.starNumber = 1;
					PlayerPrefs.SetInt("stars", MainMenu.starNumber);
					PlayerPrefs.Save();
				}

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
}