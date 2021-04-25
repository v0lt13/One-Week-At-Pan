using UnityEngine;
using UnityEngine.UI;

public class Night2 : MonoBehaviour
{
    [HideInInspector] public bool isOvenOn = true;
    private int heKnowsHowUseLights = 0;
    private bool isHoveredOverChargeButton = false;

    [Header ("Components:")]
    public Slider heatSlider;
    [Space]
    [SerializeField] private Gradient heatBarGradient;
    [SerializeField] private Image heatBarImage;
    private CameraSystem cameraSys;

    [Header ("GameObjects;")]
    public GameObject lightControls;
    [SerializeField] private GameObject workingOvens;
    [SerializeField] private GameObject ovens;
    [Space]
    [SerializeField] private GameObject[] cameraLights;
    [SerializeField] private GameObject[] ovenLights;
    [SerializeField] private GameObject[] heatObjects;

	void Start()
	{
        cameraSys = gameObject.GetComponent<CameraSystem>();
	}

	void Update()
	{
        ActivateHeatChargers();
        IsChargeButtonPressed();

        heatBarImage.color = heatBarGradient.Evaluate(heatSlider.normalizedValue);

        EnableCameraLight(cameraSys.cameraNumber - 1);;

        if (Input.GetKeyDown(KeyCode.X))
        {
            lightControls.SetActive(false);
            heKnowsHowUseLights = 1;

            PlayerPrefs.SetInt("heKnowsLights", heKnowsHowUseLights);
        }

        if (heatSlider.value <= 0)
        {
            foreach (var ovenLight in ovenLights)
            {
                ovenLight.SetActive(false);
            }

            isOvenOn = false;

            ovens.SetActive(true);
            workingOvens.SetActive(false);
        }
        else if (heatSlider.value > 0)
        {
            foreach (var ovenLight in ovenLights)
            {
                ovenLight.SetActive(true);
            }

            isOvenOn = true;

            ovens.SetActive(false);
            workingOvens.SetActive(true);
        }
    }

    void FixedUpdate()
    {
        if (!IsChargeButtonPressed())
        {
            DecreaseHeatSliderValue();
        }
        else if (IsChargeButtonPressed())
        {
            IncreaseHeatSliderValue();
        }
    }

    public void OnPointerEnterChargeValue()
    {
        isHoveredOverChargeButton = true;
    }

    public void OnPointerExitChargeValue()
    {
        isHoveredOverChargeButton = false;
    }

    private void EnableCameraLight(int camera)
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && cameraSys.isCameraActive)
        {
            cameraLights[camera].SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift) && cameraSys.isCameraActive)
        {
            cameraLights[camera].SetActive(false);
        }

        if (!cameraSys.isCameraActive)
        {
            cameraLights[camera].SetActive(false);
        }
    }

    private void ActivateHeatChargers()
    {
        if (cameraSys.cameraNumber == 6 && cameraSys.isCameraActive)
        {
            foreach (var heatObject in heatObjects)
            {
                heatObject.SetActive(true);
            }
        }
        else
        {
            foreach (var heatObject in heatObjects)
            {
                heatObject.SetActive(false);
            }
        }
    }

    private void DecreaseHeatSliderValue()
    {
        heatSlider.value -= Time.deltaTime * 3;
    }

    private void IncreaseHeatSliderValue()
    {
        heatSlider.value += Time.deltaTime * 7;
    }

    public void DisableCameraLight()
    {
        foreach (var light in cameraLights)
        {
            light.SetActive(false);
        }
    }

    private bool IsChargeButtonPressed()
    {
        if (Input.GetKey(KeyCode.Mouse0) && isHoveredOverChargeButton)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
