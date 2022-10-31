namespace RoleplayGame.Items;
/// <summary>
/// Spikes. Le da ataque al personaje.
/// </summary>
public class Spikes : IAttackItem
{
    /// <summary>
    /// El poder de ataque.
    /// </summary>
    /// <value></value>
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