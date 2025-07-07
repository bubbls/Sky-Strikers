using DP.Takeaway.Utils;
using Moon.Diagnostics;
using NaughtyAttributes;
using TMPro;
using UnityEngine;

namespace Moon.SNS
{
	public class DiscordBoard : MonoBehaviour
	{
		private const string TextFailedToLink = "Someting went wrong, please try again later.";

		private const string TextAskToLink = "Link your Discord account to add friends and earn rewards!";

		private const string TextLinked = "You linked your Discord account: {DiscordUserName}\n\nInvite new friends to SkyStrikers using your referral code:";

		private const string TextReferralCommand = "/ssvr use_referral_code {ReferralCode}";

		private const string TextCodeExpiration = "This code will expire in {0}.";

		private const string TextCodeExpired = "The code has expired. Please try again.";

		[Header("Unlinked")]
		[SerializeField]
		private GameObject _unlinkedPanel;

		[SerializeField]
		private TMP_Text _textUnlinked;

		[SerializeField]
		private UIButton _btnLinkDiscord;

		[Header("Linking...")]
		[SerializeField]
		private GameObject _linkingPanel;

		[SerializeField]
		private UIButton _btnBack;

		[SerializeField]
		private UIButton _btnRedirectToDiscord;

		[SerializeField]
		private TMP_Text _textCodeVerificationPhrase;

		[SerializeField]
		private TMP_Text _textCodeExpiration;

		[SerializeField]
		[Header("Linked")]
		private GameObject _linkedPanel;

		[SerializeField]
		private ProgressBar _referralProgress;

		[SerializeField]
		private TMP_Text _textLinked;

		[SerializeField]
		private TMP_Text _textReferralCommand;

		[SerializeField]
		private UIButton _btnLinkDiscord2;

		private ReferralRewards? _referralRewards;

		private readonly Cooldown _updateCd;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void GetAccountBindingInformation()
		{
		}

		private void OnDestroy()
		{
		}

		private void HandleDiscordLinkStatusChanged()
		{
		}

		private int GetMaxReferralCount()
		{
			return 0;
		}

		private void HandleLinkCodeGenerateFailed()
		{
		}

		private void HandleLinkCodeGenerated()
		{
		}

		private void HandleButtonLinkDiscordPressed()
		{
		}

		private void HandleButtonRedirectToDiscordPressed()
		{
		}

		private void ShowCodeVerification(CodeWithExpiration code)
		{
		}

		private void LateUpdate()
		{
		}

		private void RestartAccountLinking()
		{
		}

		private void TryRedirectToDiscord()
		{
		}

		private void ShowTryLinkFailed()
		{
		}

		private void ShowCodeExpired()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private static void TryLink()
		{
		}
	}
}
