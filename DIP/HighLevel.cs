public class HighLevel
{
    private readonly ILevel level;
    public HighLevel(ILevel level)
    {
        this.level = level;
    }
    public string DisplayMessage()
    {
        return level.GetMessage();
    }
}