using UnityEngine;
using UnityEngine.UI;
using OneWeekAtPan.AI;
using OneWeekAtPan.Core;
using UnityEngine.SceneManagement;

namespace OneWeekAtPan.Hardcore
{
	public class HardcoreMode : MonoBehaviour
	{
		public static bool IS_JUMPSCARE = false;
		public static int NIGHT = 1;
		public static int NIGHT_HOUR = 12;
		[SerializeField] private float amountOfTime;

		[Header("Components:")]
		[HideInInspector] public PanAI panAI;
		[HideInInspector] public MikeyAI mikeyAI;
		[SerializeField] private Text nightHourText;
		[Space]
		[SerializeField] private Button[] buttons; // Buttons: Cam01AButton -> Cam07BButton, CamButtonOn, CamButtonOff
		private OwlAI owlAI;
		private EyeDemonAI eyeDemonAI;

		[Header("GameObjects:")]
		[SerializeField] private GameObject framerate;
		[SerializeField] private GameObject owlObject;
		[SerializeField] private GameObject eyeDemonObject;
		private GameObject mikeyObject;
		private GameObject panObject;

		void Awake()
		{
			amountOfTime = 360f;
			NIGHT_HOUR = 12;
			IS_JUMPSCARE = false;
			OwlAI.IS_OWL_IN_OFFICE = false;

			if (NIGHT == 8)
			{
				NIGHT = 7;
			}

			if (Framerate.SHOW_FPS)
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
			//print(PanAI.PAN_AI_LEVEL);
			//print(MikeyAI.MIKEY_AI_LEVEL);
			//print(TravisAI.TRAVIS_AI_LEVEL);
			//print(OwlAI.OWL_AI_LEVEL);
			//print(NIGHT);
		}

		void Start()
		{
			mikeyObject = GameObject.Find("Mikey");
			panObject = GameObject.Find("Pan");

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
		}

		void Update()
		{
			amountOfTime -= Time.deltaTime;

			NightTime();

			// Used to skip the nights, DEBUG ONLY
			/*if (Input.GetKey(KeyCode.LeftShift))
			{
				if (Input.GetKeyDown(KeyCode.Q))
				{
					SceneManager.LoadScene("6AM_H");
				}
			}*/

			if (PauseMenu.IS_PAUSED)
			{
				foreach (var button in buttons)
				{
					button.interactable = false;
				}
			}
			else if (!PauseMenu.IS_PAUSED)
			{
				foreach (var button in buttons)
				{
					button.interactable = true;
				}
			}
		}

		private void SetAIlevel()
		{
			switch (NIGHT)
			{
				case 1:
					PanAI.PAN_AI_LEVEL = 1;
					MikeyAI.MIKEY_AI_LEVEL = 1;
					break;

				case 2:
					PanAI.PAN_AI_LEVEL = 3;
					MikeyAI.MIKEY_AI_LEVEL = 4;
					TravisAI.TRAVIS_AI_LEVEL = 6;
					break;

				case 3:
					PanAI.PAN_AI_LEVEL = 5;
					MikeyAI.MIKEY_AI_LEVEL = 5;
					TravisAI.TRAVIS_AI_LEVEL = 8;
					OwlAI.OWL_AI_LEVEL = 6;
					break;

				case 4:
					PanAI.PAN_AI_LEVEL = 9;
					MikeyAI.MIKEY_AI_LEVEL = 7;
					TravisAI.TRAVIS_AI_LEVEL = 10;
					OwlAI.OWL_AI_LEVEL = 8;
					break;

				case 5:
					PanAI.PAN_AI_LEVEL = 13;
					MikeyAI.MIKEY_AI_LEVEL = 15;
					TravisAI.TRAVIS_AI_LEVEL = 13;
					OwlAI.OWL_AI_LEVEL = 10;
					break;

				case 6:
					PanAI.PAN_AI_LEVEL = 15;
					MikeyAI.MIKEY_AI_LEVEL = 16;
					TravisAI.TRAVIS_AI_LEVEL = 15;
					OwlAI.OWL_AI_LEVEL = 14;
					break;

				case 7:
					PanAI.PAN_AI_LEVEL = 17;
					MikeyAI.MIKEY_AI_LEVEL = 18;
					TravisAI.TRAVIS_AI_LEVEL = 18;
					OwlAI.OWL_AI_LEVEL = 19;
					break;
			}
		}

		private void NightTime()
		{
			if (Mathf.Floor(amountOfTime) == 300f)
			{
				amountOfTime = 300f;
				NIGHT_HOUR = 1;

				AIlevel.PanMovingTime();
				AIlevel.MikeyMovingTime();
				AIlevel.OwlMovingTime();

				if (panAI.currentCamera != 4 && mikeyAI.currentCamera != 5)
				{
					panAI.timeBetwenMovement = Random.Range(PanAI.MIN_TIME_BETWEN_MOVEMENT, PanAI.MAX_TIME_BETWEN_MOVEMENT);
					mikeyAI.timeBetwenMovement = Random.Range(MikeyAI.MIN_TIME_BETWEN_MOVEMENT, MikeyAI.MAX_TIME_BETWEN_MOVEMENT);
				}

				if (owlAI != null && owlAI.currentCamera != 6)
				{
					owlAI.timeBetwenMovement = Random.Range(OwlAI.MIN_TIME_BETWEN_MOVEMENT, OwlAI.MAX_TIME_BETWEN_MOVEMENT);
				}

				nightHourText.text = $"{NIGHT_HOUR} AM";
			}
			else if (Mathf.Floor(amountOfTime) == 240f)
			{
				amountOfTime = 240f;
				NIGHT_HOUR = 2;

				AIlevel.PanMovingTime();
				AIlevel.MikeyMovingTime();
				AIlevel.OwlMovingTime();

				if (panAI.currentCamera != 4 && mikeyAI.currentCamera != 5)
				{
					panAI.timeBetwenMovement = Random.Range(PanAI.MIN_TIME_BETWEN_MOVEMENT, PanAI.MAX_TIME_BETWEN_MOVEMENT);
					mikeyAI.timeBetwenMovement = Random.Range(MikeyAI.MIN_TIME_BETWEN_MOVEMENT, MikeyAI.MAX_TIME_BETWEN_MOVEMENT);
				}

				if (owlAI != null && owlAI.currentCamera != 6)
				{
					owlAI.timeBetwenMovement = Random.Range(OwlAI.MIN_TIME_BETWEN_MOVEMENT, OwlAI.MAX_TIME_BETWEN_MOVEMENT);
				}

				nightHourText.text = $"{NIGHT_HOUR} AM";
			}
			else if (Mathf.Floor(amountOfTime) == 180f)
			{
				amountOfTime = 180f;
				NIGHT_HOUR = 3;

				AIlevel.PanMovingTime();
				AIlevel.MikeyMovingTime();
				AIlevel.OwlMovingTime();
				AIlevel.EyeDemonMovingTime();

				if (panAI.currentCamera != 4 && mikeyAI.currentCamera != 5)
				{
					panAI.timeBetwenMovement = Random.Range(PanAI.MIN_TIME_BETWEN_MOVEMENT, PanAI.MAX_TIME_BETWEN_MOVEMENT);
					mikeyAI.timeBetwenMovement = Random.Range(MikeyAI.MIN_TIME_BETWEN_MOVEMENT, MikeyAI.MAX_TIME_BETWEN_MOVEMENT);
				}

				if (owlAI != null && owlAI.currentCamera != 6)
				{
					owlAI.timeBetwenMovement = Random.Range(OwlAI.MIN_TIME_BETWEN_MOVEMENT, OwlAI.MAX_TIME_BETWEN_MOVEMENT);
				}

				if (eyeDemonObject != null && !IS_JUMPSCARE)
				{
					eyeDemonObject.SetActive(true);
					eyeDemonAI.timeBetwenMovement = Random.Range(EyeDemonAI.MIN_TIME_BETWEN_MOVEMENT, EyeDemonAI.MAX_TIME_BETWEN_MOVEMENT);
				}

				nightHourText.text = $"{NIGHT_HOUR} AM";
			}
			else if (Mathf.Floor(amountOfTime) == 120f)
			{
				amountOfTime = 120f;
				NIGHT_HOUR = 4;

				AIlevel.PanMovingTime();
				AIlevel.MikeyMovingTime();
				AIlevel.OwlMovingTime();
				AIlevel.EyeDemonMovingTime();

				if (panAI.currentCamera != 4 && mikeyAI.currentCamera != 5)
				{
					panAI.timeBetwenMovement = Random.Range(PanAI.MIN_TIME_BETWEN_MOVEMENT, PanAI.MAX_TIME_BETWEN_MOVEMENT);
					mikeyAI.timeBetwenMovement = Random.Range(MikeyAI.MIN_TIME_BETWEN_MOVEMENT, MikeyAI.MAX_TIME_BETWEN_MOVEMENT);
				}

				if (owlAI != null && owlAI.currentCamera != 6)
				{
					owlAI.timeBetwenMovement = Random.Range(OwlAI.MIN_TIME_BETWEN_MOVEMENT, OwlAI.MAX_TIME_BETWEN_MOVEMENT);
				}

				if (eyeDemonObject != null && eyeDemonAI.currentCamera != 6 && eyeDemonAI.currentCamera != 4)
				{
					eyeDemonAI.timeBetwenMovement = Random.Range(EyeDemonAI.MIN_TIME_BETWEN_MOVEMENT, EyeDemonAI.MAX_TIME_BETWEN_MOVEMENT);
				}

				nightHourText.text = $"{NIGHT_HOUR} AM";
			}
			else if (Mathf.Floor(amountOfTime) == 60f)
			{
				amountOfTime = 60f;
				NIGHT_HOUR = 5;

				AIlevel.PanMovingTime();
				AIlevel.MikeyMovingTime();
				AIlevel.OwlMovingTime();
				AIlevel.EyeDemonMovingTime();

				if (panAI.currentCamera != 4 && mikeyAI.currentCamera != 5)
				{
					panAI.timeBetwenMovement = Random.Range(PanAI.MIN_TIME_BETWEN_MOVEMENT, PanAI.MAX_TIME_BETWEN_MOVEMENT);
					mikeyAI.timeBetwenMovement = Random.Range(MikeyAI.MIN_TIME_BETWEN_MOVEMENT, MikeyAI.MAX_TIME_BETWEN_MOVEMENT);
				}

				if (owlAI != null && owlAI.currentCamera != 6)
				{
					owlAI.timeBetwenMovement = Random.Range(OwlAI.MIN_TIME_BETWEN_MOVEMENT, OwlAI.MAX_TIME_BETWEN_MOVEMENT);
				}

				if (eyeDemonObject != null && eyeDemonAI.currentCamera != 6 && eyeDemonAI.currentCamera != 4)
				{
					eyeDemonAI.timeBetwenMovement = Random.Range(EyeDemonAI.MIN_TIME_BETWEN_MOVEMENT, EyeDemonAI.MAX_TIME_BETWEN_MOVEMENT);
				}

				nightHourText.text = $"{NIGHT_HOUR} AM";
			}
			else if (Mathf.Floor(amountOfTime) == 0f)
			{
				amountOfTime = 0f;
				NIGHT_HOUR = 6;

				if (NIGHT == 7)
				{
					MainMenu.STAR3 = true;
				}

				nightHourText.text = $"{NIGHT_HOUR} AM";
				SceneManager.LoadSceneAsync("6AM_H");
			}
		}
	}
}
