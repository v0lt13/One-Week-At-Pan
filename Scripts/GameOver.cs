using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [Header ("Variables:")]
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

    [Header ("Compenets:")]
    [SerializeField] private Text tipText;

    void Start()
    {
        Invoke(nameof(SwitchToScene), sceneSwitchTime);

		if (Main.night == 2)
		{
            tips.Add("Make sure the ovens stay on else Travis will come after you");
		}

		if (Main.night == 7)
		{
            tips.Clear();
		}

        tipNumber = Random.Range(0, tips.Count);
        tipText.text = $"TIP: {tips[tipNumber]}";
	}

    private void SwitchToScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
