namespace RoleplayGame.Items;
/// <summary>
/// Spiked Gauntlets. Le da ataque y protección al personaje.
/// </summary>
public class SpikedGauntlets : IAttackItem, IDefenseItem
{
    /// <summary>
    /// Crea un objeto guante y un objeto púas, los cuales componen a spiked gauntlets.
    /// </summary>
    /// <returns></returns>
    Gauntlets gauntlets = new Gauntlets();
    Spikes spikes = new Spikes();
    /// <summary>
    /// El poder de defensa.
    /// </summary>
    /// <value></value>
    public int DefensePower
    {
        get
        {
            return gauntlets.DefensePower;
        }
    }
    /// <summary>
    /// El poder de ataque.
    /// </summary>
    /// <value></value>
    public int AttackPower
    {
        get
        {
            return spikes.AttackPower;
        }
    }
}