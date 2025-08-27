using Contracts;

namespace Models;
public class Laptop : IRechargeable
{
    public String Model { get; set; }

    public void Recharge()
    {
        throw new NotImplementedException();
    }
}