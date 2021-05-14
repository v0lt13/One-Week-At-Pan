using UnityEngine;
using OneWeekAtPan.Core;
using UnityEngine.SceneManagement;

namespace OneWeekAtPan
{
	public class SwitchToNextNight : MonoBehaviour
	{
		[SerializeField] private float sceneSwitchTime;

		void Awake()
		{
			Main.NIGHT++;

			if (Main.NIGHT >= 8)
			{
				Main.NIGHT = 8;
			}

			PlayerPrefs.SetInt("Night", Main.NIGHT);
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

				case 7:
					SceneManager.LoadScene("Night07S");
					break;

				default:
					SceneManager.LoadScene("Ending");
					break;
			}
		}
	}
}