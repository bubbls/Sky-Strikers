using System;
using System.Runtime.CompilerServices;
using DP.Takeaway.Sound;
using UnityEngine;

namespace Moon.Hub
{
	public class ShuttleRoomSessionNamePad : MonoBehaviour
	{
		[SerializeField]
		private InputBox _inputBox;

		[SerializeField]
		private SoundInfo _sfxHitNumKey;

		[SerializeField]
		private SoundInfo _sfxHitDel;

		[SerializeField]
		private SoundInfo _sfxHitRandom;

		[SerializeField]
		private Keyboard _keyboard;

		private static readonly string _sessionNumberFormat;

		private string _sessionName;

		public string SessionName
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public event Action OnValueChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleKeyPressed(string btnName)
		{
		}

		private void DeleteOneChar()
		{
		}

		private void InputRandomSessionName()
		{
		}

		public void SetText(string text)
		{
		}

		private void InputOneChar(string character)
		{
		}

		public void Clear()
		{
		}

		public void EnableInput()
		{
		}

		public void DisableInput()
		{
		}
	}
}
