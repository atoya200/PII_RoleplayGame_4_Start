namespace RoleplayGame.Items;

public class Gauntlets : IDefenseItem
{
    public int DefensePower
    {
        get
        {
            return 20;
        }
    }
    public override string ToString()
    {
        return "Gauntlets";
    }
}