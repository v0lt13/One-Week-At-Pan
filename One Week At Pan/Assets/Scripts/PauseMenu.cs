using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	[HideInInspector] public static bool isPaused = false;

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
		if (Input.GetKeyDown(KeyCode.Escape) && !Main.isJumpscare)
		{
			if (isPaused)
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
		// Enables the pause menu
		pauseMenuObject.SetActive(true);

		// We say that the game is paused then we stop the time
		isPaused = true;
		Time.timeScale = 0;
	}

	public void Resume()
	{
		// Disables the pause menu
		pauseMenuObject.SetActive(false);

		// We reset the animation on the keyboard controls
		if (!MainCamera.isMouseControls)
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

		// We say that the game is no longer paused then we set the time scale to normal
		isPaused = false;
		Time.timeScale = 1;
	}

	public void Exit()
	{
		// Exits to the main menu and set the time scale to normal
		SceneManager.LoadScene("MainMenu");
		isPaused = false;
		Time.timeScale = 1;
	}
}
