public class TypeEffects
{
    public async Task TypeWrite(string text, int delay)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            await Task.Delay(delay);
        }
        
    }
}