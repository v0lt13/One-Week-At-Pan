using UnityEngine;
using UnityEngine.UI;

namespace OneWeekAtPan
{
	public class StaticEffect : MonoBehaviour
	{
		private int currentTexture;
		private float timeBetwenTextures;

		[SerializeField] private Texture[] staticEffectTextures;
		private RawImage staticEffect;

		private GameObject staticEffectObject;

		void Start()
		{
			staticEffectObject = GameObject.Find("Static");

			staticEffect = staticEffectObject.GetComponent<RawImage>();
		}

		void Update()
		{
			StaticEffectFunc();
		}

		private void StaticEffectFunc()
		{
			timeBetwenTextures -= Time.deltaTime;

			if (timeBetwenTextures < 0)
			{
				timeBetwenTextures = 0;
			}

			if (timeBetwenTextures == 0)
			{
				currentTexture++;
				currentTexture %= staticEffectTextures.Length;
				staticEffect.texture = staticEffectTextures[currentTexture];
				timeBetwenTextures = 0.08f;
			}
		}
	}
}