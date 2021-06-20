using UnityEngine;
using OneWeekAtPan.AI;
using OneWeekAtPan.Systems;

namespace OneWeekAtPan.Core
{
	public class MainCamera : MonoBehaviour
	{
		[Header("Variables:")]
		public float crouchTime;
		public bool isCrouching = false;
		public static bool IS_MOUSE_CONTROLS;

		[Header("Components:")]
		[HideInInspector] public Animator cameraAnimator;
		[SerializeField] private AudioClip[] cameraAudioClip;
		private CameraSystem cameraSys;
		private AudioSource cameraAudioSource;

		[Header("GameObjects:")]
		[SerializeField] private GameObject playerCamera;
		[SerializeField] private GameObject cameraSystem;

		void Start()
		{
			cameraAudioSource = playerCamera.GetComponent<AudioSource>();
			cameraSys = cameraSystem.GetComponent<CameraSystem>();
			cameraAnimator = playerCamera.GetComponent<Animator>();

			crouchTime = Random.Range(3, 5);
		}

		void Update()
		{
			if (crouchTime < 0)
			{
				crouchTime = 0;
			}

			if (isCrouching)
			{
				crouchTime -= Time.deltaTime;

				if (IS_MOUSE_CONTROLS)
				{
					foreach (var trigger in cameraSys.lookTriggers)
					{
						trigger.SetActive(false);
					}
				}
			}
			else
			{
				if (IS_MOUSE_CONTROLS)
				{
					foreach (var trigger in cameraSys.lookTriggers)
					{
						trigger.SetActive(true);
					}
				}
			}

			if (Input.GetKeyDown(KeyCode.A) && cameraSys.isCameraActive == false && !cameraAnimator.GetBool("isLeft") && !cameraAnimator.GetBool("isRight") && !cameraAnimator.GetBool("isHideing") && !Main.IS_JUMPSCARE && !PauseMenu.IS_PAUSED && !IS_MOUSE_CONTROLS)
			{
				LookLeft();
			}

			if (Input.GetKeyDown(KeyCode.D) && cameraSys.isCameraActive == false && !cameraAnimator.GetBool("isLeft") && !cameraAnimator.GetBool("isRight") && !cameraAnimator.GetBool("isHideing") && !Main.IS_JUMPSCARE && !PauseMenu.IS_PAUSED && !IS_MOUSE_CONTROLS)
			{
				LookRight();
			}

			if (Input.GetKeyUp(KeyCode.A) && cameraSys.isCameraActive == false && cameraAnimator.GetBool("isLeft") && !cameraAnimator.GetBool("isRight") && !cameraAnimator.GetBool("isHideing") && !Main.IS_JUMPSCARE && !PauseMenu.IS_PAUSED && !IS_MOUSE_CONTROLS)
			{
				CenterFromLeft();
			}

			if (Input.GetKeyUp(KeyCode.D) && cameraSys.isCameraActive == false && !cameraAnimator.GetBool("isLeft") && cameraAnimator.GetBool("isRight") && !cameraAnimator.GetBool("isHideing") && !Main.IS_JUMPSCARE && !PauseMenu.IS_PAUSED && !IS_MOUSE_CONTROLS)
			{
				CenterFromRight();
			}

			if (Input.GetKey(KeyCode.LeftControl) && cameraSys.isCameraActive == false && !cameraAnimator.GetBool("isLeft") && !cameraAnimator.GetBool("isRight") && !cameraAnimator.GetBool("isHideing") && !Main.IS_JUMPSCARE && !PauseMenu.IS_PAUSED)
			{
				Crouch();
			}

			if (Input.GetKeyUp(KeyCode.LeftControl) && cameraSys.isCameraActive == false && !cameraAnimator.GetBool("isLeft") && !cameraAnimator.GetBool("isRight") && !Main.IS_JUMPSCARE && !PauseMenu.IS_PAUSED)
			{
				Uncrouch();
			}
		}

		public void LookLeft()
		{
			cameraAnimator.SetBool("isLeft", true);
			cameraSys.cameraButtonOn.SetActive(false);
		}

		public void CenterFromLeft()
		{
			cameraAnimator.SetBool("isLeft", false);

			if (!OwlAI.IS_OWL_IN_OFFICE && !Main.IS_JUMPSCARE && !isCrouching)
			{
				cameraSys.cameraButtonOn.SetActive(true);
			}
		}

		public void LookRight()
		{
			cameraAnimator.SetBool("isRight", true);
			cameraSys.cameraButtonOn.SetActive(false);
		}

		public void CenterFromRight()
		{
			cameraAnimator.SetBool("isRight", false);

			if (!OwlAI.IS_OWL_IN_OFFICE && !Main.IS_JUMPSCARE && !isCrouching)
			{
				cameraSys.cameraButtonOn.SetActive(true);
			}
		}

		private void Crouch()
		{
			cameraAnimator.SetBool("isHideing", true);
			cameraSys.cameraButtonOn.SetActive(false);

			isCrouching = true;

			cameraAudioSource.clip = cameraAudioClip[0];
			cameraAudioSource.Play();
		}

		private void Uncrouch()
		{
			cameraAnimator.SetBool("isHideing", false);

			if (!OwlAI.IS_OWL_IN_OFFICE)
			{
				cameraSys.cameraButtonOn.SetActive(true);
			}

			isCrouching = false;

			crouchTime = Random.Range(3, 5);

			cameraAudioSource.clip = cameraAudioClip[1];
			cameraAudioSource.Play();
		}
	}
}