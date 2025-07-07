using System.Collections.Generic;
using DG.Tweening;
using DP.Takeaway.FX;
using DP.Takeaway.Sound;
using Moon.Framework.Leaderboard;
using SVGImporter;
using TMPro;
using UnityEngine;

namespace Moon.GameActivity
{
	public class LeaderboardEntryObject : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _textNo;

		[SerializeField]
		private TMP_Text _textName;

		[SerializeField]
		private TMP_Text _textScore;

		[SerializeField]
		private Transform _pivot;

		[SerializeField]
		private SoundInfo _sfxUpdated;

		[SerializeField]
		private bool _useHighlight;

		[SerializeField]
		private SVGColorModifier[] _modifiers;

		[SerializeField]
		private Color _modColor1;

		[SerializeField]
		private Color _modColor2;

		[SerializeField]
		private float _modAlphaMultiplier;

		[SerializeField]
		private List<TMP_Text> _texts;

		[SerializeField]
		private Color _textColor;

		[SerializeField]
		private LightIntensityController _lightCtrl;

		[SerializeField]
		private SoundPlayerStub _soundPlayer;

		private List<Color> _textOriginalColor;

		private int _soundIndex;

		private int _playedSoundIndex;

		private Coroutine _highlightCoroutine;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleIntensityChange(float intensity)
		{
		}

		[ContextMenu("Moon/Toggle highlight for seconds")]
		private void ToggleHighlightForSeconds()
		{
		}

		public void Set(LeaderboardEntry? entry, Sequence sequence)
		{
		}
	}
}
