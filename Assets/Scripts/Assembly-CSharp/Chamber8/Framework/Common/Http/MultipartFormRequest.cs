using System.Collections.Generic;
using UnityEngine.Networking;

namespace Chamber8.Framework.Common.Http
{
	public class MultipartFormRequest : AbstractHttpRequest
	{
		public List<IMultipartFormSection> Sections;
	}
}
