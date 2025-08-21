using Contracts;

namespace Models;
public class Phone : IRechargeable
{
    public String Model { get; }
    private int batterLevel; // iç durum | field
    public int BatteryLevel => batterLevel;

    public Phone(string model, int initialBatterLevel=50)
    {
        Model = model;
        batterLevel = Math.Clamp(initialBatterLevel, 0, 100);
    }

    public void Recharge(int amount)
    {
        batterLevel = Math.Clamp(batterLevel + amount, 0, 100);
        Console.WriteLine($"[Phone] {Model} şarj edildi. Seviye : %{batterLevel}");
    }
}
