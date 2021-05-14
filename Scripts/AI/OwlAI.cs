using UnityEngine;
using UnityEngine.UI;
using OneWeekAtPan.Core;
using System.Collections;
using OneWeekAtPan.Systems;

namespace OneWeekAtPan.AI
{
	public class OwlAI : MonoBehaviour
	{
		[Header("Variables:")]
		public static int OWL_AI_LEVEL;
		public int currentCamera = 0;
		public float timeBetwenMovement;
		public static float MIN_TIME_BETWEN_MOVEMENT;
		public static float MAX_TIME_BETWEN_MOVEMENT;
		public static bool IS_OWL_IN_OFFICE;

		[Header("Components:")]
		[SerializeField] private RawImage cameraStatic;
		[Space]
		[SerializeField] private AudioClip[] owlAudioClip; // AudioClips: staticSFX, ventFootstepSFX
		private Main main;
		private HeatSystem heatSystem;
		private CameraSystem cameraSys;
		private MainCamera mainCamera;
		private AudioSource owlAudioSource;

		[Header("GameObjects:")]
		[SerializeField] private GameObject owlObject;
		[SerializeField] private GameObject mainCameraObject;
		[SerializeField] private GameObject mainCanvasObject;
		[Space]
		[SerializeField] private GameObject[] animatronics;
		[SerializeField] private GameObject[] roomLights;

		void Start()
		{
			main = mainCanvasObject.GetComponent<Main>();
			cameraSys = mainCanvasObject.GetComponent<CameraSystem>();
			heatSystem = mainCanvasObject.GetComponent<HeatSystem>();
			mainCamera = mainCameraObject.GetComponent<MainCamera>();
			owlAudioSource = owlObject.GetComponent<AudioSource>();

			AIlevel.OwlMovingTime();
			timeBetwenMovement = Random.Range(MIN_TIME_BETWEN_MOVEMENT, MAX_TIME_BETWEN_MOVEMENT);
		}

		void Update()
		{
			timeBetwenMovement -= Time.deltaTime;

			if (timeBetwenMovement < 0)
			{
				timeBetwenMovement = 0;
			}

			// Play Room >> Play Room phaze01
			if (timeBetwenMovement <= 0 && currentCamera == 0)
			{
				if (cameraSys.cameraNumber == 9)
				{
					cameraStatic.CrossFadeAlpha(100, 0.1f, false);

					if (cameraSys.isCameraActive)
					{
						owlAudioSource.clip = owlAudioClip[0];
						owlAudioSource.Play();
					}
				}

				animatronics[0].SetActive(false);
				animatronics[1].SetActive(true);
				currentCamera++;

				AIlevel.OwlMovingTime();
				timeBetwenMovement = Random.Range(MIN_TIME_BETWEN_MOVEMENT, MAX_TIME_BETWEN_MOVEMENT);

				Invoke(nameof(StaticEffectToNormalOppacity), 0.5f);
			}

			// Play Room phaze10 >> Hallway01
			if (timeBetwenMovement <= 0 && currentCamera == 1)
			{
				if (cameraSys.cameraNumber == 9 || cameraSys.cameraNumber == 3)
				{
					cameraStatic.CrossFadeAlpha(100, 0.1f, false);

					if (cameraSys.isCameraActive)
					{
						owlAudioSource.clip = owlAudioClip[0];
						owlAudioSource.Play();
					}
				}

				animatronics[1].SetActive(false);
				animatronics[2].SetActive(true);
				currentCamera++;

				AIlevel.OwlMovingTime();
				timeBetwenMovement = Random.Range(MIN_TIME_BETWEN_MOVEMENT, MAX_TIME_BETWEN_MOVEMENT);

				Invoke(nameof(StaticEffectToNormalOppacity), 0.5f);
			}

			// Hallway01 >> Dining Room || Hallway02
			if (timeBetwenMovement <= 0 && currentCamera == 2)
			{
				if (cameraSys.cameraNumber == 3 || cameraSys.cameraNumber == 7 || cameraSys.cameraNumber == 2)
				{
					cameraStatic.CrossFadeAlpha(100, 0.1f, false);

					if (cameraSys.isCameraActive)
					{
						owlAudioSource.clip = owlAudioClip[0];
						owlAudioSource.Play();
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

				AIlevel.OwlMovingTime();
				timeBetwenMovement = Random.Range(MIN_TIME_BETWEN_MOVEMENT, MAX_TIME_BETWEN_MOVEMENT);
				Invoke(nameof(StaticEffectToNormalOppacity), 0.5f);
			}

			// Dining Room >> Hallway01
			if (timeBetwenMovement <= 0 && currentCamera == 3)
			{
				if (cameraSys.cameraNumber == 7 || cameraSys.cameraNumber == 3)
				{
					cameraStatic.CrossFadeAlpha(100, 0.1f, false);

					if (cameraSys.isCameraActive)
					{
						owlAudioSource.clip = owlAudioClip[0];
						owlAudioSource.Play();
					}
				}

				animatronics[3].SetActive(false);
				animatronics[2].SetActive(true);
				currentCamera = 2;

				AIlevel.OwlMovingTime();
				timeBetwenMovement = Random.Range(MIN_TIME_BETWEN_MOVEMENT, MAX_TIME_BETWEN_MOVEMENT);

				Invoke(nameof(StaticEffectToNormalOppacity), 0.5f);
			}

			// Hallway01 >> Hallway02
			if (timeBetwenMovement <= 0 && (currentCamera == 2 || currentCamera == 3))
			{
				if (cameraSys.cameraNumber == 2 || cameraSys.cameraNumber == 3)
				{
					cameraStatic.CrossFadeAlpha(100, 0.1f, false);

					if (cameraSys.isCameraActive)
					{
						owlAudioSource.clip = owlAudioClip[0];
						owlAudioSource.Play();
					}
				}

				animatronics[2].SetActive(false);
				animatronics[4].SetActive(true);
				currentCamera++;

				AIlevel.OwlMovingTime();
				timeBetwenMovement = Random.Range(MIN_TIME_BETWEN_MOVEMENT, MAX_TIME_BETWEN_MOVEMENT);

				Invoke(nameof(StaticEffectToNormalOppacity), 0.5f);
			}

			// Hallway02 >> Bed Room
			if (timeBetwenMovement <= 0 && currentCamera == 4)
			{
				if (cameraSys.cameraNumber == 2 || cameraSys.cameraNumber == 4)
				{
					cameraStatic.CrossFadeAlpha(100, 0.1f, false);

					if (cameraSys.isCameraActive)
					{
						owlAudioSource.clip = owlAudioClip[0];
						owlAudioSource.Play();
					}
				}

				animatronics[4].SetActive(false);
				animatronics[5].SetActive(true);
				currentCamera++;

				AIlevel.OwlMovingTime();
				timeBetwenMovement = Random.Range(MIN_TIME_BETWEN_MOVEMENT, MAX_TIME_BETWEN_MOVEMENT);

				Invoke(nameof(StaticEffectToNormalOppacity), 0.5f);
			}

			// Bed Room >> Vent
			if (timeBetwenMovement <= 0 && currentCamera == 5)
			{
				if (cameraSys.cameraNumber == 4)
				{
					cameraStatic.CrossFadeAlpha(100, 0.1f, false);

					if (cameraSys.isCameraActive)
					{
						owlAudioSource.clip = owlAudioClip[0];
						owlAudioSource.Play();
					}
				}

				animatronics[5].SetActive(false);
				animatronics[6].SetActive(true);
				currentCamera++;

				timeBetwenMovement = Random.Range(3, 5);

				StartCoroutine(FlashLightsFast());
				Invoke(nameof(StaticEffectToNormalOppacity), 0.5f);
			}

			// Vent >> Dining Room
			if (timeBetwenMovement <= 0 && mainCamera.crouchTime <= 0 && mainCamera.isCrouching && currentCamera == 6)
			{
				animatronics[6].SetActive(false);
				animatronics[3].SetActive(true);

				owlAudioSource.clip = owlAudioClip[1];
				owlAudioSource.Play();

				currentCamera = 3;

				AIlevel.OwlMovingTime();
				timeBetwenMovement = Random.Range(MIN_TIME_BETWEN_MOVEMENT, MAX_TIME_BETWEN_MOVEMENT);
			}

			// Vent >> Office
			if (timeBetwenMovement <= 0 && currentCamera == 6 && !mainCamera.isCrouching && !Main.IS_JUMPSCARE)
			{
				cameraStatic.CrossFadeAlpha(100, 0.1f, false);

				cameraSys.cameraButtonOn.SetActive(false);
				cameraSys.cameraButtonOff.SetActive(false);

				if (cameraSys.isCameraActive)
				{
					cameraSys.DeactivateCamSys();
				}

				IS_OWL_IN_OFFICE = true;

				animatronics[6].SetActive(false);
				animatronics[7].SetActive(true);

				timeBetwenMovement = 10000f;
				StartCoroutine(nameof(FlashLightsFast));

				Invoke(nameof(StaticEffectToNormalOppacity), 0.5f);
			}
		}

		private void StaticEffectToNormalOppacity()
		{
			cameraStatic.CrossFadeAlpha(1, 0.1f, false);
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