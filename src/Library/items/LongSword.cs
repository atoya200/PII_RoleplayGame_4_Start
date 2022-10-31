namespace RoleplayGame.Items;

public class LongSword : IAttackItem
{
    public int AttackPower
    {
        get
        {
            return 40;
        }
    }
    public override string ToString()
        {
            return "Long Sword";
        }
}