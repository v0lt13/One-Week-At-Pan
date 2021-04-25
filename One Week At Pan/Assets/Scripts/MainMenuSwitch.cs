using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSwitch : MonoBehaviour
{
    [Header ("Variables:")]
    [SerializeField] private float sceneSwitchTime;
    [SerializeField] private string scene;
    [SerializeField] private bool isAsync = false;

    void Start()
    {
        Invoke(nameof(SwitchToScene), sceneSwitchTime);
    }

    private void SwitchToScene()
    {
		if (!isAsync)
		{
            SceneManager.LoadScene(scene);
		}
		else if (isAsync)
		{
            SceneManager.LoadSceneAsync(scene);
        }
    }
}
