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
	}
}