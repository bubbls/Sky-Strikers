using System;

namespace moveen.utils
{
	public class BadException : Exception
	{
		public BadException()
		{
		}

		public BadException(string message)
		{
		}

		public BadException(string message, Exception cause)
		{
		}

		public BadException(Exception cause)
		{
		}

		public static BadException die(string message)
		{
			return null;
		}

		public static BadException die(string message, Exception cause)
		{
			return null;
		}

		public static BadException die(Exception cause)
		{
			return null;
		}

		public static BadException notImplemented()
		{
			return null;
		}

		public static BadException shouldNeverReachHere()
		{
			return null;
		}

		public static BadException shouldNeverReachHere(string msg)
		{
			return null;
		}
	}
}
