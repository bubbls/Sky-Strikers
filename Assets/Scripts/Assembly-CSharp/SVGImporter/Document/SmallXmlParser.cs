using System;
using System.IO;
using System.Text;
using SVGImporter.Utils;

namespace SVGImporter.Document
{
	public class SmallXmlParser
	{
		public interface IContentHandler
		{
			void OnStartParsing(SmallXmlParser parser);

			void OnStartElement(string name, AttributeList attrs);

			void OnEndElement(string name);

			void OnInlineElement(string name, AttributeList attrs);

			void OnStyleElement(string name, AttributeList attrs, string style);
		}

		private IContentHandler handler;

		private TextReader reader;

		private LiteStack elementNames;

		private StringBuilder buffer;

		private char[] nameBuffer;

		private AttributeList attributes;

		private int line;

		private int column;

		private bool resetColumn;

		private Exception Error(string msg)
		{
			return null;
		}

		private Exception UnexpectedEndError()
		{
			return null;
		}

		private bool IsNameChar(char c, bool start)
		{
			return false;
		}

		private bool IsWhitespace(int c)
		{
			return false;
		}

		public void SkipWhitespaces()
		{
		}

		private void HandleWhitespaces()
		{
		}

		public void SkipWhitespaces(bool expected)
		{
		}

		private int Peek()
		{
			return 0;
		}

		private int Read()
		{
			return 0;
		}

		public void Expect(int c)
		{
		}

		private string ReadUntil(char until, bool handleReferences)
		{
			return null;
		}

		public string ReadName()
		{
			return null;
		}

		public void Parse(TextReader input, IContentHandler handler)
		{
		}

		private void Cleanup()
		{
		}

		public void ReadContent()
		{
		}

		private void ReadCharacters()
		{
		}

		private void ReadReference()
		{
		}

		private int ReadCharacterReference()
		{
			return 0;
		}

		private void ReadAttribute(ref AttributeList a)
		{
		}

		private void ReadCDATASection()
		{
		}

		private void ReadComment()
		{
		}
	}
}
