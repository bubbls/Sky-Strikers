using System.Collections.Generic;
using UnityEngine;

namespace Moon
{
	public interface IPrewarmScheme
	{
		void GetObjectsToPreload(out List<GameObject> prewarmObjects);
	}
}
