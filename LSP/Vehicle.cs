using System.Runtime.Versioning;

public interface IVehicle
{
   public string Color();
}
public class Lexus : IVehicle
{
    public string Color()=>"black";
}

public class Mercedes : IVehicle
{
    public string Color()=>"white";
}

