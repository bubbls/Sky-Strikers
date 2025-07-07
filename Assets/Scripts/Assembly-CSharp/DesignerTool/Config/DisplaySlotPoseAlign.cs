using System.Collections.Generic;
using UnityEngine;

namespace DesignerTool.Config
{
	[ExecuteInEditMode]
	public class DisplaySlotPoseAlign : MonoBehaviour
	{
		[SerializeField]
		private Transform models;

		[SerializeField]
		private Transform poses;

		[SerializeField]
		private DisplaySlotColorMatSwither displaySlotColorMatSwither;

		[SerializeField]
		private Dictionary<Transform, Transform> matchedChildren;

		public void Update()
		{
		}

		public void AlignJoints()
		{
		}

		public void InitPose()
		{
		}
	}
}
