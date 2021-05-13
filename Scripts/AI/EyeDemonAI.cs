using UnityEngine;
using UnityEngine.UI;
using OneWeekAtPan.Core;
using System.Collections;
using OneWeekAtPan.Systems;
using UnityEngine.SceneManagement;

namespace OneWeekAtPan.AI
{
	public class EyeDemonAI : MonoBehaviour
	{
		[Header("Variables:")]
		public int currentCamera = 0;
		public float timeBetwenMovement;
		public static float minTimeBetwenMovement;
		public static float maxTimeBetwenMovement;

		[Header("Components:")]
		[SerializeField] private RawImage cameraStatic;
		[Space]
		[SerializeField] private AudioClip[] eyeDemonAudioClip; // AudioClips: jumpScareSFX, lighFlickerSFX, staticSFX
		private Main main;
		private CameraSystem cameraSys;
		private TravisAI travisAI;
		private MainCamera mainCamera;
		private AudioSource eyeDemonAudioSource;

		[Header("GameObjects:")]
		[SerializeField] private GameObject eyeDemonObject;
		[SerializeField] private GameObject mainCameraObject;
		[SerializeField] private GameObject mainCanvasObject;
		[SerializeField] private GameObject[] animatronics;
		[Space]
		[SerializeField] private GameObject[] roomLights;
		[SerializeField] private GameObject[] roomObjects;
		private GameObject travisObject;
		private GameObject panObject;
		private GameObject mikeyObject;
		private GameObject owlObject;

		void Start()
		{
			travisObject = GameObject.Find("Travis");
			panObject = GameObject.Find("Pan");
			mikeyObject = GameObject.Find("Mikey");
			owlObject = GameObject.Find("Owl");

			main = mainCanvasObject.GetComponent<Main>();
			travisAI = travisObject.GetComponent<TravisAI>();
			eyeDemonAudioSource = eyeDemonObject.GetComponent<AudioSource>();
			mainCamera = mainCameraObject.GetComponent<MainCamera>();
			cameraSys = mainCanvasObject.GetComponent<CameraSystem>();

			panObject.SetActive(false);
			mikeyObject.SetActive(false);
			owlObject.SetActive(false);

			StartCoroutine(FlashLightsFastWithSound());

			AIlevel.EyeDemonMovingTime();
			timeBetwenMovement = Random.Range(minTimeBetwenMovement, maxTimeBetwenMovement);
		}

		void Update()
		{
			timeBetwenMovement -= Time.deltaTime;

			if (timeBetwenMovement < 0)
			{
				timeBetwenMovement = 0;
			}

			if (Main.night != 1 && travisAI.currentCamera == 3)
			{
				foreach (var animatronic in animatronics)
				{
					animatronic.SetActive(false);
				}

				timeBetwenMovement = 10000;
			}

			// Bathroom phaze 0 >> Bathroom phaze 1
			if (timeBetwenMovement <= 0 && currentCamera == 0)
			{
				if (cameraSys.cameraNumber == 8)
				{
					cameraStatic.CrossFadeAlpha(100, 0.1f, false);

					if (cameraSys.isCameraActive)
					{
						eyeDemonAudioSource.clip = eyeDemonAudioClip[2];
						eyeDemonAudioSource.Play();
					}
				}

				animatronics[0].SetActive(false);
				animatronics[1].SetActive(true);
				currentCamera++;

				AIlevel.EyeDemonMovingTime();
				timeBetwenMovement = Random.Range(minTimeBetwenMovement, maxTimeBetwenMovement);
				Invoke(nameof(StaticEffectToNormalOppacity), 0.5f);
			}

			// Bathroom phaze 1 >> Hallway03 phaze01
			if (timeBetwenMovement <= 0 && currentCamera == 1)
			{
				if (cameraSys.cameraNumber == 8 || cameraSys.cameraNumber == 3)
				{
					cameraStatic.CrossFadeAlpha(100, 0.1f, false);

					if (cameraSys.isCameraActive)
					{
						eyeDemonAudioSource.clip = eyeDemonAudioClip[2];
						eyeDemonAudioSource.Play();
					}
				}

				animatronics[1].SetActive(false);
				animatronics[2].SetActive(true);
				currentCamera++;

				AIlevel.EyeDemonMovingTime();
				timeBetwenMovement = Random.Range(minTimeBetwenMovement, maxTimeBetwenMovement);
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
						eyeDemonAudioSource.clip = eyeDemonAudioClip[2];
						eyeDemonAudioSource.Play();
					}
				}

				animatronics[2].SetActive(false);
				animatronics[3].SetActive(true);
				currentCamera++;

				AIlevel.EyeDemonMovingTime();
				timeBetwenMovement = Random.Range(minTimeBetwenMovement, maxTimeBetwenMovement);
				Invoke(nameof(StaticEffectToNormalOppacity), 0.5f);
			}

			// Hallway03 phaze02 >> Hallway02 door || Hallway01
			if (timeBetwenMovement <= 0 && currentCamera == 3)
			{
				if (cameraSys.cameraNumber == 3 || cameraSys.cameraNumber == 2 || cameraSys.cameraNumber == 1)
				{
					cameraStatic.CrossFadeAlpha(100, 0.1f, false);

					if (cameraSys.isCameraActive)
					{
						eyeDemonAudioSource.clip = eyeDemonAudioClip[2];
						eyeDemonAudioSource.Play();
					}
				}

				currentCamera = Random.Range(4, 5);

				animatronics[3].SetActive(false);

				if (currentCamera == 4)
				{
					animatronics[4].SetActive(true);
					timeBetwenMovement = Random.Range(3, 5);

					if (!Main.isJumpscare)
					{
						StartCoroutine(nameof(FlashLightsFast));
					}
				}
				else if (currentCamera == 5)
				{
					animatronics[5].SetActive(true);

					AIlevel.EyeDemonMovingTime();
					timeBetwenMovement = Random.Range(minTimeBetwenMovement, maxTimeBetwenMovement);
				}

				Invoke(nameof(StaticEffectToNormalOppacity), 0.5f);
			}

			// Hallway01 >> Hallway01 door
			if (timeBetwenMovement <= 0 && currentCamera == 5)
			{
				if (cameraSys.cameraNumber == 1)
				{
					cameraStatic.CrossFadeAlpha(100, 0.1f, false);

					if (cameraSys.isCameraActive)
					{
						eyeDemonAudioSource.clip = eyeDemonAudioClip[2];
						eyeDemonAudioSource.Play();
					}
				}

				animatronics[5].SetActive(false);
				animatronics[6].SetActive(true);
				currentCamera++;

				timeBetwenMovement = Random.Range(3, 5);
				Invoke(nameof(StaticEffectToNormalOppacity), 0.5f);
			}

			// Hallway02 door || Hallway01 door >> Bathroom phaze 1 || Hallway03 phaze01
			if (timeBetwenMovement <= 0 && mainCamera.crouchTime <= 0 && mainCamera.isCrouching && (currentCamera == 4 || currentCamera == 6))
			{
				animatronics[6].SetActive(false);
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

				AIlevel.EyeDemonMovingTime();
				timeBetwenMovement = Random.Range(minTimeBetwenMovement, maxTimeBetwenMovement);
			}

			// Hallway02 door|| Hallway01 door >> Office
			if (timeBetwenMovement <= 0 && !mainCamera.isCrouching && !Main.isJumpscare && (currentCamera == 4 || currentCamera == 6))
			{
				cameraStatic.CrossFadeAlpha(100, 0.1f, false);

				cameraSys.cameraButtonOn.SetActive(false);
				cameraSys.cameraButtonOff.SetActive(false);

				if (cameraSys.isCameraActive)
				{
					cameraSys.DeactivateCamSys();
				}

				Main.isJumpscare = true;

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
			eyeDemonAudioSource.clip = eyeDemonAudioClip[0];
			eyeDemonAudioSource.Play();

			mainCamera.cameraAnimator.SetBool("isLeft", false);
			mainCamera.cameraAnimator.SetBool("isRight", false);

			foreach (var objects in roomObjects)
			{
				objects.SetActive(false);
			}

			roomLights[1].SetActive(true);

			animatronics[6].SetActive(false);
			animatronics[7].SetActive(true);

			Invoke(nameof(Die), 2f);
		}

		private IEnumerator FlashLights()
		{
			foreach (var light in roomLights)
			{
				light.SetActive(false);
			}

			eyeDemonAudioSource.clip = eyeDemonAudioClip[1];
			eyeDemonAudioSource.Play();

			yield return new WaitForSeconds(0.05f);

			foreach (var light in roomLights)
			{
				light.SetActive(true);
			}

			eyeDemonAudioSource.clip = eyeDemonAudioClip[1];
			eyeDemonAudioSource.Play();

			yield return new WaitForSeconds(0.1f);

			foreach (var light in roomLights)
			{
				light.SetActive(false);
			}

			eyeDemonAudioSource.clip = eyeDemonAudioClip[1];
			eyeDemonAudioSource.Play();
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

		private IEnumerator FlashLightsFastWithSound()
		{
			foreach (var light in roomLights)
			{
				light.SetActive(false);
			}

			eyeDemonAudioSource.clip = eyeDemonAudioClip[1];
			eyeDemonAudioSource.Play();

			yield return new WaitForSeconds(0.05f);

			foreach (var light in roomLights)
			{
				light.SetActive(true);
			}
		}
	}
}