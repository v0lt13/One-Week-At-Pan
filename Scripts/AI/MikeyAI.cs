using UnityEngine;
using UnityEngine.UI;
using OneWeekAtPan.Core;
using System.Collections;
using OneWeekAtPan.Systems;
using UnityEngine.SceneManagement;

namespace OneWeekAtPan.AI
{
	public class MikeyAI : MonoBehaviour
	{
		[Header("Variables:")]
		public static int MIKEY_AI_LEVEL;
		public int currentCamera = 0;
		public float timeBetwenMovement;
		public static float MIN_TIME_BETWEN_MOVEMENT;
		public static float MAX_TIME_BETWEN_MOVEMENT;

		[Header("Components:")]
		[SerializeField] private RawImage cameraStatic;
		[Space]
		[SerializeField] private AudioClip[] mikeyAudioClip; // AudioClips: footstep, jumpScareSFX, lighFlickerSFX, staticSFX
		private Main main;
		private CameraSystem cameraSys;
		private TravisAI travisAI;
		private MainCamera mainCamera;
		private AudioSource mikeyAudioSource;

		[Header("GameObjects:")]
		public GameObject[] animatronics;
		[SerializeField] private GameObject mikeyObject;
		[SerializeField] private GameObject mainCameraObject;
		[SerializeField] private GameObject mainCanvasObject;
		[Space]
		[SerializeField] private GameObject[] roomLights;
		[SerializeField] private GameObject[] roomObjects;
		private GameObject travisObject;

		void Start()
		{
			travisObject = GameObject.Find("Travis");

			main = mainCanvasObject.GetComponent<Main>();
			cameraSys = mainCanvasObject.GetComponent<CameraSystem>();
			travisAI = travisObject.GetComponent<TravisAI>();
			mainCamera = mainCameraObject.GetComponent<MainCamera>();
			mikeyAudioSource = mikeyObject.GetComponent<AudioSource>();

			AIlevel.MikeyMovingTime();
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

			// Stage phaze01 >> Stage phaze02
			if (timeBetwenMovement <= 0 && currentCamera == 0)
			{
				if (cameraSys.cameraNumber == 10)
				{
					cameraStatic.CrossFadeAlpha(100, 0.1f, false);

					if (cameraSys.isCameraActive)
					{
						mikeyAudioSource.clip = mikeyAudioClip[3];
						mikeyAudioSource.Play();
					}
				}

				animatronics[0].SetActive(false);
				animatronics[1].SetActive(true);
				currentCamera++;

				AIlevel.MikeyMovingTime();
				timeBetwenMovement = Random.Range(MIN_TIME_BETWEN_MOVEMENT, MAX_TIME_BETWEN_MOVEMENT);
				Invoke(nameof(StaticEffectToNormalOppacity), 0.5f);
			}

			// Stage phaze02 >> Hallway03
			if (timeBetwenMovement <= 0 && currentCamera == 1)
			{
				if (cameraSys.cameraNumber == 10 || cameraSys.cameraNumber == 3)
				{

					if (cameraSys.isCameraActive)
					{
						mikeyAudioSource.clip = mikeyAudioClip[3];
						mikeyAudioSource.Play();
					}
					cameraStatic.CrossFadeAlpha(100, 0.1f, false);
				}

				animatronics[1].SetActive(false);
				animatronics[2].SetActive(true);
				currentCamera++;

				AIlevel.MikeyMovingTime();
				timeBetwenMovement = Random.Range(MIN_TIME_BETWEN_MOVEMENT, MAX_TIME_BETWEN_MOVEMENT);
				Invoke(nameof(StaticEffectToNormalOppacity), 0.5f);
			}

			// Hallway03 >> StorageRoom || Hallway01
			if (timeBetwenMovement <= 0 && currentCamera == 2)
			{
				if (cameraSys.cameraNumber == 3 || cameraSys.cameraNumber == 5 || cameraSys.cameraNumber == 1)
				{
					cameraStatic.CrossFadeAlpha(100, 0.1f, false);

					if (cameraSys.isCameraActive)
					{
						mikeyAudioSource.clip = mikeyAudioClip[3];
						mikeyAudioSource.Play();
					}
				}

				currentCamera = Random.Range(3, 6);

				animatronics[2].SetActive(false);

				if (currentCamera == 3)
				{
					animatronics[3].SetActive(true);
				}
				else if (currentCamera >= 4)
				{
					currentCamera = 4;
					animatronics[4].SetActive(true);
				}

				AIlevel.MikeyMovingTime();
				timeBetwenMovement = Random.Range(MIN_TIME_BETWEN_MOVEMENT, MAX_TIME_BETWEN_MOVEMENT);
				Invoke(nameof(StaticEffectToNormalOppacity), 0.5f);
			}

			// StorageRoom >> Hallway03
			if (timeBetwenMovement <= 0 && currentCamera == 3)
			{
				if (cameraSys.cameraNumber == 3 || cameraSys.cameraNumber == 5)
				{
					cameraStatic.CrossFadeAlpha(100, 0.1f, false);

					if (cameraSys.isCameraActive)
					{
						mikeyAudioSource.clip = mikeyAudioClip[3];
						mikeyAudioSource.Play();
					}
				}

				animatronics[3].SetActive(false);
				animatronics[2].SetActive(true);
				currentCamera = 2;

				AIlevel.MikeyMovingTime();
				timeBetwenMovement = Random.Range(MIN_TIME_BETWEN_MOVEMENT, MAX_TIME_BETWEN_MOVEMENT);
				Invoke(nameof(StaticEffectToNormalOppacity), 0.5f);
			}

			// Hallway01 >> Hallway01 door
			if (timeBetwenMovement <= 0 && currentCamera == 4)
			{
				if (cameraSys.cameraNumber == 1)
				{
					cameraStatic.CrossFadeAlpha(100, 0.1f, false);

					if (cameraSys.isCameraActive)
					{
						mikeyAudioSource.clip = mikeyAudioClip[3];
						mikeyAudioSource.Play();
					}
				}

				animatronics[4].SetActive(false);
				animatronics[5].SetActive(true);
				currentCamera++;

				if (!Main.IS_JUMPSCARE)
				{
					StartCoroutine(nameof(FlashLightsFast));
				}

				timeBetwenMovement = Random.Range(3, 5);
				Invoke(nameof(StaticEffectToNormalOppacity), 0.5f);
			}

			// Hallway01 door >> Stage phaze02 || Hallway03
			if (timeBetwenMovement <= 0 && mainCamera.crouchTime <= 0 && currentCamera == 5 && mainCamera.isCrouching)
			{
				animatronics[5].SetActive(false);
				currentCamera = Random.Range(1, 2);

				if (currentCamera == 1)
				{
					animatronics[1].SetActive(true);
				}
				else if (currentCamera == 2)
				{
					animatronics[2].SetActive(true);
				}

				mikeyAudioSource.clip = mikeyAudioClip[0];
				mikeyAudioSource.Play();

				AIlevel.MikeyMovingTime();
				timeBetwenMovement = Random.Range(MIN_TIME_BETWEN_MOVEMENT, MAX_TIME_BETWEN_MOVEMENT);
			}

			// Hallway01 door >> Office
			if (timeBetwenMovement <= 0 && currentCamera == 5 && !mainCamera.isCrouching && !Main.IS_JUMPSCARE)
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
			mikeyAudioSource.clip = mikeyAudioClip[1];
			mikeyAudioSource.Play();

			mainCamera.cameraAnimator.SetBool("isLeft", false);
			mainCamera.cameraAnimator.SetBool("isRight", false);

			foreach (var objects in roomObjects)
			{
				objects.SetActive(false);
			}

			roomLights[1].SetActive(true);

			animatronics[5].SetActive(false);
			animatronics[6].SetActive(true);

			Invoke(nameof(Die), 2f);
		}

		private IEnumerator FlashLights()
		{
			foreach (var lights in roomLights)
			{
				lights.SetActive(false);
			}

			mikeyAudioSource.clip = mikeyAudioClip[2];
			mikeyAudioSource.Play();

			yield return new WaitForSeconds(0.05f);

			foreach (var lights in roomLights)
			{
				lights.SetActive(true);
			}

			mikeyAudioSource.clip = mikeyAudioClip[2];
			mikeyAudioSource.Play();

			yield return new WaitForSeconds(0.1f);

			foreach (var lights in roomLights)
			{
				lights.SetActive(false);
			}

			mikeyAudioSource.clip = mikeyAudioClip[2];
			mikeyAudioSource.Play();
		}

		private IEnumerator FlashLightsFast()
		{
			foreach (var lights in roomLights)
			{
				lights.SetActive(false);
			}

			yield return new WaitForSeconds(0.05f);

			foreach (var lights in roomLights)
			{
				lights.SetActive(true);
			}
		}
	}
}