namespace RoleplayGame.Items;
/// <summary>
/// Troll Mace. Objeto que le da ataque al troll.
/// </summary>
public class TrollMace : IAttackItem
{
    /// <summary>
    /// El poder de ataque.
    /// </summary>
    /// <value></value>
    public int AttackPower
    {
        get
        {
            return 50;
        }
    }
    public override string ToString()
        {
            return "Troll mace";
        }
}