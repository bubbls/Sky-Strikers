using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Networking;

namespace Moon.Framework.Base
{
	[PublicAPI]
	public class WebRequestResponseData
	{
		public long ResponseCode;

		public string RequestUrl;

		public bool HasError;

		public string ErrorMessage;

		public Dictionary<string, string> ResponseHeaders;

		public Uri UriData;

		public string TextData;

		public byte[] BinaryData;

		public Texture TextureData;

		public string CustomData;

		public UnityWebRequest WebRequest;
	}
}
