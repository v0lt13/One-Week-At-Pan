using UnityEngine;
using UnityEngine.UI;
using OneWeekAtPan.CN;
using OneWeekAtPan.Core;
using OneWeekAtPan.GameControls;

namespace OneWeekAtPan.Systems
{
	public class CameraSystem : MonoBehaviour
	{
		[HideInInspector] public int cameraNumber = 1;
		[HideInInspector] public bool isCameraActive = false;
		private int currentTexture;
		private float timeBetwenTextures;
		private string roomName;

		[Header("Components:")]
		[HideInInspector] public AudioSource mainAudioSource;
		public AudioClip[] mainAudioClip; // AudioClips: camsOffSFX, camButtonSFX, PhoneHangUp, camsOnSFX
		[SerializeField] private Texture[] staticEffectTextures;
		[Space]
		[SerializeField] private Text roomNameText;
		private Main main;
		private HeatSystem heatSystem;
		private LightControls lightControls;
		private Animator mainAnimator;
		private RawImage staticEffect;
		private Transform mainCameraTransform;

		[Header("GameObjects:")]
		public GameObject cameraButtonOn;
		public GameObject cameraButtonOff;
		[Space]
		public GameObject[] lookTriggers;
		[Space]
		[SerializeField] private GameObject cameraSystem;
		[SerializeField] private GameObject staticEffectObject;
		[SerializeField] private GameObject officeCamera;
		[SerializeField] private GameObject chairs;
		[SerializeField] private GameObject easterEggPan;
		[SerializeField] private GameObject easterEggMikey;
		[SerializeField] private GameObject easterEggBlood;
		[SerializeField] private GameObject easterEggChairs;
		[Space]
		[SerializeField] private GameObject[] cameraSystemObjects; // Objects: CameraStatic, Cam01AButton -> Cam07BButton, MAP, RoomName
		[SerializeField] private GameObject[] cameras; // Objects: Main Camera, Cam01A -> Cam07B

		void Start()
		{
			main = gameObject.GetComponent<Main>();
			mainCameraTransform = officeCamera.GetComponent<Transform>();
			mainAnimator = officeCamera.GetComponent<Animator>();
			staticEffect = staticEffectObject.GetComponent<RawImage>();
			mainAudioSource = cameraSystem.GetComponent<AudioSource>();

			if (Main.NIGHT != 1)
			{
				heatSystem = GetComponent<HeatSystem>();
				lightControls = GetComponent<LightControls>();
			}

			if (MainCamera.IS_MOUSE_CONTROLS)
			{
				foreach (var triggers in lookTriggers)
				{
					triggers.SetActive(true);
				}
			}
			else
			{
				foreach (var triggers in lookTriggers)
				{
					triggers.SetActive(false);
				}
			}
		}

		void Update()
		{
			StaticEffect();

			if (!CustomNight.IS_CUSTOM_NIGHT)
			{
				if (cameraNumber != 10)
				{
					easterEggMikey.SetActive(false);
					easterEggPan.SetActive(false);

					if (main.mikeyAI.currentCamera == 0)
					{
						main.mikeyAI.animatronics[0].SetActive(true);
					}

					if (main.panAI.currentCamera == 0)
					{
						main.panAI.animatronics[0].SetActive(true);
					}
				}

				if (main.mikeyAI.currentCamera != 0)
				{
					easterEggMikey.SetActive(false);
				}

				if (main.panAI.currentCamera != 0)
				{
					easterEggPan.SetActive(false);
				}
			}

			if (Main.IS_JUMPSCARE || CustomNight.IS_JUMPSCARE)
			{
				foreach (var trigger in lookTriggers)
				{
					trigger.SetActive(false);
				}
			}
		}

		public void ActivateCamSys()
		{
			if (!mainAnimator.GetBool("isLeft") && !mainAnimator.GetBool("isRight") && !mainAnimator.GetBool("isHideing") && !Main.IS_JUMPSCARE)
			{
				foreach (var cam in cameraSystemObjects)
				{
					cam.SetActive(true);
				}

				if (PlayerPrefs.GetString("camName") == "")
				{
					roomNameText.text = "Hallway 1";
				}
				else
				{
					roomNameText.text = PlayerPrefs.GetString("camName");
				}

				if (PlayerPrefs.GetInt("heKnowsLights") != 1 && Main.NIGHT != 1 && lightControls != null)
				{
					lightControls.lightControls.SetActive(true);
				}

				mainCameraTransform.position = new Vector3(15f, 1f, 11f);
				mainCameraTransform.rotation = Quaternion.Euler(0f, 0f, 0f);

				isCameraActive = true;

				RenderSettings.ambientLight = new Color(0.11f, 0.11f, 0.11f);

				cameraButtonOn.SetActive(false);
				cameraButtonOff.SetActive(true);

				if (MainCamera.IS_MOUSE_CONTROLS)
				{
					foreach (var triggers in lookTriggers)
					{
						triggers.SetActive(false);
					}
				}

				staticEffect.CrossFadeAlpha(100, 0.1f, false);
				Invoke(nameof(StaticEffectToNormalOppacity), 0.1f);

				mainAudioSource.clip = mainAudioClip[3];
				mainAudioSource.Play();

				officeCamera.SetActive(false);

				PlayerPrefs.GetInt("cam");

				switch (cameraNumber)
				{
					case 1:
						EnableCamera(1);
						break;

					case 2:
						EnableCamera(2);
						break;

					case 3:
						EnableCamera(3);
						break;

					case 4:
						EnableCamera(4);
						break;

					case 5:
						EnableCamera(5);
						break;

					case 6:
						EnableCamera(6);
						break;

					case 7:
						EnableCamera(7);
						break;

					case 8:
						EnableCamera(8);
						break;

					case 9:
						EnableCamera(9);
						break;

					case 10:
						EnableCamera(10);
						break;
				}
			}
		}

		public void DeactivateCamSys()
		{
			foreach (var cam in cameraSystemObjects)
			{
				cam.SetActive(false);
			}

			isCameraActive = false;

			RenderSettings.ambientLight = Color.black;

			if (MainCamera.IS_MOUSE_CONTROLS)
			{
				foreach (var triggers in lookTriggers)
				{
					triggers.SetActive(true);
				}
			}

			if (PlayerPrefs.GetInt("heKnowsLights") != 1 && Main.NIGHT != 1 && lightControls != null)
			{
				lightControls.lightControls.SetActive(false);
			}

			cameraButtonOn.SetActive(true);
			cameraButtonOff.SetActive(false);

			mainAudioSource.clip = mainAudioClip[0];
			mainAudioSource.Play();

			foreach (var cam in cameras)
			{
				cam.SetActive(false);
			}

			officeCamera.SetActive(true);
		}

		public void Camera01A()
		{
			mainAudioSource.clip = mainAudioClip[1];
			mainAudioSource.Play();

			cameraNumber = 1;
			roomName = "Hallway 1";
			roomNameText.text = roomName;

			staticEffect.CrossFadeAlpha(100, 0.1f, false);
			Invoke(nameof(StaticEffectToNormalOppacity), 0.1f);

			PlayerPrefs.SetString("camName", roomName);
			PlayerPrefs.SetInt("cam", cameraNumber);
			PlayerPrefs.Save();

			DisableCameraLight();
			EnableCamera(1);
		}

		public void Camera01B()
		{
			mainAudioSource.clip = mainAudioClip[1];
			mainAudioSource.Play();

			cameraNumber = 2;
			roomName = "Hallway 2";
			roomNameText.text = roomName;

			staticEffect.CrossFadeAlpha(100, 0.1f, false);
			Invoke(nameof(StaticEffectToNormalOppacity), 0.1f);

			PlayerPrefs.SetString("camName", roomName);
			PlayerPrefs.SetInt("cam", cameraNumber);
			PlayerPrefs.Save();

			DisableCameraLight();
			EnableCamera(2);
		}

		public void Camera01C()
		{
			mainAudioSource.clip = mainAudioClip[1];
			mainAudioSource.Play();

			roomName = "Hallway 3";
			roomNameText.text = roomName;
			cameraNumber = 3;

			staticEffect.CrossFadeAlpha(100, 0.1f, false);
			Invoke(nameof(StaticEffectToNormalOppacity), 0.1f);

			PlayerPrefs.SetString("camName", roomName);
			PlayerPrefs.SetInt("cam", cameraNumber);
			PlayerPrefs.Save();

			DisableCameraLight();
			EnableCamera(3);
		}

		public void Camera02()
		{
			mainAudioSource.clip = mainAudioClip[1];
			mainAudioSource.Play();

			roomName = "Bedroom";
			roomNameText.text = roomName;
			cameraNumber = 4;

			staticEffect.CrossFadeAlpha(100, 0.1f, false);
			Invoke(nameof(StaticEffectToNormalOppacity), 0.1f);

			PlayerPrefs.SetString("camName", roomName);
			PlayerPrefs.SetInt("cam", cameraNumber);
			PlayerPrefs.Save();

			DisableCameraLight();
			EnableCamera(4);
		}

		public void Camera03()
		{
			mainAudioSource.clip = mainAudioClip[1];
			mainAudioSource.Play();

			roomName = "Storage Room";
			roomNameText.text = roomName;
			cameraNumber = 5;

			staticEffect.CrossFadeAlpha(100, 0.1f, false);
			Invoke(nameof(StaticEffectToNormalOppacity), 0.1f);

			PlayerPrefs.SetString("camName", roomName);
			PlayerPrefs.SetInt("cam", cameraNumber);
			PlayerPrefs.Save();

			DisableCameraLight();
			EnableCamera(5);
		}

		public void Camera04()
		{
			mainAudioSource.clip = mainAudioClip[1];
			mainAudioSource.Play();

			roomName = "Kitchen";
			roomNameText.text = roomName;
			cameraNumber = 6;

			staticEffect.CrossFadeAlpha(100, 0.1f, false);
			Invoke(nameof(StaticEffectToNormalOppacity), 0.1f);

			PlayerPrefs.SetString("camName", roomName);
			PlayerPrefs.SetInt("cam", cameraNumber);
			PlayerPrefs.Save();

			foreach (GameObject cam in cameras)
			{
				cam.SetActive(false);
			}

			DisableCameraLight();
			cameras[6].SetActive(true);
		}

		public void Camera05()
		{
			mainAudioSource.clip = mainAudioClip[1];
			mainAudioSource.Play();

			roomName = "Dining Room";
			roomNameText.text = roomName;
			cameraNumber = 7;

			if (Main.NIGHT >= 2)
			{
				int easterEgg = Random.Range(0, 100);

				if (easterEgg == 50)
				{
					easterEggChairs.SetActive(true);
					chairs.SetActive(false);
				}
				else
				{
					easterEggChairs.SetActive(false);
					chairs.SetActive(true);
				}
			}

			staticEffect.CrossFadeAlpha(100, 0.1f, false);
			Invoke(nameof(StaticEffectToNormalOppacity), 0.1f);

			PlayerPrefs.SetString("camName", roomName);
			PlayerPrefs.SetInt("cam", cameraNumber);
			PlayerPrefs.Save();

			DisableCameraLight();
			EnableCamera(7);
		}

		public void Camera06()
		{
			mainAudioSource.clip = mainAudioClip[1];
			mainAudioSource.Play();

			roomName = "Restroom";
			roomNameText.text = roomName;
			cameraNumber = 8;

			if (!CustomNight.IS_CUSTOM_NIGHT)
			{
				int easterEgg = Random.Range(0, 100);

				if (easterEgg == 50)
				{
					easterEggBlood.SetActive(true);
				}
				else
				{
					easterEggBlood.SetActive(false);
				}
			}

			staticEffect.CrossFadeAlpha(100, 0.1f, false);
			Invoke(nameof(StaticEffectToNormalOppacity), 0.1f);

			PlayerPrefs.SetString("camName", roomName);
			PlayerPrefs.SetInt("cam", cameraNumber);
			PlayerPrefs.Save();

			DisableCameraLight();
			EnableCamera(8);
		}

		public void Camera07A()
		{
			mainAudioSource.clip = mainAudioClip[1];
			mainAudioSource.Play();

			roomName = "Play Room";
			roomNameText.text = roomName;
			cameraNumber = 9;

			staticEffect.CrossFadeAlpha(100, 0.1f, false);
			Invoke(nameof(StaticEffectToNormalOppacity), 0.1f);

			PlayerPrefs.SetString("camName", roomName);
			PlayerPrefs.SetInt("cam", cameraNumber);
			PlayerPrefs.Save();

			DisableCameraLight();
			EnableCamera(9);
		}

		public void Camera07B()
		{
			mainAudioSource.clip = mainAudioClip[1];
			mainAudioSource.Play();

			roomName = "Stage";
			roomNameText.text = roomName;
			cameraNumber = 10;

			if (!CustomNight.IS_CUSTOM_NIGHT)
			{
				if (cameraNumber == 10 && main.panAI.currentCamera == 0 && main.mikeyAI.currentCamera == 0)
				{
					int easterEgg = Random.Range(0, 100);

					if (easterEgg == 50)
					{
						easterEggMikey.SetActive(true);
						easterEggPan.SetActive(true);
						main.panAI.animatronics[0].SetActive(false);
						main.mikeyAI.animatronics[0].SetActive(false);
					}
					else
					{
						easterEggMikey.SetActive(false);
						easterEggPan.SetActive(false);
						main.panAI.animatronics[0].SetActive(true);
						main.mikeyAI.animatronics[0].SetActive(true);
					}
				}
			}

			staticEffect.CrossFadeAlpha(100, 0.1f, false);
			Invoke(nameof(StaticEffectToNormalOppacity), 0.1f);

			PlayerPrefs.SetString("camName", roomName);
			PlayerPrefs.SetInt("cam", cameraNumber);
			PlayerPrefs.Save();

			DisableCameraLight();
			EnableCamera(10);
		}

		private void EnableCamera(int camera)
		{
			foreach (var cam in cameras)
			{
				cam.SetActive(false);
			}

			cameras[camera].SetActive(true);
		}

		private void StaticEffectToNormalOppacity()
		{
			staticEffect.CrossFadeAlpha(1, 0.1f, false);
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

		private void DisableCameraLight()
		{
			if (Main.NIGHT != 1)
			{
				heatSystem.DisableCameraLight();
			}
		}
	}
}