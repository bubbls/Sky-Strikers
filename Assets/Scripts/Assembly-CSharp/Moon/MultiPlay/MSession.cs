using Fusion;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

namespace Moon.MultiPlay
{
	[NetworkBehaviourWeaved(4)]
	public class MSession : NetworkBehaviourSingleton<MSession>
	{
		[DefaultForProperty("NetworkedScenes", 0, 4)]
		private SceneRef[] _NetworkedScenes;

		private static Changed<MSession> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MSession> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MSession> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Capacity(4)]
		[Networked(OnChanged = "HandleNetworkedScenesChanged")]
		[NetworkedWeaved(0, 4)]
		private NetworkArray<SceneRef> NetworkedScenes => default(NetworkArray<SceneRef>);

		public override void Spawned()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		private void HandleAdditiveSceneLoaded(NetworkSceneManager.SceneSlot sceneSlot)
		{
		}

		private static void RaiseAllAdditiveScenesLoaded()
		{
		}

		public string GetActivatedScene(NetworkSceneManager.SceneSlot sceneSlot)
		{
			return null;
		}

		public void ActivateScene(NetworkSceneManager.SceneSlot sceneSlot, string sceneNameOrPath)
		{
		}

		public void DeactivateScene(NetworkSceneManager.SceneSlot sceneSlot)
		{
		}

		[Preserve]
		private static void HandleNetworkedScenesChanged(Changed<MSession> changed)
		{
		}

		public bool TryGetLoadedScene(string sceneNameOrPath, out Scene scene)
		{
			scene = default(Scene);
			return false;
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}
