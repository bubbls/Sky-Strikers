using DG.Tweening;
using TMPro;
using UnityEngine;

public class TextMeshProCircle : MonoBehaviour
{
	[ContextMenuItem("Generate Circle Text", "GenerateCircleText")]
	[ContextMenuItem("Cleanup", "Cleanup")]
	[SerializeField]
	private TMP_Text _tmpText;

	[SerializeField]
	private float _radius;

	[SerializeField]
	private float _maxAngle;

	[SerializeField]
	private float _animationDuration;

	[SerializeField]
	private Quaternion _targetRotation;

	[SerializeField]
	private Material _fontMaterial;

	[TextArea]
	[SerializeField]
	private string _text;

	[SerializeField]
	private bool _animateOnStart;

	private Sequence _sequence;

	private void Start()
	{
	}

	private void Cleanup()
	{
	}

	private void GenerateCircleText()
	{
	}

	private void CreateTextMeshPro(Transform parent, Vector3 position, Quaternion rotation, string text, Color fontColor)
	{
	}

	private void Animate()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetText(string text)
	{
	}
}
