namespace RoleplayGame.Items
{
    /// <summary>
    /// Gema que genera un escudo de agua
    /// </summary>
    public class BlueGem : IDefenseItem
    {
        /// <summary>
        /// El poder de defensa.
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 40;
            }
        }

        public override string ToString()
        {
            return "BlueGem";
        }
    }
}