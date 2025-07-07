using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace Moon.Class
{
	public class ClassSwitchModelMove : MonoBehaviour
	{
		public Transform displayPoint;

		public Transform leftPoint;

		public Transform rightPoint;

		public Transform root;

		public Action OnAnimationCompleted;

		private Dictionary<int, GameObject> _modelMap;

		private Dictionary<int, ClassSwitchModelThemeController> _themeControllers;

		private int _displayIndex;

		private int _nextIndex;

		private int _currentIndex;

		private Tween _turningTween;

		public void Initialize(ClassSwitchRoomSetting roomSetting)
		{
		}

		public void SetCurrentIndex(int currentIndex)
		{
		}

		private void InsertModel(int index, PlayerSuitClass suitClass, GameObject asset)
		{
		}

		private void OnDestroy()
		{
		}

		public void TurnLeft(int nextIndex)
		{
		}

		public void TurnRight(int nextIndex)
		{
		}

		private void OnTurnAnimationCompleted()
		{
		}
	}
}
