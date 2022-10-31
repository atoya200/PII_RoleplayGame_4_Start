namespace RoleplayGame.Items;
/// <summary>
/// Gauntlets. Le da protección al personaje.
/// </summary>
public class Gauntlets : IDefenseItem
{
    /// <summary>
    /// El poder de defensa.
    /// </summary>
    /// <value></value>
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