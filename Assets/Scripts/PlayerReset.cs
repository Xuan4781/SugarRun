using UnityEngine;


namespace SugarRun
{
	public class PlayerReset : MonoBehaviour
	{
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
				Debug.Log("Player Caught! Resetting...");
				transform.position = startPosition;
			}

		}

		// Update is called once per frame
		void Update()
		{

		}
	}
}



