using System;
using System.Collections.Generic;
using Fusion;
using Fusion.StatsInternal;
using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
[ScriptHelp(BackColor = EditorHeaderBackColor.Olive)]
public class FusionStats : Fusion.Behaviour
{
	public enum StatCanvasTypes
	{
		Overlay = 0,
		GameObject = 1
	}

	public enum DefaultLayouts
	{
		Custom = 0,
		Left = 1,
		Right = 2,
		UpperLeft = 3,
		UpperRight = 4,
		Full = 5
	}

	private static Dictionary<NetworkRunner, List<FusionStats>> _statsForRunnerLookup;

	private static Dictionary<string, FusionStats> _activeGuids;

	public const Simulation.Statistics.SimStatFlags DefaultSimStatsMask = Simulation.Statistics.SimStatFlags.ForwardSimCount | Simulation.Statistics.SimStatFlags.ResimCount | Simulation.Statistics.SimStatFlags.PacketSize;

	private const int SCREEN_SCALE_W = 1080;

	private const int SCREEN_SCALE_H = 1080;

	private const float TEXT_MARGIN = 0.25f;

	private const float TITLE_HEIGHT = 20f;

	private const int MARGIN = 6;

	private const int PAD = 10;

	private const string PLAY_TEXT = "PLAY";

	private const string PAUS_TEXT = "PAUSE";

	private const string SHOW_TEXT = "SHOW";

	private const string HIDE_TEXT = "HIDE";

	private const string CLER_TEXT = "CLEAR";

	private const string CNVS_TEXT = "CANVAS";

	private const string CLSE_TEXT = "CLOSE";

	private const string PLAY_ICON = "►";

	private const string PAUS_ICON = "װ";

	private const string HIDE_ICON = "▼";

	private const string SHOW_ICON = "▲";

	private const string CLER_ICON = "ᴓ";

	private const string CNVS_ICON = "ﬦ";

	private const string CLSE_ICON = "x";

	[InlineHelp]
	[Unit(Units.Seconds, 1.0, 0.0, DecimalPlaces = 2)]
	[MultiPropertyDrawersFix]
	public float RedrawInterval;

	[Header("Layout")]
	[InlineHelp]
	[SerializeField]
	private StatCanvasTypes _canvasType;

	[SerializeField]
	[InlineHelp]
	private bool _showButtonLabels;

	[InlineHelp]
	[SerializeField]
	[Range(0f, 200f)]
	[MultiPropertyDrawersFix]
	private int _maxHeaderHeight;

	[InlineHelp]
	[DrawIf("_canvasType", 1.0, Hide = true)]
	[Range(0f, 20f)]
	[MultiPropertyDrawersFix]
	public float CanvasScale;

	[Range(-10f, 10f)]
	[MultiPropertyDrawersFix]
	[DrawIf("_canvasType", 1.0, Hide = true)]
	[InlineHelp]
	public float CanvasDistance;

	[InlineHelp]
	[SerializeField]
	[DrawIf("CanvasType", 1.0, Hide = true)]
	[MultiPropertyDrawersFix]
	[NormalizedRect(true, 1f)]
	private Rect _gameObjectRect;

	[DrawIf("CanvasType", 0.0, Hide = true)]
	[NormalizedRect(true, 0f)]
	[MultiPropertyDrawersFix]
	[SerializeField]
	[InlineHelp]
	private Rect _overlayRect;

	[SerializeField]
	[Header("Fusion Graphs Layout")]
	[InlineHelp]
	private FusionGraph.Layouts _defaultLayout;

	[SerializeField]
	[InlineHelp]
	private bool _noTextOverlap;

	[InlineHelp]
	[SerializeField]
	private bool _noGraphShader;

	[InlineHelp]
	[Range(0f, 16f)]
	[MultiPropertyDrawersFix]
	public int GraphColumnCount;

	[MultiPropertyDrawersFix]
	[SerializeField]
	[Range(30f, 1080f)]
	[InlineHelp]
	[DrawIf("GraphColumnCount", 0.0)]
	private int _graphMaxWidth;

	[WarnIf("ShowMissingNetObjWarning", "No NetworkObject found on this GameObject, nor parent. Object stats will be unavailable.")]
	[Header("Network Object Stats")]
	[InlineHelp]
	[SerializeField]
	private bool _enableObjectStats;

	[InlineHelp]
	[SerializeField]
	[DrawIf("EnableObjectStats")]
	private NetworkObject _object;

	[DrawIf("EnableObjectStats")]
	[Range(0f, 200f)]
	[MultiPropertyDrawersFix]
	[InlineHelp]
	[SerializeField]
	private int _objectTitleHeight;

	[MultiPropertyDrawersFix]
	[Range(0f, 200f)]
	[DrawIf("EnableObjectStats")]
	[SerializeField]
	[InlineHelp]
	private int _objectIdsHeight;

	[InlineHelp]
	[SerializeField]
	[DrawIf("EnableObjectStats")]
	[Range(0f, 200f)]
	[MultiPropertyDrawersFix]
	private int _objectMetersHeight;

	[SerializeField]
	[Header("Data")]
	[InlineHelp]
	[EditorDisabled(false)]
	[MultiPropertyDrawersFix]
	private NetworkRunner _runner;

	[InlineHelp]
	public bool InitializeAllGraphs;

	[InlineHelp]
	[VersaMask(false, null)]
	[MultiPropertyDrawersFix]
	public SimulationModes ConnectTo;

	[SerializeField]
	[VersaMask(false, null)]
	[DrawIf("EnableObjectStats")]
	[MultiPropertyDrawersFix]
	[InlineHelp]
	private Simulation.Statistics.ObjStatFlags _includedObjStats;

	[MultiPropertyDrawersFix]
	[VersaMask(false, null)]
	[SerializeField]
	[InlineHelp]
	private Simulation.Statistics.NetStatFlags _includedNetStats;

	[SerializeField]
	[InlineHelp]
	[VersaMask(false, null)]
	[MultiPropertyDrawersFix]
	private Simulation.Statistics.SimStatFlags _includedSimStats;

	[InlineHelp]
	[SerializeField]
	[Header("Life-Cycle")]
	public bool AutoDestroy;

	[InlineHelp]
	[SerializeField]
	public bool EnforceSingle;

	[SerializeField]
	[DrawIf("EnforceSingle")]
	[InlineHelp]
	public string Guid;

	[MultiPropertyDrawersFix]
	[Header("Customization")]
	[InlineHelp]
	[SerializeField]
	[DrawIf("IsNotPlaying", Hide = true)]
	private bool _modifyColors;

	[DrawIf("ShowColorControls", Hide = true)]
	[SerializeField]
	[InlineHelp]
	private Color _graphColorGood;

	[InlineHelp]
	[SerializeField]
	[DrawIf("ShowColorControls", Hide = true)]
	private Color _graphColorWarn;

	[InlineHelp]
	[DrawIf("ShowColorControls", Hide = true)]
	[SerializeField]
	private Color _graphColorBad;

	[InlineHelp]
	[DrawIf("ShowColorControls", Hide = true)]
	[SerializeField]
	private Color _graphColorFlag;

	[DrawIf("ShowColorControls", Hide = true)]
	[InlineHelp]
	[SerializeField]
	private Color _fontColor;

	[SerializeField]
	[DrawIf("ShowColorControls", Hide = true)]
	[InlineHelp]
	private Color PanelColor;

	[InlineHelp]
	[DrawIf("ShowColorControls", Hide = true)]
	[SerializeField]
	private Color _simDataBackColor;

	[DrawIf("ShowColorControls", Hide = true)]
	[SerializeField]
	[InlineHelp]
	private Color _netDataBackColor;

	[InlineHelp]
	[SerializeField]
	[DrawIf("ShowColorControls", Hide = true)]
	private Color _objDataBackColor;

	[SerializeField]
	[HideInInspector]
	private FusionGraph[] _simGraphs;

	[SerializeField]
	[HideInInspector]
	private FusionGraph[] _objGraphs;

	[HideInInspector]
	[SerializeField]
	private FusionGraph[] _netGraphs;

	[NonSerialized]
	private List<IFusionStatsView> _foundViews;

	[NonSerialized]
	private List<FusionGraph> _foundGraphs;

	[SerializeField]
	[HideInInspector]
	private Text _titleText;

	[HideInInspector]
	[SerializeField]
	private Text _clearIcon;

	[SerializeField]
	[HideInInspector]
	private Text _pauseIcon;

	[HideInInspector]
	[SerializeField]
	private Text _togglIcon;

	[HideInInspector]
	[SerializeField]
	private Text _closeIcon;

	[HideInInspector]
	[SerializeField]
	private Text _canvsIcon;

	[HideInInspector]
	[SerializeField]
	private Text _clearLabel;

	[HideInInspector]
	[SerializeField]
	private Text _pauseLabel;

	[SerializeField]
	[HideInInspector]
	private Text _togglLabel;

	[SerializeField]
	[HideInInspector]
	private Text _closeLabel;

	[SerializeField]
	[HideInInspector]
	private Text _canvsLabel;

	[SerializeField]
	[HideInInspector]
	private Text _objectNameText;

	[HideInInspector]
	[SerializeField]
	private GridLayoutGroup _graphGridLayoutGroup;

	[SerializeField]
	[HideInInspector]
	private Canvas _canvas;

	[HideInInspector]
	[SerializeField]
	private RectTransform _canvasRT;

	[HideInInspector]
	[SerializeField]
	private RectTransform _rootPanelRT;

	[HideInInspector]
	[SerializeField]
	private RectTransform _guidesRT;

	[SerializeField]
	[HideInInspector]
	private RectTransform _headerRT;

	[HideInInspector]
	[SerializeField]
	private RectTransform _statsPanelRT;

	[HideInInspector]
	[SerializeField]
	private RectTransform _graphsLayoutRT;

	[SerializeField]
	[HideInInspector]
	private RectTransform _titleRT;

	[SerializeField]
	[HideInInspector]
	private RectTransform _buttonsRT;

	[HideInInspector]
	[SerializeField]
	private RectTransform _objectTitlePanelRT;

	[HideInInspector]
	[SerializeField]
	private RectTransform _objectIdsGroupRT;

	[HideInInspector]
	[SerializeField]
	private RectTransform _objectMetersPanelRT;

	[SerializeField]
	[HideInInspector]
	private RectTransform _clientIdPanelRT;

	[HideInInspector]
	[SerializeField]
	private RectTransform _authorityPanelRT;

	[HideInInspector]
	[SerializeField]
	private Button _titleButton;

	[SerializeField]
	[HideInInspector]
	private Button _objctButton;

	[HideInInspector]
	[SerializeField]
	private Button _clearButton;

	[HideInInspector]
	[SerializeField]
	private Button _togglButton;

	[SerializeField]
	[HideInInspector]
	private Button _pauseButton;

	[SerializeField]
	[HideInInspector]
	private Button _closeButton;

	[HideInInspector]
	[SerializeField]
	private Button _canvsButton;

	private Font _font;

	private bool _hidden;

	private bool _paused;

	private int _layoutDirty;

	private bool _activeDirty;

	private double _currentDrawTime;

	private double _delayDrawUntil;

	private static bool? _newInputSystemFound;

	private string _previousObjectTitle;

	private float _lastLayoutUpdate;

	public static Simulation.Statistics.NetStatFlags DefaultNetStatsMask => default(Simulation.Statistics.NetStatFlags);

	private bool ShowColorControls => false;

	private bool IsNotPlaying => false;

	public StatCanvasTypes CanvasType
	{
		get
		{
			return default(StatCanvasTypes);
		}
		set
		{
		}
	}

	public bool ShowButtonLabels
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int MaxHeaderHeight
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Rect GameObjectRect
	{
		get
		{
			return default(Rect);
		}
		set
		{
		}
	}

	public Rect OverlayRect
	{
		get
		{
			return default(Rect);
		}
		set
		{
		}
	}

	public FusionGraph.Layouts DefaultLayout
	{
		get
		{
			return default(FusionGraph.Layouts);
		}
		set
		{
		}
	}

	public bool NoTextOverlap
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool NoGraphShader
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int GraphMaxWidth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool EnableObjectStats
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool ShowMissingNetObjWarning => false;

	public NetworkObject Object => null;

	public int ObjectTitleHeight
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int ObjectIdsHeight
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int ObjectMetersHeight
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public NetworkRunner Runner
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Simulation.Statistics.ObjStatFlags IncludedObjectStats
	{
		get
		{
			return default(Simulation.Statistics.ObjStatFlags);
		}
		set
		{
		}
	}

	public Simulation.Statistics.NetStatFlags IncludedNetStats
	{
		get
		{
			return default(Simulation.Statistics.NetStatFlags);
		}
		set
		{
		}
	}

	public Simulation.Statistics.SimStatFlags IncludedSimStats
	{
		get
		{
			return default(Simulation.Statistics.SimStatFlags);
		}
		set
		{
		}
	}

	public bool ModifyColors => false;

	public Color FontColor => default(Color);

	public Color GraphColorGood => default(Color);

	public Color GraphColorWarn => default(Color);

	public Color GraphColorBad => default(Color);

	public Color GraphColorFlag => default(Color);

	public Color SimDataBackColor => default(Color);

	public Color NetDataBackColor => default(Color);

	public Color ObjDataBackColor => default(Color);

	public Rect CurrentRect => default(Rect);

	private Shader Shader => null;

	public static bool NewInputSystemFound => false;

	private bool _graphsAreMissing => false;

	internal static FusionStats CreateInternal(NetworkRunner runner = null, DefaultLayouts layout = DefaultLayouts.Left, Simulation.Statistics.NetStatFlags? netStatsMask = null, Simulation.Statistics.SimStatFlags? simStatsMask = null)
	{
		return null;
	}

	public static FusionStats Create(Transform parent = null, NetworkRunner runner = null, DefaultLayouts? screenLayout = null, DefaultLayouts? objectLayout = null, Simulation.Statistics.NetStatFlags? netStatsMask = null, Simulation.Statistics.SimStatFlags? simStatsMask = null)
	{
		return null;
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void ResetStatics()
	{
	}

	private void UpdateTitle()
	{
	}

	private void DirtyLayout(int minimumRefreshes = 1)
	{
	}

	private void ResetInternal(bool? enableObjectStats = null, Simulation.Statistics.NetStatFlags? netStatsMask = null, Simulation.Statistics.SimStatFlags? simStatsMask = null, DefaultLayouts? objectLayout = null, DefaultLayouts? screenLayout = null)
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	[BehaviourButtonAction("Destroy Graphs", null, "_canvasRT", ConditionFlags = BehaviourActionAttribute.ActionFlags.ShowAtNotRuntime)]
	private void DestroyGraphs()
	{
	}

	private void Initialize()
	{
	}

	[BehaviourButtonAction("Generate Graphs", null, "_graphsAreMissing", ConditionFlags = BehaviourActionAttribute.ActionFlags.ShowAtNotRuntime)]
	private void GenerateGraphs()
	{
	}

	private void AssociateWithRunner(NetworkRunner runner)
	{
	}

	private void DisassociateWithRunner(NetworkRunner runner)
	{
	}

	private void Pause()
	{
	}

	private void Toggle()
	{
	}

	private void Clear()
	{
	}

	private void ToggleCanvasType()
	{
	}

	private void Close()
	{
	}

	private void PingSelectObject()
	{
	}

	private void PingSelectFusionStats()
	{
	}

	private void LateUpdate()
	{
	}

	private void RefreshObjectValues()
	{
	}

	public FusionGraph CreateGraph(Simulation.Statistics.StatSourceTypes type, int statId, RectTransform parentRT)
	{
		return null;
	}

	private void ReapplyEnabled()
	{
	}

	private void CalculateLayout()
	{
	}

	private void ApplyDefaultLayout(DefaultLayouts defaults, StatCanvasTypes? applyForCanvasType = null)
	{
	}
}
