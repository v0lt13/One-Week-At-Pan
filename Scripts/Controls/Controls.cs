using UnityEngine;
using OneWeekAtPan.Core;

namespace OneWeekAtPan.GameControls
{
	public class Controls : MonoBehaviour
	{
		private int heKnowsHowToPlayKeyboard = 0;
		private int heKnowsHowToPlayMouse = 0;

		public GameObject keyboardControls;
		public GameObject mouseControls;

		void Start()
		{
			if (MainCamera.IS_MOUSE_CONTROLS)
			{
				if (PlayerPrefs.GetInt("heKnowsMouse") == 0)
				{
					mouseControls.SetActive(true);
				}
			}
			else
			{
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
				if (MainCamera.IS_MOUSE_CONTROLS)
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