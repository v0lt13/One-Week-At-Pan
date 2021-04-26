using UnityEngine;
using UnityEngine.UI;

public class Framerate : MonoBehaviour
{
    private int frameCounter = 0;
    private float timeCounter = 0.0f;
    private const float REFRESH_TIME = 0.1f;
    [HideInInspector] public static bool showFPS;

    [SerializeField] private Text framerateText;

	void Update()
    {
        if (timeCounter < REFRESH_TIME)
        {
            timeCounter += Time.deltaTime;
            frameCounter++;
        }
        else
        {
            var lastFramerate = frameCounter / timeCounter;
            frameCounter = 0;
            timeCounter = 0.0f;
            framerateText.text = $"FPS: {lastFramerate:n1}";
        }
    }
}
