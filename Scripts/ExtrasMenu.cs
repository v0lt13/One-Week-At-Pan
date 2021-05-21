using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace OneWeekAtPan
{
    public class ExtrasMenu : MonoBehaviour
    {
		private int currentAnimatronic;
		private int currentOther;

		[Header ("Components:")]
		[SerializeField] private Text animatronicName;
		[SerializeField] private Text otherLabel;
        private AudioSource audioSource;

		[Header ("GameObjects:")]
		[SerializeField] private GameObject animatronicsExtras;
		[SerializeField] private GameObject jumpscaresExtras;
		[SerializeField] private GameObject creditsExtras;
		[SerializeField] private GameObject otherExtras;
		[Space]
		[SerializeField] private GameObject[] animatronics;
		[SerializeField] private GameObject[] otherStuff;

		void Start()
		{
			audioSource = GetComponent<AudioSource>();	
		}

		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				GoToMainMenu();
			}

			if (currentOther >= 3)
			{
				otherLabel.text = "Starting the project";
			}
			else
			{
				otherLabel.text = "Original idea";
			}

			switch (currentAnimatronic)
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
					animatronicName.text = "Owl";
					break;

				case 4:
					animatronicName.text = "Eyedemon";
					break;
			}
		}

		public void GoToMainMenu()
		{
            SceneManager.LoadScene("MainMenu");
		}

		// Main buttons
		public void Animatronics()
		{
			audioSource.Play();

			DisableAllExtras();
			animatronicsExtras.SetActive(true);
		}

		public void Jumpscares()
		{
			audioSource.Play();

			DisableAllExtras();
			jumpscaresExtras.SetActive(true);
		}

		public void Credits()
		{
			audioSource.Play();

			DisableAllExtras();
			creditsExtras.SetActive(true);
		}

		public void Other()
		{
			audioSource.Play();

			DisableAllExtras();
			otherExtras.SetActive(true);
		}

		// Side buttons
		public void GoToJumpscares()
		{
			SceneManager.LoadScene(24);
		}

		public void NextAnimatronic()
		{
			audioSource.Play();

			if (currentAnimatronic != 4)
			{
				currentAnimatronic++;
			}
			else
			{
				currentAnimatronic = 0;
			}

			ToogleObjects(animatronics, currentAnimatronic);
		}

		public void PreviousAnimatronic()
		{
			audioSource.Play();

			if (currentAnimatronic != 0)
			{
				currentAnimatronic--;
			}
			else
			{
				currentAnimatronic = 4;
			}

			ToogleObjects(animatronics, currentAnimatronic);
		}

		public void NextOther()
		{
			audioSource.Play();

			if (currentOther != 5)
			{
				currentOther++;
			}
			else
			{
				currentOther = 0;
			}

			ToogleObjects(otherStuff, currentOther);
		}

		public void PrevOther()
		{
			audioSource.Play();

			if (currentOther != 0)
			{
				currentOther--;
			}
			else
			{
				currentOther = 5;
			}

			ToogleObjects(otherStuff, currentOther);
		}

		private void ToogleObjects(GameObject[] objects, int objectNumber)
		{
			foreach (var @object in objects)
			{
				@object.SetActive(false);
			}

			objects[objectNumber].SetActive(true);
		}

		private void DisableAllExtras()
		{
			animatronicsExtras.SetActive(false);
			jumpscaresExtras.SetActive(false);
			creditsExtras.SetActive(false);
			otherExtras.SetActive(false);
		}
    }
}
