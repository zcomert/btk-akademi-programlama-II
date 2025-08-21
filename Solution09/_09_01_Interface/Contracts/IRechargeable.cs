namespace Contracts;
public interface IRechargeable
{
    // yapısal
    int BatteryLevel { get; }

    // davranışsal
    void Recharge(int amount);
}