using UnityEngine;

namespace OneWeekAtPan
{
	public class ButtonPointer : MonoBehaviour
	{
		public GameObject[] arrows;
		private GameObject audioObject;
		private AudioSource audioSource;

		void Start()
		{
			audioObject = GameObject.Find("Background");
			audioSource = audioObject.GetComponent<AudioSource>();
		}

		// Pointer enters
		public void OnPointerEnterNewGameButton()
		{
			arrows[0].SetActive(true);
			audioSource.Play();
		}

		public void OnPointerEnterContinueButton()
		{
			arrows[3].SetActive(true);
			arrows[4].SetActive(true);
			audioSource.Play();
		}

		public void OnPointerEnterOptionsButton()
		{
			arrows[1].SetActive(true);
			audioSource.Play();
		}

		public void OnPointerEnterBackButton()
		{
			arrows[2].SetActive(true);
			audioSource.Play();
		}

		public void OnPointerEnterExtrasButton()
		{
			arrows[5].SetActive(true);
			audioSource.Play();
		}

		public void OnPointerEnterCustomNightButton()
		{
			arrows[6].SetActive(true);
			audioSource.Play();
		}

		// Pointer exits
		public void OnPointerExitNewGameButton()
		{
			arrows[0].SetActive(false);
		}

		public void OnPointerExitContinueButton()
		{
			arrows[3].SetActive(false);
			arrows[4].SetActive(false);
		}

		public void OnPointerExitOptionsButton()
		{
			arrows[1].SetActive(false);
		}

		public void OnPointerExitBackButton()
		{
			arrows[2].SetActive(false);
		}

		public void OnPointerExitExtrasButton()
		{
			arrows[5].SetActive(false);
		}

		public void OnPointerExitCustomNightButton()
		{
			arrows[6].SetActive(false);
		}
	}
}
