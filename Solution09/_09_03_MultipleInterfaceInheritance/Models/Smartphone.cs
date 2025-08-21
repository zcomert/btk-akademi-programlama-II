using Contracts;

namespace Models;
public class Smartphone : IRechargeable, IConnectable
{
    public String Model { get; set; }

    public Smartphone(string model)
    {
        Model = model;
    }

    public void Connect()
    {
        Console.WriteLine($"{Model} şarj ediliyor.");
    }

    public void Recharge()
    {
        Console.WriteLine($"{Model} şarj ediliyor....");
    }
}
