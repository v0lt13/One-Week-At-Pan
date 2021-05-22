using UnityEngine;
using UnityEngine.UI;
using OneWeekAtPan.Core;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace OneWeekAtPan
{
	public class GameOver : MonoBehaviour
	{
		[Header("Variables:")]
		[SerializeField] private float sceneSwitchTime;
		[SerializeField] private string sceneName;
		private int tipNumber;
		private readonly List<string> tips = new List<string> {
		"Press CTRL to hide if you see someone at the door",
		"When you hide listen for footsteps to tell if the animatronic is gone",
		"GIT GUD",
		"Look on cams to see the position of the animatronics",
		"Dont die",
		"Feedback from our studies have indicated that if you utilize your brain it's much easier to play this game",
		"If you see a small light flicker in the room that means an animatronic is at the door"
	};

		[Header("Compenets:")]
		[SerializeField] private Text tipText;
		private AudioSource audioSource;

		void Start()
		{
			audioSource = GameObject.Find("BG").GetComponent<AudioSource>();

			Invoke(nameof(SwitchToScene), sceneSwitchTime);

			if (Main.NIGHT == 2)
			{
				tips.Add("Make sure the ovens stay on else Travis will come after you");
			}

			if (Main.NIGHT == 7 && Main.NIGHT_HOUR >= 3)
			{
				tips.Clear();
				tips.Add("DIE");
				tipText.color = Color.red;
			}

			int easterEgg = Random.Range(0 , 30);

			if (easterEgg == 25)
			{
				audioSource.Play();
			}

			tipNumber = Random.Range(0, tips.Count);
			tipText.text = $"TIP: {tips[tipNumber]}";
		}

		private void SwitchToScene()
		{
			SceneManager.LoadScene(sceneName);
		}
	}
}