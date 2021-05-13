using UnityEngine;
using UnityEngine.UI;

namespace OneWeekAtPan.Systems
{
	public class HeatSystem : MonoBehaviour
	{
		[Header("Variables:")]
		[HideInInspector] public bool isOvenOn = true;
		[SerializeField] [Range(1f, 10f)] private float heatChargerDecreaseSpeed;
		[SerializeField] [Range(1f, 10f)] private float heatChargerIncreaseSpeed;
		private bool isHoveredOverChargeButton = false;

		[Header("Components:")]
		public Slider heatSlider;
		[Space]
		[SerializeField] private Gradient heatBarGradient;
		[SerializeField] private Image heatBarImage;
		private CameraSystem cameraSys;

		[Header("GameObjects;")]
		[SerializeField] private GameObject workingOvens;
		[SerializeField] private GameObject ovens;
		[Space]
		[SerializeField] private GameObject[] cameraLights;
		[SerializeField] private GameObject[] ovenLights;
		[SerializeField] private GameObject[] heatObjects;

		void Start()
		{
			cameraSys = GetComponent<CameraSystem>();
		}

		void Update()
		{
			ActivateHeatChargers();
			IsChargeButtonPressed();

			heatBarImage.color = heatBarGradient.Evaluate(heatSlider.normalizedValue);

			EnableCameraLight(cameraSys.cameraNumber - 1); ;

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

		public void OnPointerEnterChargeButton()
		{
			isHoveredOverChargeButton = true;
		}

		public void OnPointerExitChargeButton()
		{
			isHoveredOverChargeButton = false;
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
			heatSlider.value -= Time.deltaTime * heatChargerDecreaseSpeed;
		}

		private void IncreaseHeatSliderValue()
		{
			heatSlider.value += Time.deltaTime * heatChargerIncreaseSpeed;
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

		public void DisableCameraLight()
		{
			foreach (var light in cameraLights)
			{
				light.SetActive(false);
			}
		}
	}
}