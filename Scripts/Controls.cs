using UnityEngine;
using OneWeekAtPan.Core;
using OneWeekAtPan.Systems;

namespace OneWeekAtPan
{
	public class Controls : MonoBehaviour
	{
		private int heKnowsHowToPlayKeyboard = 0;
		private int heKnowsHowToPlayMouse = 0;

		private CameraSystem cameraSys;

		public GameObject keyboardControls;
		public GameObject mouseControls;
		[SerializeField] private GameObject mainCanvas;

		void Start()
		{
			cameraSys = mainCanvas.GetComponent<CameraSystem>();

			if (MainCamera.isMouseControls)
			{
				foreach (var triggers in cameraSys.lookTriggers)
				{
					triggers.SetActive(true);
				}

				if (PlayerPrefs.GetInt("heKnowsMouse") == 0)
				{
					mouseControls.SetActive(true);
				}
			}
			else
			{
				foreach (var triggers in cameraSys.lookTriggers)
				{
					triggers.SetActive(false);
				}

				if (PlayerPrefs.GetInt("heKnowsKeyboard") == 0)
				{
					keyboardControls.SetActive(true);
				}
			}
		}

		void Update()
		{
			if (Input.GetKeyDown(KeyCode.X))
			{
				if (MainCamera.isMouseControls)
				{
					mouseControls.SetActive(false);

					heKnowsHowToPlayMouse = 1;

					PlayerPrefs.SetInt("heKnowsMouse", heKnowsHowToPlayMouse);
					PlayerPrefs.Save();
				}
				else
				{
					keyboardControls.SetActive(false);

					heKnowsHowToPlayKeyboard = 1;

					PlayerPrefs.SetInt("heKnowsKeyboard", heKnowsHowToPlayKeyboard);
					PlayerPrefs.Save();
				}
			}
		}
	}
}