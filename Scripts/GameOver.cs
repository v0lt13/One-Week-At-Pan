using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [Header ("Variables:")]
    [SerializeField] private float sceneSwitchTime;
    [SerializeField] private float timeBetwenTextures;
    [SerializeField] private string sceneName;
    private int tipNumber;
    private int currentTexture;
    private readonly List<string> tips = new List<string> {
        "Press CTRL to hide if you see someone at the door",
        "When you hide listen for footsteps to tell if the animatronic is gone",
        "GIT GUD",
        "Look on cams to see the position of the animatronics",
        "Dont die",
        "Feedback from our studies have indicated that if you utilize your brain it's much easier to play this game"
    };

    [Header ("Compenets:")]
    [SerializeField] private Text tipText;
    [SerializeField] private Texture[] staticEffectTextures;
    private RawImage staticEffect;
    
    [Header ("GameObjects:")]
    [SerializeField] private GameObject staticEffectObject;

    void Start()
    {
        staticEffect = staticEffectObject.GetComponent<RawImage>();

        Invoke(nameof(SwitchToScene), sceneSwitchTime);

		if (Main.night == 2)
		{
            tips.Add("Make sure the ovens stay on else Travis will come after you");
		}

        tipNumber = Random.Range(0, tips.Count);
        tipText.text = $"TIP: {tips[tipNumber]}";
	}

    void Update()
    {
        StaticEffect();
    }

    private void SwitchToScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    private void StaticEffect()
    {
        timeBetwenTextures -= Time.deltaTime;

        if (timeBetwenTextures < 0)
        {
            timeBetwenTextures = 0;
        }

        if (timeBetwenTextures == 0)
        {
            currentTexture++;
            currentTexture %= staticEffectTextures.Length;
            staticEffect.texture = staticEffectTextures[currentTexture];
            timeBetwenTextures = 0.08f;
        }
    }
}
