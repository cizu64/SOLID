public class LowLevel : ILevel
{
    public string GetMessage()
    {
        return $"In {nameof(LowLevel)}";
    }
}