namespace RoleplayGame.Items
{
    /// <summary>
    /// Helmet. Le da protección al personaje
    /// </summary>
    public class Helmet : IDefenseItem
    {
        /// <summary>
        /// El poder de defensa.
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 18;
            }
        }

        public override string ToString()
        {
            return "Helmet";
        }
    }
}