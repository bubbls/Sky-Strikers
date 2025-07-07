using System.Collections.Generic;
using UnityEngine;

namespace PolygonArsenal
{
	public class PolygonEffectCycler : MonoBehaviour
	{
		[SerializeField]
		private List<GameObject> listOfEffects;

		[SerializeField]
		[Header("Loop length in seconds")]
		private float loopTimeLength;

		private float timeOfLastInstantiate;

		private GameObject instantiatedEffect;

		private int effectIndex;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
