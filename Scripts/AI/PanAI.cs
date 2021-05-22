using UnityEngine;
using UnityEngine.UI;
using OneWeekAtPan.Core;
using System.Collections;
using OneWeekAtPan.Systems;
using UnityEngine.SceneManagement;

namespace OneWeekAtPan.AI
{
	public class PanAI : MonoBehaviour
	{
		[Header("Variables:")]
		public static int PAN_AI_LEVEL;
		public int currentCamera = 0;
		public float timeBetwenMovement;
		public static float MIN_TIME_BETWEN_MOVEMENT;
		public static float MAX_TIME_BETWEN_MOVEMENT;

		[Header("Components:")]
		[SerializeField] private RawImage cameraStatic;
		[Space]
		[SerializeField] private AudioClip[] panAudioClip; // AudioClips: footstep, jumpScareSFX, lighFlickerSFX, staticSFX
		private Main main;
		private CameraSystem cameraSys;
		private MikeyAI mikeyAI;
		private TravisAI travisAI;
		private MainCamera mainCamera;
		private AudioSource panAudioSource;

		[Header("GameObjects:")]
		public GameObject[] animatronics;
		[SerializeField] private GameObject panObject;
		[SerializeField] private GameObject mainCameraObject;
		[SerializeField] private GameObject mainCanvasObject;
		[Space]
		[SerializeField] private GameObject[] roomLights;
		[SerializeField] private GameObject[] roomObjects;
		private GameObject mikeyObject;
		private GameObject travisObject;

		void Start()
		{
			mikeyObject = GameObject.Find("Mikey");
			travisObject = GameObject.Find("Travis");

			main = mainCanvasObject.GetComponent<Main>();
			mikeyAI = mikeyObject.GetComponent<MikeyAI>();
			travisAI = travisObject.GetComponent<TravisAI>();
			panAudioSource = panObject.GetComponent<AudioSource>();
			mainCamera = mainCameraObject.GetComponent<MainCamera>();
			cameraSys = mainCanvasObject.GetComponent<CameraSystem>();

			AIlevel.PanMovingTime();
			timeBetwenMovement = Random.Range(MIN_TIME_BETWEN_MOVEMENT, MAX_TIME_BETWEN_MOVEMENT);
		}

		void Update()
		{
			timeBetwenMovement -= Time.deltaTime;

			if (timeBetwenMovement < 0)
			{
				timeBetwenMovement = 0;
			}

			if (Main.NIGHT != 1 && travisAI.currentCamera == 3)
			{
				foreach (var animatronic in animatronics)
				{
					animatronic.SetActive(false);
				}

				timeBetwenMovement = 10000;
			}

			// Stage >> Playroom
			if (timeBetwenMovement <= 0 && currentCamera == 0)
			{
				if (cameraSys.cameraNumber == 10 || cameraSys.cameraNumber == 9)
				{
					cameraStatic.CrossFadeAlpha(100, 0.1f, false);

					if (cameraSys.isCameraActive)
					{
						panAudioSource.clip = panAudioClip[3];
						panAudioSource.Play();
					}
				}

				animatronics[0].SetActive(false);
				animatronics[1].SetActive(true);
				currentCamera++;

				AIlevel.PanMovingTime();
				timeBetwenMovement = Random.Range(MIN_TIME_BETWEN_MOVEMENT, MAX_TIME_BETWEN_MOVEMENT);
				Invoke(nameof(StaticEffectToNormalOppacity), 0.5f);
			}

			// Playroom >> Hallway03 phaze01
			if (timeBetwenMovement <= 0 && currentCamera == 1)
			{
				if (cameraSys.cameraNumber == 9 || cameraSys.cameraNumber == 3)
				{
					cameraStatic.CrossFadeAlpha(100, 0.1f, false);

					if (cameraSys.isCameraActive)
					{
						panAudioSource.clip = panAudioClip[3];
						panAudioSource.Play();
					}
				}

				animatronics[1].SetActive(false);
				animatronics[2].SetActive(true);
				currentCamera++;

				AIlevel.PanMovingTime();
				timeBetwenMovement = Random.Range(MIN_TIME_BETWEN_MOVEMENT, MAX_TIME_BETWEN_MOVEMENT);
				Invoke(nameof(StaticEffectToNormalOppacity), 0.5f);
			}

			// Hallway03 phaze01 >> Hallway03 phaze02
			if (timeBetwenMovement <= 0 && currentCamera == 2)
			{
				if (cameraSys.cameraNumber == 3)
				{
					cameraStatic.CrossFadeAlpha(100, 0.1f, false);

					if (cameraSys.isCameraActive)
					{
						panAudioSource.clip = panAudioClip[3];
						panAudioSource.Play();
					}
				}

				animatronics[2].SetActive(false);
				animatronics[3].SetActive(true);
				currentCamera++;

				AIlevel.PanMovingTime();
				timeBetwenMovement = Random.Range(MIN_TIME_BETWEN_MOVEMENT, MAX_TIME_BETWEN_MOVEMENT);
				Invoke(nameof(StaticEffectToNormalOppacity), 0.5f);
			}

			// Hallway03 phaze02 >> Hallway02 door
			if (timeBetwenMovement <= 0 && currentCamera == 3)
			{
				if (cameraSys.cameraNumber == 3 || cameraSys.cameraNumber == 2)
				{
					cameraStatic.CrossFadeAlpha(100, 0.1f, false);

					if (cameraSys.isCameraActive)
					{
						panAudioSource.clip = panAudioClip[3];
						panAudioSource.Play();
					}
				}

				animatronics[3].SetActive(false);
				animatronics[4].SetActive(true);
				currentCamera++;

				if (!Main.IS_JUMPSCARE)
				{
					StartCoroutine(nameof(FlashLightsFast));
				}

				timeBetwenMovement = Random.Range(3, 5);
				Invoke(nameof(StaticEffectToNormalOppacity), 0.5f);
			}

			// Hallway02 door >> Playroom || Hallway03 phaze01
			if (timeBetwenMovement <= 0 && mainCamera.crouchTime <= 0 && mainCamera.isCrouching && currentCamera == 4)
			{
				animatronics[4].SetActive(false);
				currentCamera = Random.Range(1, 3);

				if (currentCamera == 1)
				{
					animatronics[1].SetActive(true);
				}
				else if (currentCamera >= 2)
				{
					currentCamera = 2;
					animatronics[2].SetActive(true);
				}

				panAudioSource.clip = panAudioClip[0];
				panAudioSource.Play();

				AIlevel.PanMovingTime();
				timeBetwenMovement = Random.Range(MIN_TIME_BETWEN_MOVEMENT, MAX_TIME_BETWEN_MOVEMENT);
			}

			// Hallway02 door >> Office
			if (timeBetwenMovement <= 0 && currentCamera == 4 && !mainCamera.isCrouching && mikeyAI.currentCamera < 5 && !Main.IS_JUMPSCARE)
			{
				cameraStatic.CrossFadeAlpha(100, 0.1f, false);

				if (cameraSys.isCameraActive)
				{
					cameraSys.DeactivateCamSys();
				}

				cameraSys.cameraButtonOn.SetActive(false);
				cameraSys.cameraButtonOff.SetActive(false);

				Main.IS_JUMPSCARE = true;

				timeBetwenMovement = 100f;
				StartCoroutine(nameof(FlashLights));

				Invoke(nameof(StaticEffectToNormalOppacity), 0.5f);
				Invoke(nameof(JumpScare), 2f);
			}
		}

		private void Die()
		{
			SceneManager.LoadScene("GameOver");
		}

		private void StaticEffectToNormalOppacity()
		{
			cameraStatic.CrossFadeAlpha(1, 0.1f, false);
		}

		private void JumpScare()
		{
			panAudioSource.clip = panAudioClip[1];
			panAudioSource.Play();

			mainCamera.cameraAnimator.SetBool("isLeft", false);
			mainCamera.cameraAnimator.SetBool("isRight", false);

			foreach (var objects in roomObjects)
			{
				objects.SetActive(false);
			}

			roomLights[1].SetActive(true);

			animatronics[4].SetActive(false);
			animatronics[5].SetActive(true);

			Invoke(nameof(Die), 2f);
		}

		private IEnumerator FlashLights()
		{
			foreach (var light in roomLights)
			{
				light.SetActive(false);
			}

			panAudioSource.clip = panAudioClip[2];
			panAudioSource.Play();

			yield return new WaitForSeconds(0.05f);

			foreach (var light in roomLights)
			{
				light.SetActive(true);
			}

			panAudioSource.clip = panAudioClip[2];
			panAudioSource.Play();

			yield return new WaitForSeconds(0.1f);

			foreach (var light in roomLights)
			{
				light.SetActive(false);
			}

			panAudioSource.clip = panAudioClip[2];
			panAudioSource.Play();
		}

		private IEnumerator FlashLightsFast()
		{
			foreach (var light in roomLights)
			{
				light.SetActive(false);
			}

			yield return new WaitForSeconds(0.05f);

			foreach (var light in roomLights)
			{
				light.SetActive(true);
			}
		}
	}
}