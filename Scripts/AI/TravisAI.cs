using UnityEngine;
using UnityEngine.UI;
using OneWeekAtPan.Core;
using System.Collections;
using OneWeekAtPan.Systems;
using UnityEngine.SceneManagement;

namespace OneWeekAtPan.AI
{
	public class TravisAI : MonoBehaviour
	{
		[Header("Variables:")]
		public static int TRAVIS_AI_LEVEL;
		public int currentCamera = 0;
		public float timeBetwenMovement;
		public static float MIN_TIME_BETWEN_MOVEMENT;
		public static float MAX_TIME_BETWEN_MOVEMENT;

		[Header("Components:")]
		[SerializeField] private RawImage cameraStatic;
		[Space]
		[SerializeField] private AudioClip[] travisAudioClip; // AudioClips: jumpScareSFX, lighFlickerSFX, staticSFX
		private Main main;
		private HeatSystem heatSystem;
		private CameraSystem cameraSys;
		private MainCamera mainCamera;
		private AudioSource travisAudioSource;

		[Header("GameObjects:")]
		[SerializeField] private GameObject travisObject;
		[SerializeField] private GameObject mainCameraObject;
		[SerializeField] private GameObject mainCanvasObject;
		[Space]
		[SerializeField] private GameObject[] animatronicList;
		[SerializeField] private GameObject[] animatronics;
		[SerializeField] private GameObject[] roomLights;
		[SerializeField] private GameObject[] roomObjects;

		void Start()
		{
			main = mainCanvasObject.GetComponent<Main>();
			cameraSys = mainCanvasObject.GetComponent<CameraSystem>();
			heatSystem = mainCanvasObject.GetComponent<HeatSystem>();
			mainCamera = mainCameraObject.GetComponent<MainCamera>();
			travisAudioSource = travisObject.GetComponent<AudioSource>();

			AIlevel.TravisMovingTime();
			timeBetwenMovement = Random.Range(MIN_TIME_BETWEN_MOVEMENT, MAX_TIME_BETWEN_MOVEMENT);
		}

		void Update()
		{
			if (!heatSystem.isOvenOn)
			{
				timeBetwenMovement -= Time.deltaTime;
			}

			if (timeBetwenMovement < 0)
			{
				timeBetwenMovement = 0;
			}

			// Kitchen phaze 0 >> Kitchen phaze 1
			if (timeBetwenMovement <= 0 && currentCamera == 0)
			{
				if (cameraSys.cameraNumber == 6)
				{
					cameraStatic.CrossFadeAlpha(100, 0.1f, false);

					if (cameraSys.isCameraActive)
					{
						travisAudioSource.clip = travisAudioClip[2];
						travisAudioSource.Play();
					}
				}

				animatronics[0].SetActive(false);
				animatronics[1].SetActive(true);
				currentCamera++;

				AIlevel.TravisMovingTime();
				timeBetwenMovement = Random.Range(MIN_TIME_BETWEN_MOVEMENT, MAX_TIME_BETWEN_MOVEMENT);

				Invoke(nameof(StaticEffectToNormalOppacity), 0.5f);
			}

			// Kitchen phaze 1 >> Kitchen phaze 2
			if (timeBetwenMovement <= 0 && currentCamera == 1)
			{
				if (cameraSys.cameraNumber == 6 || cameraSys.cameraNumber == 7)
				{
					cameraStatic.CrossFadeAlpha(100, 0.1f, false);

					if (cameraSys.isCameraActive)
					{
						travisAudioSource.clip = travisAudioClip[2];
						travisAudioSource.Play();
					}
				}

				animatronics[1].SetActive(false);
				animatronics[2].SetActive(true);
				currentCamera++;

				AIlevel.TravisMovingTime();
				timeBetwenMovement = Random.Range(MIN_TIME_BETWEN_MOVEMENT, MAX_TIME_BETWEN_MOVEMENT);

				Invoke(nameof(StaticEffectToNormalOppacity), 0.5f);
			}

			// Kitchen phaze 2 >> Office
			if (timeBetwenMovement <= 0 && currentCamera == 2)
			{
				cameraStatic.CrossFadeAlpha(100, 0.1f, false);

				if (cameraSys.isCameraActive)
				{
					cameraSys.DeactivateCamSys();
				}

				cameraSys.cameraButtonOn.SetActive(false);
				cameraSys.cameraButtonOff.SetActive(false);
				mainCamera.cameraAnimator.SetBool("isHideing", false);

				foreach (var animatronic in animatronicList)
				{
					animatronic.SetActive(false);
				}

				Main.IS_JUMPSCARE = true;

				currentCamera++;
				timeBetwenMovement = 100f;
				StartCoroutine(nameof(FlashLights));

				Invoke(nameof(StaticEffectToNormalOppacity), 0.5f);
				Invoke(nameof(JumpScare), 4f);
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
			travisAudioSource.clip = travisAudioClip[0];
			travisAudioSource.Play();

			mainCamera.cameraAnimator.SetBool("isLeft", false);
			mainCamera.cameraAnimator.SetBool("isRight", false);

			foreach (var objects in roomObjects)
			{
				objects.SetActive(false);
			}

			roomLights[1].SetActive(true);

			animatronics[3].SetActive(false);
			animatronics[4].SetActive(true);

			Invoke(nameof(Die), 2f);
		}

		private IEnumerator FlashLights()
		{
			foreach (var light in roomLights)
			{
				light.SetActive(false);
			}

			travisAudioSource.clip = travisAudioClip[1];
			travisAudioSource.Play();

			yield return new WaitForSeconds(0.05f);

			foreach (var light in roomLights)
			{
				light.SetActive(true);
			}

			travisAudioSource.clip = travisAudioClip[1];
			travisAudioSource.Play();

			yield return new WaitForSeconds(0.1f);

			foreach (var light in roomLights)
			{
				light.SetActive(false);
			}

			animatronics[2].SetActive(false);
			animatronics[3].SetActive(true);

			travisAudioSource.clip = travisAudioClip[1];
			travisAudioSource.Play();

			yield return new WaitForSeconds(0.1f);

			foreach (var light in roomLights)
			{
				light.SetActive(true);
			}

			travisAudioSource.clip = travisAudioClip[1];
			travisAudioSource.Play();

			yield return new WaitForSeconds(0.5f);

			foreach (var light in roomLights)
			{
				light.SetActive(false);
			}

			travisAudioSource.clip = travisAudioClip[1];
			travisAudioSource.Play();
		}
	}
}