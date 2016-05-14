using System;

namespace BattleControl.Classes
{
    public class Attributes
    {
        /// <summary>
        /// Уровень силы персонажа
        /// </summary>
        public int Might { get; set; }

        /// <summary>
        /// Уровень телосложения персонажа
        /// </summary>
        public int Constitution { get; set; }

        /// <summary>
        /// Уровень ловкости персонажа
        /// </summary>
        public int Dexterity { get; set; }

        /// <summary>
        /// Уровень интеллекта персонажа
        /// </summary>
        public int Intelligence { get; set; }

        /// <summary>
        /// Уровень мудрости персонажа
        /// </summary>
        public int Wisdom { get; set; }

        /// <summary>
        /// Уровень харизмы персонажа
        /// </summary>
        public int Charisma { get; set; }

        /// <summary>
        /// Инициализирует характеристики персонажа
        /// </summary>
        /// <param name ="Mig">Might = Сила</param>
        /// <param name ="Con">Constitution = Телосложение</param>
        /// <param name ="Dex">Dexterity = Ловкость</param>
        /// <param name ="Int">Intelligence = Интеллект</param>
        /// <param name ="Wis">Wisdom = Мудрость</param>
        /// <param name ="Char">Charisma = Харизма</param>
        public Attributes(int Mig, int Con, int Dex, int Int, int Wis, int Char)
        {
            Might = Mig;
            Constitution = Con;
            Dexterity = Dex;
            Intelligence = Int;
            Wisdom = Wis;
            Charisma = Char;
        }

        public Attributes() { }
    }
}
