using UnityEngine;
using UnityEngine.UI;
using OneWeekAtPan.AI;
using OneWeekAtPan.Core;
using UnityEngine.SceneManagement;

namespace OneWeekAtPan
{
    public class CustomNight : MonoBehaviour
    {
		public static bool IS_JUMPSCARE = false;
		public static bool IS_CUSTOM_NIGHT = true;
		public static int NIGHT_HOUR = 12;
		[SerializeField] private float amountOfTime;

		[Header("Components:")]
		[SerializeField] private Text nightHourText;
		[SerializeField] private Text timeText;
		[Space]
		[SerializeField] private Button[] buttons; // Buttons: Cam01AButton -> Cam07BButton, CamButtonOn, CamButtonOff, MuteCallButton

		[Header("GameObjects:")]
		[SerializeField] private GameObject framerate;
		[SerializeField] private GameObject owlObject;

		void Awake()
		{
			amountOfTime = 360f;
			NIGHT_HOUR = 12;
			IS_JUMPSCARE = false;
			OwlAI.IS_OWL_IN_OFFICE = false;

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

			// For debug
			print(PanAI.PAN_AI_LEVEL);
			print(MikeyAI.MIKEY_AI_LEVEL);
			print(TravisAI.TRAVIS_AI_LEVEL);
			print(OwlAI.OWL_AI_LEVEL);
		}

		void Update()
		{
			amountOfTime -= Time.deltaTime;
			timeText.text = amountOfTime.ToString("n1");

			NightTime();

			// Used to skip the night, DEBUG ONLY
			if (Input.GetKey(KeyCode.LeftShift))
			{
				if (Input.GetKeyDown(KeyCode.Q))
				{
					SceneManager.LoadScene("CN 6AM");
				}
			}
		}

		private void NightTime()
		{
			if (Mathf.Floor(amountOfTime) == 300f)
			{
				amountOfTime = 300f;
				NIGHT_HOUR = 1;

				nightHourText.text = $"{NIGHT_HOUR} AM";
			}
			else if (Mathf.Floor(amountOfTime) == 240f)
			{
				amountOfTime = 240f;
				NIGHT_HOUR = 2;

				nightHourText.text = $"{NIGHT_HOUR} AM";
			}
			else if (Mathf.Floor(amountOfTime) == 180f)
			{
				amountOfTime = 180f;
				NIGHT_HOUR = 3;

				nightHourText.text = $"{NIGHT_HOUR} AM";
			}
			else if (Mathf.Floor(amountOfTime) == 120f)
			{
				amountOfTime = 120f;
				NIGHT_HOUR = 4;

				nightHourText.text = $"{NIGHT_HOUR} AM";
			}
			else if (Mathf.Floor(amountOfTime) == 60f)
			{
				amountOfTime = 60f;
				NIGHT_HOUR = 5;

				nightHourText.text = $"{NIGHT_HOUR} AM";
			}
			else if (Mathf.Floor(amountOfTime) == 0f)
			{
				amountOfTime = 0f;
				NIGHT_HOUR = 6;

				if (PanAI.PAN_AI_LEVEL == 20 && MikeyAI.MIKEY_AI_LEVEL == 20 && TravisAI.TRAVIS_AI_LEVEL == 20 && OwlAI.OWL_AI_LEVEL == 20)
				{
					MainMenu.STAR2 = true;
				}

				nightHourText.text = $"{NIGHT_HOUR} AM";
				SceneManager.LoadSceneAsync("CN 6AM");
			}
		}
	}
}
