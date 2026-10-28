using System;

class MessageHelper
{
    public static string GetString(string message)
    {
        Console.WriteLine(message);
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            throw new FormatException("Input cannot be empty!");

        return input;
    }

    public static int GetInt(string message)
    {
        if (!int.TryParse(GetString(message), out int num))
            throw new FormatException("Failed to parse input!");
        return num;
    }

    public static float GetFloat(string message)
    {
        if (!float.TryParse(GetString(message), out float num))
            throw new FormatException("Failed to parse input!");

        return num;
    }

    public static bool GetBoolean(string message)
    {
        switch (GetString(message + "(Y/n)").ToLower()[0])
        {
            case 'y': return true;
            case 'n': return false;
            default: throw new Exception("Input cannot be empty!");
        }
    }
}