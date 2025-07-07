using System;

namespace SVGImporter.Document
{
	public class SVGException : DOMException
	{
		private SVGExceptionType code;

		public new SVGExceptionType Code => default(SVGExceptionType);

		public SVGException(SVGExceptionType errorCode)
			: base(null, null)
		{
		}

		public SVGException(SVGExceptionType errorCode, string message)
			: base(null, null)
		{
		}

		public SVGException(SVGExceptionType errorCode, string message, Exception innerException)
			: base(null, null)
		{
		}
	}
}
