using OneWeekAtPan.Core;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace OneWeekAtPan
{
	public class PauseMenu : MonoBehaviour
	{
		[HideInInspector] public static bool IS_PAUSED = false;

		private MainCamera mainCamera;

		[SerializeField] private GameObject pauseMenuObject;
		private GameObject mainCameraObject;

		void Start()
		{
			mainCameraObject = GameObject.Find("Main Camera");

			mainCamera = mainCameraObject.GetComponent<MainCamera>();
		}

		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Escape) && !Main.IS_JUMPSCARE)
			{
				if (IS_PAUSED)
				{
					Resume();
				}
				else
				{
					Pause();
				}
			}
		}

		private void Pause()
		{
			pauseMenuObject.SetActive(true);

			IS_PAUSED = true;
			Time.timeScale = 0;
		}

		public void Resume()
		{
			pauseMenuObject.SetActive(false);

			if (!MainCamera.IS_MOUSE_CONTROLS)
			{
				if (mainCamera.cameraAnimator.GetBool("isLeft"))
				{
					mainCamera.CenterFromLeft();
				}
				else if (mainCamera.cameraAnimator.GetBool("isRight"))
				{
					mainCamera.CenterFromRight();
				}
			}

			IS_PAUSED = false;
			Time.timeScale = 1;
		}

		public void Exit()
		{
			SceneManager.LoadScene("MainMenu");
			IS_PAUSED = false;
			Time.timeScale = 1;
		}
	}
}