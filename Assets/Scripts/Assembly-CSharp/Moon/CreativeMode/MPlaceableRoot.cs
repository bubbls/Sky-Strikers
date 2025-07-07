using System;
using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using Fusion;
using Moon.InputSystem;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.CreativeMode
{
	[NetworkBehaviourWeaved(1264)]
	[SimulationBehaviour(Stages = SimulationStages.Forward, Modes = (SimulationModes.Server | SimulationModes.Host))]
	public class MPlaceableRoot : NetworkBehaviour
	{
		[Serializable]
		private class Poses
		{
			public List<string> Keys;

			public List<Pose> Values;
		}

		[DefaultForProperty("PoseData", 0, 1264)]
		private SerializableDictionary<int, Pose> _PoseData;

		private bool _isActive;

		private IMessageSubscriber _subRequestSaveOrLoadPoses;

		private static Changed<MPlaceableRoot> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MPlaceableRoot> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MPlaceableRoot> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[NetworkedWeaved(0, 1264)]
		[Capacity(64)]
		[Networked(OnChanged = "OnMovablePoseChanged")]
		private NetworkDictionary<int, Pose> PoseData => default(NetworkDictionary<int, Pose>);

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		private void NotifyMovablePoseChanged()
		{
		}

		private Pose TransformPose(Pose pose)
		{
			return default(Pose);
		}

		[Preserve]
		private static void OnMovablePoseChanged(Changed<MPlaceableRoot> changed)
		{
		}

		private static string GetPosesFilePath()
		{
			return null;
		}

		[ContextMenu("Moon/Save Placeable Objects")]
		private void Save()
		{
		}

		[ContextMenu("Moon/Load Placeable Objects")]
		private void Load()
		{
		}

		private int HandleRequestSaveOrLoadPoses(IMessage<PlayerInput.RequestSaveOrLoadPlaceableMessage> message)
		{
			return 0;
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}
