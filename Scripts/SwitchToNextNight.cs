using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchToNextNight : MonoBehaviour
{
    [Header("Variables:")]
    [SerializeField] private float sceneSwitchTime;

	void Awake()
	{
		Main.night++;

		if (Main.night > 7)
		{
			Main.night = 7;
		}

		PlayerPrefs.SetInt("Night", Main.night);
		PlayerPrefs.Save();
	}

    void Start()
    {
		Invoke(nameof(GoToNextNight), sceneSwitchTime);
	}

	public void GoToNextNight()
	{
		switch (PlayerPrefs.GetInt("Night"))
		{
			case 2:
				SceneManager.LoadScene("Night02S");
				break;

			case 3:
				SceneManager.LoadScene("Night03S");
				break;

			case 4:
				SceneManager.LoadScene("Night04S");
				break;

			case 5:
				SceneManager.LoadScene("Night05S");
				break;

			case 6:
				SceneManager.LoadScene("Night06S");
				break;

			default:
				SceneManager.LoadScene("ComingSoonScreen");
				break;
		}
	}
}
