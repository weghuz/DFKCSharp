public static class cmd
{
    public static void W(string arg)
    {
        Console.WriteLine(arg);
    }
    public static void WN(string arg)
    {
        Console.Write(arg);
    }
    public static void R(string prompt, out string read)
    {
        Console.WriteLine(prompt);
        read = Console.ReadLine();
    }
    public static string R(string prompt)
    {
        Console.WriteLine(prompt);
        return Console.ReadLine();
    }
    public static string RN(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }
}