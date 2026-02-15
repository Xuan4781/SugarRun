using UnityEngine;
using UnityEngine.AI;

namespace SugarRun
{
	public class GuardUI : MonoBehaviour
	{

		public Transform pointA;
		public Transform pointB;

		private NavMeshAgent agent;
		private bool goingToB = true;
		// Start is called once before the first execution of Update after the MonoBehaviour is created
		void Start()
		{
			agent = GetComponent<NavMeshAgent>();
			agent.SetDestination(pointA.position);
		}

		// Update is called once per frame
		void Update()
		{
			if (agent.remainingDistance < 0.2f)
			{
				if (goingToB)
				{
					agent.SetDestination(pointB.position);
				}
				else
				{
					agent.SetDestination(pointA.position);
				}
				goingToB = !goingToB;
			}
		}
	}
}

