using UnityEngine;

namespace Moon.Player.Ability
{
	public abstract class ProgressIndicator : MonoBehaviour
	{
		public abstract void SetProgress(float progress);
	}
}
