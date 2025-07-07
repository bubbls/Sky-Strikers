using Chamber8.Framework.Messaging;
using Moon.Economy;
using TMPro;
using UnityEngine;

namespace Moon.Mission
{
	public class ShowFreeCurrencyBalance : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _txtBalance;

		private PlayerEconomy _playerEconomy;

		private IMessageSubscriber[] _subscribers;

		private void Awake()
		{
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

		private void UpdateFreeCurrencyBalance()
		{
		}

		private int HandlePlayerBalanceChanged(IMessage<object> _)
		{
			return 0;
		}
	}
}
