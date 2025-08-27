using Contracts;
using Models;

Smartphone phone = new Smartphone("Pixy 10");
phone.Recharge();
phone.Connect();

IRechargeable batteryRef = phone;
IConnectable netRef = phone;

Console.WriteLine("Arayüz kullanımı");
batteryRef.Recharge();
netRef.Connect();

Console.ReadKey();