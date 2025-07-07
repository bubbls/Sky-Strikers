using System;

namespace SVGImporter.Document
{
	[Serializable]
	public class DOMException : Exception
	{
		private DOMExceptionType code;

		public DOMExceptionType Code => default(DOMExceptionType);

		protected DOMException(string msg, Exception innerException)
		{
		}

		public DOMException(DOMExceptionType code)
		{
		}

		public DOMException(DOMExceptionType code, string msg)
		{
		}

		public DOMException(DOMExceptionType code, string msg, Exception innerException)
		{
		}
	}
}
