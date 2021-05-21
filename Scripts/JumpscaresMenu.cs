using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace OneWeekAtPan
{
    public class JumpscaresMenu : MonoBehaviour
    {
		private int currentObject;

		[SerializeField] private Text animatronicName;

		[SerializeField] private GameObject[] animatronics;

		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				SceneManager.LoadScene("ExtrasMenu");
			}

			switch (currentObject)
			{
				case 0:
					animatronicName.text = "Pan";
					break;

				case 1:
					animatronicName.text = "Mikey";
					break;

				case 2:
					animatronicName.text = "Travis";
					break;

				case 3:
					animatronicName.text = "Eyedemon";
					break;
			}
		}

		public void NextJumpscare()
		{
			if (currentObject != 3)
			{
				currentObject++;
			}
			else
			{
				currentObject = 0;
			}

			ToogleObjects(animatronics, currentObject);
		}

		public void PreviousJumpscare()
		{
			if (currentObject != 0)
			{
				currentObject--;
			}
			else
			{
				currentObject = 3;
			}

			ToogleObjects(animatronics, currentObject);
		}

		private void ToogleObjects(GameObject[] objects, int objectNumber)
		{
			foreach (var @object in objects)
			{
				@object.SetActive(false);
			}

			objects[objectNumber].SetActive(true);
		}
	}
}
