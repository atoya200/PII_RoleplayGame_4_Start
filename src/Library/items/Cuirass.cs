namespace RoleplayGame.Items;

/// <summary>
/// Cuirass. Le da protección al personaje troll.
/// </summary>
public class Cuirass : IDefenseItem
{
    /// <summary>
    /// El poder de defensa.
    /// </summary>
    /// <value></value>
    public int DefensePower
    {
        get
        {
            return 80;
        }
    }
    public override string ToString()
    {
        return "Cuirass";
    }
}