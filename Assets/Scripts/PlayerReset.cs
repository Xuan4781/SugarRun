using UnityEngine;
using TMPro;

namespace SugarRun
{
	public class PlayerReset : MonoBehaviour
	{
		public TextMeshProUGUI messageText;
		
		private Vector3 startPosition;
		// Start is called once before the first execution of Update after the MonoBehaviour is created
		void Start()
		{
			startPosition = transform.position;
		}

		private void OnTriggerEnter(Collider other)
		{
			if (other.gameObject.name == "Guard")
			{
				
				transform.position = startPosition;
				messageText.text = "Caught!";
			}

		}

		// Update is called once per frame
		void Update()
		{

		}
	}
}



