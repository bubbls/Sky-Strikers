using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Fusion;
using Fusion.Sockets;
using UnityEngine;
using UnityEngine.Serialization;

[AddComponentMenu("Fusion/Prototyping/Network Debug Start")]
[DisallowMultipleComponent]
[ScriptHelp(BackColor = EditorHeaderBackColor.Steel)]
public class NetworkDebugStart : Fusion.Behaviour
{
	public enum StartModes
	{
		UserInterface = 0,
		Automatic = 1,
		Manual = 2
	}

	public enum Stage
	{
		Disconnected = 0,
		StartingUp = 1,
		UnloadOriginalScene = 2,
		ConnectingServer = 3,
		ConnectingClients = 4,
		AllConnected = 5
	}

	[CompilerGenerated]
	private sealed class _003CStartClients_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NetworkDebugStart _003C_003E4__this;

		public GameMode serverMode;

		public SceneRef sceneRef;

		public int clientCount;

		private List<Task> _003CclientTasks_003E5__2;

		private Task _003CclientsStartTask_003E5__3;

		private int _003Ci_003E5__4;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CStartClients_003Ed__58(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CStartWithClients_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NetworkDebugStart _003C_003E4__this;

		public GameMode serverMode;

		public int clientCount;

		public SceneRef sceneRef;

		private bool _003CincludesServerStart_003E5__2;

		private Task _003CserverTask_003E5__3;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CStartWithClients_003Ed__54(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[InlineHelp]
	[WarnIf("RunnerPrefab", false, "No RunnerPrefab supplied. Will search for a NetworkRunner in the scene at startup.")]
	[MultiPropertyDrawersFix]
	public NetworkRunner RunnerPrefab;

	[InlineHelp]
	[MultiPropertyDrawersFix]
	[WarnIf("StartMode", 2.0, "Start network by calling the methods StartHost(), StartServer(), StartClient(), StartHostPlusClients(), or StartServerPlusClients()", MsgType = 1)]
	public StartModes StartMode;

	[InlineHelp]
	[FormerlySerializedAs("Server")]
	[DrawIf("StartMode", 1.0, Hide = true)]
	public GameMode AutoStartAs;

	[InlineHelp]
	[DrawIf("StartMode", 0.0, Hide = true)]
	public bool AutoHideGUI;

	[DrawIf("ShowAutoClients", Hide = true)]
	[InlineHelp]
	public int AutoClients;

	[InlineHelp]
	public ushort ServerPort;

	[InlineHelp]
	public string DefaultRoomName;

	[InlineHelp]
	public bool AlwaysShowStats;

	[NonSerialized]
	private NetworkRunner _server;

	[ScenePath]
	[InlineHelp]
	[MultiPropertyDrawersFix]
	public string InitialScenePath;

	private static string _initialScenePath;

	[InlineHelp]
	[EditorDisabled(false)]
	[MultiPropertyDrawersFix]
	[SerializeField]
	protected Stage _currentStage;

	public Stage CurrentStage
	{
		get
		{
			return default(Stage);
		}
		internal set
		{
		}
	}

	public int LastCreatedClientIndex { get; internal set; }

	public GameMode CurrentServerMode { get; internal set; }

	protected bool CanAddClients => false;

	protected bool CanAddSharedClients => false;

	protected bool IsShutdown => false;

	protected bool IsShutdownAndMultiPeer => false;

	protected bool UsingMultiPeerMode => false;

	protected bool ShowAutoClients => false;

	protected virtual void Start()
	{
	}

	protected bool TryGetSceneRef(out SceneRef sceneRef)
	{
		sceneRef = default(SceneRef);
		return false;
	}

	[BehaviourButtonAction("StartSinglePlayer", true, false, "IsShutdown")]
	public virtual void StartSinglePlayer()
	{
	}

	[BehaviourButtonAction("StartServer", true, false, "IsShutdown")]
	public virtual void StartServer()
	{
	}

	[BehaviourButtonAction("StartHost", true, false, "IsShutdown")]
	public virtual void StartHost()
	{
	}

	[BehaviourButtonAction("Start Client", true, false, "IsShutdown")]
	public virtual void StartClient()
	{
	}

	[BehaviourButtonAction("Start Shared Client", true, false, "IsShutdown")]
	public virtual void StartSharedClient()
	{
	}

	[BehaviourButtonAction("Start Auto Host Or Client", true, false, "IsShutdown")]
	public virtual void StartAutoClient()
	{
	}

	[BehaviourButtonAction("Start Server Plus Clients", true, false, "IsShutdownAndMultiPeer")]
	public virtual void StartServerPlusClients()
	{
	}

	[BehaviourButtonAction("Start Host Plus Clients", true, false, "IsShutdownAndMultiPeer")]
	public void StartHostPlusClients()
	{
	}

	[BehaviourButtonAction("Shutdown", true, false, "CurrentStage")]
	public void Shutdown()
	{
	}

	public virtual void StartServerPlusClients(int clientCount)
	{
	}

	public void StartHostPlusClients(int clientCount)
	{
	}

	public void StartMultipleClients(int clientCount)
	{
	}

	public void StartMultipleSharedClients(int clientCount)
	{
	}

	public void StartMultipleAutoClients(int clientCount)
	{
	}

	public void ShutdownAll()
	{
	}

	[IteratorStateMachine(typeof(_003CStartWithClients_003Ed__54))]
	protected IEnumerator StartWithClients(GameMode serverMode, SceneRef sceneRef, int clientCount)
	{
		return null;
	}

	[BehaviourButtonAction("Add Additional Client", null, "CanAddClients")]
	public void AddClient()
	{
	}

	[BehaviourButtonAction("Add Additional Shared Client", null, "CanAddSharedClients")]
	public void AddSharedClient()
	{
	}

	public Task AddClient(GameMode serverMode, SceneRef sceneRef)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CStartClients_003Ed__58))]
	protected IEnumerator StartClients(int clientCount, GameMode serverMode, SceneRef sceneRef = default(SceneRef))
	{
		return null;
	}

	protected virtual Task InitializeNetworkRunner(NetworkRunner runner, GameMode gameMode, NetAddress address, SceneRef scene, Action<NetworkRunner> initialized)
	{
		return null;
	}
}
