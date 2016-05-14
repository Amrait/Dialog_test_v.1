using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BattleControl.Classes
{
    public class Respond : Label
    {
        /// <summary>
        /// Текст відповіді героя
        /// </summary>
        public string Respond_Text { get; set; }
        /// <summary>
        /// Персонаж, з яким розмова йтиме далі
        /// </summary>
        public string Next_NPC { get; set; }
        /// <summary>
        /// Номер наступної сцени
        /// </summary>
        public string Next_Scene { get; set; }
        /// <summary>
        /// Функція, яку визивати надалі - діалог чи бій
        /// </summary>
        public string Next_Function { get; set; }
        /// <summary>
        /// Список ворогів, якщо дана опція тягне за собою бій
        /// </summary>
        public List<string> Enemies {get;set;}
        /// <summary>
        /// Задає фон бойової сцени
        /// </summary>
        public string Background { get; set; }
        public Respond() { }
        public Respond (string text, string N_NPC, string N_Scene, string N_Function, string background)
        {
            Respond_Text = text;
            Next_NPC = N_NPC;
            Next_Scene = N_Scene;
            Next_Function = N_Function;
            Background = background;
            Enemies = new List<string>();

            Text = Respond_Text;
            AutoSize = true;
        }
    }
}
