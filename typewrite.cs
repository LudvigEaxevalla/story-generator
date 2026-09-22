public class TypeEffects
{
    public void TypeWrite(string text, int delay)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
        
    }

    public void TypeWriteLine(string text, int delay)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
        Console.WriteLine();
    }
}