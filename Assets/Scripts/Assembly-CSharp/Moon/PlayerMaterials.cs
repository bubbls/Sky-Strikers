using DP.Takeaway.Utils;
using Moon.Arena;
using TMPro;
using UnityEngine;

namespace Moon
{
	public class PlayerMaterials : MonoBehaviour, ICommandExecutor
	{
		private static readonly int _outlineColorProperty;

		private static readonly int _outlineStrengthProperty;

		private const string SimplifiedOn = "_SIMPLIFIEDON_ON";

		[SerializeField]
		private Renderer[] _defaultRenderers;

		[SerializeField]
		private Renderer[] _emissiveRenderers;

		[SerializeField]
		private Renderer[] _glassRenderers;

		[SerializeField]
		private Renderer[] _spawnableRenderers;

		[SerializeField]
		private TextMeshPro[] _allTexts;

		[SerializeField]
		private PlayerTeamObjectsGroup _teamObjects;

		private TeamNo _teamNo;

		private Material _defaultMaterial;

		private Material _glassMaterial;

		private bool _outlineSilhouetteEnabled;

		private bool _hasCachedMaterials;

		private float _distance;

		private Color _cachedSilhouetteColor;

		private float _cachedSilhouetteStrength;

		private bool _performanceModeEnabled;

		private bool _hasDefaultMaterial;

		private bool _hasGlassMaterial;

		private void OnDestroy()
		{
		}

		public void SetTeamColor(SuitVisualTheme visualTheme, TeamNo teamNo)
		{
		}

		public void ApplySpawningMaterial(PlayerMaterial material)
		{
		}

		public void ApplyPlayerVisualsForTeam(PlayerMaterial material, TeamNo teamNo)
		{
		}

		private void ApplyMaterialOnRenderers(PlayerMaterial material)
		{
		}

		public void ApplyHologramMaterial(PlayerMaterial material)
		{
		}

		public void ToggleOutlineSilhouette(bool enable)
		{
		}

		public void TogglePerformanceMode(bool enable)
		{
		}

		private void LateUpdate()
		{
		}

		private bool IsOtherTeam()
		{
			return false;
		}

		private void UpdateOtherTeamSilhouette()
		{
		}

		private void ToggleSimplified(Material material, bool on)
		{
		}

		private void ToggleTexts(bool toggle)
		{
		}

		private void TrySetOutlineOnMaterial(Material material, float value, Color color)
		{
		}

		private bool TryGetDistanceFromLocalPlayer(out float distance)
		{
			distance = default(float);
			return false;
		}

		public ICommand ExecuteCommand(ICommand command)
		{
			return null;
		}

		private void TryInstantiateMaterial(ref Material outputMaterial, ref Material inputMaterial)
		{
		}
	}
}
