namespace Olmo.Extras
{
    public static class Extensions
    {
	    public static string DoOlmo(this string inputString, string extra)
	    {
		    return $"{inputString} {extra}";
	    }
    }
}
