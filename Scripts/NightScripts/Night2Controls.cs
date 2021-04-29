using UnityEngine;

public class Night2Controls : MonoBehaviour
{
    private int heKnowsHowUseLights = 0;

    public GameObject lightControls;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            lightControls.SetActive(false);
            heKnowsHowUseLights = 1;

            PlayerPrefs.SetInt("heKnowsLights", heKnowsHowUseLights);
        }
    }
}
