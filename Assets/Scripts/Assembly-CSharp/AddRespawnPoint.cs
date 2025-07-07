using NaughtyAttributes;
using UnityEngine;

public class AddRespawnPoint : MonoBehaviour
{
	public Transform parentTransform;

	public Transform emptyObjectsParent;

	[Button("Add EmptyObject", EButtonEnableMode.Always)]
	private void AddEmptyObject()
	{
	}
}
