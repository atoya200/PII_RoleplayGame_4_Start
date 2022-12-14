namespace RoleplayGame.Items;
/// <summary>
/// Long Sword. Le da ataque al personaje.
/// </summary>
public class LongSword : IAttackItem
{
    /// <summary>
    /// El poder de ataque.
    /// </summary>
    /// <value></value>
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