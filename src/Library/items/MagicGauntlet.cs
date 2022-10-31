using System.Collections.Generic;
namespace RoleplayGame.Items
{

    /// <summary>
    /// Clase que representa al Guante de Poder
    /// </summary>
    public class MagicGauntlet : IAttackItem, IDefenseItem
    {
        /// <summary>
        /// Contiene gemas de defensa
        /// </summary>
        /// <typeparam name="IAttackItem"></typeparam>
        /// <returns></returns>
        private List<IDefenseItem> defensiveGems = new List<IDefenseItem>();

        /// <summary>
        /// Contiene gemas de ataque
        /// </summary>
        /// <typeparam name="IAttackItem"></typeparam>
        /// <returns></returns>
        private List<IAttackItem> attackGems = new List<IAttackItem>();

        /// <summary>
        /// Agrega gemas de ataque a la lista
        /// </summary>
        /// <param name="gem">Gema de defensa</param>
        public void AddAttackGems(IAttackItem gem)
        {
            attackGems.Add(gem);
        }

        /// <summary>
        /// Quita gemas de ataque a la lista
        /// </summary>
        /// <param name="gem">Gema de defensa</param>
        public void RemovAttackeGems(IAttackItem gem)
        {
            attackGems.Remove(gem);
        }

        /// <summary>
        /// Agrega gemas de defensa a la lista
        /// </summary>
        /// <param name="gem">Gema de defensa</param>
        public void AddDefensiveGems(IDefenseItem gem)
        {
            defensiveGems.Add(gem);
        }

        /// <summary>
        /// Quita gemas de defensa a la lista
        /// </summary>
        /// <param name="gem">Gema de defensa</param>
        public void RemovDefensiveeGems(IDefenseItem gem)
        {
            defensiveGems.Remove(gem);
        }

        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                int powerAttack = 0;
                foreach (IAttackItem gem in attackGems)
                {
                    powerAttack += gem.AttackPower;
                }
                return powerAttack;
            }
        }

        /// <summary>
        /// El poder de defensa determinado por las gemas que tiene
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                int powerDefense = 0;
                foreach (IDefenseItem gem in defensiveGems)
                {
                    powerDefense += gem.DefensePower;
                }
                return powerDefense;
            }
        }

        public override string ToString()
        {
            return "Magic";
        }
    }
}
