using UnityEngine;
using TMPro;

namespace SugarRun
{
	public class WinGame : MonoBehaviour
	{
		public TextMeshProUGUI messageText;
		private void OnTriggerEnter(Collider other)
		{
			if (other.gameObject.name == "Player")
			{
				messageText.text = "You Win!";
			}
		}
		// Start is called once before the first execution of Update after the MonoBehaviour is created
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{

		}
	}
}

