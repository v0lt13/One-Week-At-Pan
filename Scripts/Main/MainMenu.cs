using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.Collections;
using UnityEngine.SceneManagement;

namespace OneWeekAtPan.Core
{
	public class MainMenu : MonoBehaviour
	{
		public static bool STAR1 = false;
		public static bool STAR2 = false;
		public static bool STAR3 = false;
		private int star1;
		private int star2;
		private int star3;
		private int vsync;
		private int fullscreen;
		private int showFPS;
		private int controlsType;
		private int currentPanTexture;
		private int currentStaticImageTexture;
		private float timeBetwenPanTextures;
		private float timeBetwenStaticImageTextures;
		private float timeUntilDataDeleted = 3f;
		private bool isMenu;

		[Header("Components:")]
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
		[SerializeField] private Text volumeWarningText;
		[Space]
		[SerializeField] private Dropdown resolutionDropdown;
		[Space]
		[SerializeField] private Texture[] panFaceTextures;
		private RawImage panFace;
		private ButtonPointer buttonPointer;

		[Header("GameObjects:")]
		[SerializeField] private GameObject continueButtonObject;
		[SerializeField] private GameObject extrasButtonObject;
		[SerializeField] private GameObject customNightButtonObject;
		[SerializeField] private GameObject optionsObjects;
		[SerializeField] private GameObject mainMenuObjects;
		[Space]
		[SerializeField] private GameObject[] resolutionDropdownObjects;
		[SerializeField] private GameObject[] staticEffectImageObjects;
		[SerializeField] private GameObject[] stars;
		private GameObject panFaceObject;

		void Awake()
		{
			SetSettings();
			SetStars();
		}

		void Start()
		{
			panFaceObject = GameObject.Find("PanFace");

			panFace = panFaceObject.GetComponent<RawImage>();
			buttonPointer = GetComponent<ButtonPointer>();

			nightNumberText.text = PlayerPrefs.GetInt("Night") <= 7 ? PlayerPrefs.GetInt("Night").ToString() : nightNumberText.text = "7";

			isMenu = true;
			timeBetwenPanTextures = Random.Range(1f, 5f);

			if (PlayerPrefs.GetInt("Night") > 1)
			{
				continueButtonObject.SetActive(true);
			}

			if (PlayerPrefs.GetInt("Night") > 7)
			{
				extrasButtonObject.SetActive(true);
				customNightButtonObject.SetActive(true);
			}

			if (PlayerPrefs.GetInt("star1") == 1)
			{
				stars[0].SetActive(true);
			}

			if (PlayerPrefs.GetInt("star2") == 1)
			{
				stars[1].SetActive(true);
			}

			if (PlayerPrefs.GetInt("star3") == 1)
			{
				stars[2].SetActive(true);
			}
		}

		void Update()
		{
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

			if (volumeSlider.value < -15)
			{
				volumeWarningText.text = "WARNING: this game is sound based! Turning the volume very low will increase the difficulty of the game";
			}
			else
			{
				volumeWarningText.text = "";
			}
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
				MainCamera.IS_MOUSE_CONTROLS = false;
				controlsText.text = "Keyboard";
				controlsType = 1;
			}
			else if (!controlsType_)
			{
				MainCamera.IS_MOUSE_CONTROLS = true;
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
				Framerate.SHOW_FPS = true;
				showFPS = 1;
			}
			else if (!fps)
			{
				Framerate.SHOW_FPS = false;
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

		public void NewGame()
		{
			SceneManager.LoadScene("Night01S");
			PlayerPrefs.SetInt("Night", 1);
		}

		public void Continue()
		{
			switch (PlayerPrefs.GetInt("Night"))
			{
				case 2:
					SceneManager.LoadScene("Night02S");
					break;

				case 3:
					SceneManager.LoadScene("Night03S");
					break;

				case 4:
					SceneManager.LoadScene("Night04S");
					break;

				case 5:
					SceneManager.LoadScene("Night05S");
					break;

				case 6:
					SceneManager.LoadScene("Night06S");
					break;

				case 7:
					SceneManager.LoadScene("Night07S");
					break;

				default:
					SceneManager.LoadScene("Night07S");
					break;
			}
		}

		public void CustomNight()
		{
			SceneManager.LoadScene("CustomNightMenu");
		}

		public void DiscordButton()
		{
			Application.OpenURL("https://discord.gg/jKXvXyTzYn");
		}

		public void Extras()
		{
			SceneManager.LoadScene("ExtrasMenu");
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

		private void SetStars()
		{
			if (STAR1)
			{
				star1 = 1;
				PlayerPrefs.SetInt("star1", star1);
				PlayerPrefs.Save();
			}

			if (STAR2)
			{
				star2 = 1;
				PlayerPrefs.SetInt("star2", star2);
				PlayerPrefs.Save();
			}

			if (STAR3)
			{
				star3 = 1;
				PlayerPrefs.SetInt("star3", star3);
				PlayerPrefs.Save();
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
}
