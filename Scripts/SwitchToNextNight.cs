using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchToNextNight : MonoBehaviour
{
    [Header("Variables:")]
    [SerializeField] private float sceneSwitchTime;

	void Awake()
	{
		Main.night++;

		if (Main.night > 4)
		{
			Main.night = 4;
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

			default:
				SceneManager.LoadScene("ComingSoonScreen");
				break;
		}
	}
}
