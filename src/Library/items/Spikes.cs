namespace RoleplayGame.Items;

public class Spikes : IAttackItem
{
    public int AttackPower
    {
        get
        {
            return 10;
        }
    }
    public override string ToString()
    {
        return "Spikes";
    }
}