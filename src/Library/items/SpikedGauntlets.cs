namespace RoleplayGame.Items;

public class SpikedGauntlets : IAttackItem, IDefenseItem
{
    Gauntlets gauntlets = new Gauntlets();
    Spikes spikes = new Spikes();
    public int DefensePower
    {
        get
        {
            return gauntlets.DefensePower;
        }
    }
    public int AttackPower
    {
        get
        {
            return spikes.AttackPower;
        }
    }
}