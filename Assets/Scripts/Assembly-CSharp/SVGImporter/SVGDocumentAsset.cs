using UnityEngine;
using UnityEngine.Serialization;

namespace SVGImporter
{
	public class SVGDocumentAsset : ScriptableObject
	{
		[FormerlySerializedAs("errors")]
		[SerializeField]
		protected SVGError[] _errors;

		[SerializeField]
		[FormerlySerializedAs("svgFile")]
		protected string _svgFile;

		[SerializeField]
		[FormerlySerializedAs("title")]
		protected string _title;

		[SerializeField]
		[FormerlySerializedAs("description")]
		protected string _description;

		public SVGError[] errors
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string svgFile
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string title
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string description
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static SVGDocumentAsset CreateInstance(string svgFile, SVGError[] errors = null, string title = null, string description = null)
		{
			return null;
		}
	}
}
