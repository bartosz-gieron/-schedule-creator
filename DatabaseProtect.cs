using System;

public static class DatabaseProtect
{
	public static String LoadIntoDb(String text)
    {
        text.Replace(";", "!");
        return text;
    }
    public static String LoadFromDb(String text)
    {
        text.Replace("!", ";");
        return text;
    }
}
