// Arayüz tür 
using Contracts;
using Models;

IRechargeable[] devices = new IRechargeable[]
{
    new Phone("Pixy 7", 30),
    new Laptop("Ultrabook 14", 55)
};


Console.WriteLine("=== Başlangıç Batarya Seviyelieri ===");
foreach (var device in devices)
{
    Console.WriteLine($"{device.GetType().Name}" +
        $"\n{(device is Phone p ? p.Model : ((Laptop)device).Model)}" +
        $"\nBatarya Seviyesi: %{device.BatteryLevel}");

    Console.WriteLine(new String('-',25));
}

Console.WriteLine("=== Tüm cihazları şarj et ===");
foreach (var device in devices)
{
    device.Recharge(25);
}

Console.WriteLine("=== Bitiş Batarya Seviyelieri ===");

foreach (var device in devices)
{
    Console.WriteLine($"{device.GetType().Name}" +
        $"\n{(device is Phone p ? p.Model : ((Laptop)device).Model)}" +
        $"\nBatarya Seviyesi: %{device.BatteryLevel}");

    Console.WriteLine(new String('-', 25));
}

Console.ReadKey();