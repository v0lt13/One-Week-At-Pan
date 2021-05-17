using UnityEngine;
using UnityEngine.UI;
using OneWeekAtPan.AI;
using UnityEngine.SceneManagement;

namespace OneWeekAtPan
{
    public class CustomNightMenu : MonoBehaviour
    {
		private int panLevel;
		private int mikeyLevel;
		private int travisLevel;
		private int owlLevel;

		[Header("Components:")]
		[SerializeField] private Text panLevelText;
		[SerializeField] private Text mikeyLevelText;
		[SerializeField] private Text travisLevelText;
		[SerializeField] private Text owlLevelText;
		private AudioSource audioSource;

		private GameObject mainCamera;

		void Start()
		{
			mainCamera = GameObject.Find("Main Camera");
			audioSource = mainCamera.GetComponent<AudioSource>();
		}

		void Update()
		{
			panLevelText.text = panLevel.ToString();
			mikeyLevelText.text = mikeyLevel.ToString();
			travisLevelText.text = travisLevel.ToString();
			owlLevelText.text = owlLevel.ToString();

			if (Input.GetKeyDown(KeyCode.Escape))
			{
				SceneManager.LoadScene("MainMenu");
			}
		}

		public void GoToMainMenu()
		{
            SceneManager.LoadScene("MainMenu");
		}

		public void StartCustomNight()
		{
			PanAI.PAN_AI_LEVEL = panLevel;
			MikeyAI.MIKEY_AI_LEVEL = mikeyLevel;
			TravisAI.TRAVIS_AI_LEVEL = travisLevel;
			OwlAI.OWL_AI_LEVEL = owlLevel;

			SceneManager.LoadScene("CustomNightS");
		}

		public void SetAllTo20()
		{
			panLevel = 20;
			mikeyLevel = 20;
			travisLevel = 20;
			owlLevel = 20;

			audioSource.Play();
		}

		public void SetAllTo15()
		{
			panLevel = 15;
			mikeyLevel = 15;
			travisLevel = 15;
			owlLevel = 15;

			audioSource.Play();
		}

		public void SetAllTo10()
		{
			panLevel = 10;
			mikeyLevel = 10;
			travisLevel = 10;
			owlLevel = 10;

			audioSource.Play();
		}

		public void SetAllTo5()
		{
			panLevel = 5;
			mikeyLevel = 5;
			travisLevel = 5;
			owlLevel = 5;

			audioSource.Play();
		}

		public void SetAllTo0()
		{
			panLevel = 0;
			mikeyLevel = 0;
			travisLevel = 0;
			owlLevel = 0;

			audioSource.Play();
		}

		// Increases
		public void IncreasePanAILevel()
		{
			if (panLevel != 20)
			{
				panLevel++;
			}

			audioSource.Play();
		}

		public void IncreaseMikeyAILevel()
		{
			if (mikeyLevel != 20)
			{
				mikeyLevel++;
			}

			audioSource.Play();
		}

		public void IncreaseTravisAILevel()
		{
			if (travisLevel != 20)
			{
				travisLevel++;
			}

			audioSource.Play();
		}

		public void IncreaseOwlAILevel()
		{
			if (owlLevel != 20)
			{
				owlLevel++;
			}

			audioSource.Play();
		}

		// Decreases
		public void DecreasePanAILevel()
		{
			if (panLevel != 0)
			{
				panLevel--;
			}

			audioSource.Play();
		}

		public void DecreaseMikeyAILevel()
		{
			if (mikeyLevel != 0)
			{
				mikeyLevel--;
			}

			audioSource.Play();
		}

		public void DecreaseTravisAILevel()
		{
			if (travisLevel != 0)
			{
				travisLevel--;
			}

			audioSource.Play();
		}

		public void DecreaseOwlAILevel()
		{
			if (owlLevel != 0)
			{
				owlLevel--;
			}

			audioSource.Play();
		}
	}
}
