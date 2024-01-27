using System.Text.Json;

public class BasicProfile : IProfile
{
    List<object> lst = new();
    public void AddProfile(object profileInfo)
    {
        lst.Add(profileInfo);
    }

    public string ViewProfile()
    {
        string result =  JsonSerializer.Serialize(lst);
        Console.WriteLine(result);
        return result;
    }
}