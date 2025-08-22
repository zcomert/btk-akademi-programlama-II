namespace CoreLib;

public class DeviceBase
{
    protected int batteryLevel = 100;
    private void Recalibrate()
    {
        Console.WriteLine("Batarya kalibre ediliyor.");
    }

    public int GetBattery() => batteryLevel;
    protected void Drain(int amount)
    {
        batteryLevel = Math.Max(0, batteryLevel-amount);
        Recalibrate();
    }
}
