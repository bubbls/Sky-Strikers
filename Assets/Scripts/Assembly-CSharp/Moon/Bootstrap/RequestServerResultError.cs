namespace Moon.Bootstrap
{
	public enum RequestServerResultError
	{
		NoServerBuildInfo = 404,
		InternalServerError = 500,
		ServerRequestFailed = 502,
		TempBan = 1000
	}
}
