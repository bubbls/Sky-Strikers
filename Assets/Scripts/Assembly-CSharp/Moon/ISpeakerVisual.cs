using Moon.Arena;

namespace Moon
{
	public interface ISpeakerVisual
	{
		void Initialize(bool isLocalPlayerVisual);

		void ApplyTeamChangedVisuals(PlayerMaterial material, TeamNo teamNo);

		void UpdateInternal(float value);
	}
}
