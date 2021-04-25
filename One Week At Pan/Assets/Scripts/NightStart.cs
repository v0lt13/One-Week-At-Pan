using UnityEngine;

public class NightStart : MonoBehaviour
{
    [SerializeField] private GameObject[] canvasTextObjects;

	void Update()
	{
		Invoke(nameof(EnableLoadingText), 1.8f);
	}

	private void EnableLoadingText()
	{
		canvasTextObjects[0].SetActive(false);
		canvasTextObjects[1].SetActive(true);
	}
}
