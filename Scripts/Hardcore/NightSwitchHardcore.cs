using UnityEngine;
using UnityEngine.SceneManagement;

namespace OneWeekAtPan.Hardcore
{
    public class NightSwitchHardcore : MonoBehaviour
    {
		[SerializeField] private float sceneSwitchTime;

		void Awake()
		{
			HardcoreMode.NIGHT++;

			if (HardcoreMode.NIGHT >= 8)
			{
				HardcoreMode.NIGHT = 8;
			}
		}

		void Start()
		{
			Invoke(nameof(GoToNextNight), sceneSwitchTime);
		}

		public void GoToNextNight()
		{
			switch (HardcoreMode.NIGHT)
			{
				case 2:
					SceneManager.LoadScene("Night02S_H");
					break;

				case 3:
					SceneManager.LoadScene("Night03S_H");
					break;

				case 4:
					SceneManager.LoadScene("Night04S_H");
					break;

				case 5:
					SceneManager.LoadScene("Night05S_H");
					break;

				case 6:
					SceneManager.LoadScene("Night06S_H");
					break;

				case 7:
					SceneManager.LoadScene("Night07S_H");
					break;

				default:
					SceneManager.LoadScene("Ending");
					break;
			}
		}
	}
}
