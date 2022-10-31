namespace RoleplayGame.Items
{
    /// <summary>
    /// Gema que genera una bola de fuego
    /// </summary>
    public class RedGem : IAttackItem
    {
        /// <summary>
        /// El poder de ataque.
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 19;
            }
        }

        public override string ToString()
        {
            return "RedGem";
        }
    }
}