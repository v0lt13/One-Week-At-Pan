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
		pauseMenuObject.SetActive(true);

		isPaused = true;
		Time.timeScale = 0;
	}

	public void Resume()
	{
		pauseMenuObject.SetActive(false);

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

		isPaused = false;
		Time.timeScale = 1;
	}

	public void Exit()
	{
		SceneManager.LoadScene("MainMenu");
		isPaused = false;
		Time.timeScale = 1;
	}
}
