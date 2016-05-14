using System;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Forms;

namespace BattleControl.Classes
{
    public class Hero
    {
        /// <summary>
        /// Набір характеристик героя
        /// </summary>
        public Attributes Stats { get; set; }
        /// <summary>
        /// Ім'я персонажа
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Загальне здоров'я
        /// </summary>
        public int Health { get; set; }
        /// <summary>
        /// Базовий рівень здоров'я, залежно від класу
        /// </summary>
        public int BaseHealth { get; set; }
        /// <summary>
        /// Список доступних наразі відповідей
        /// </summary>
        public List<Respond> Responds { get; set; }
        public Hero(string name, int Mig, int Con, int Dex, int Int, int Wis, int Char, int Base)
            {
                Name = name;
                Stats = new Attributes(Mig, Con, Dex, Int, Wis, Char);
                Health = Base + (Stats.Constitution - 10) * 5;
                Responds = new List<Respond>();
            }
        public void Generate(string Scene_ID, string NPC)
        {
            bool error = false;
            XmlDocument Dialog = new XmlDocument();
            Dialog.Load(Application.StartupPath + "\\Dialogs\\" + NPC + ".xml");
            XmlElement Root = Dialog.DocumentElement;
            foreach (XmlNode Scene in Root.ChildNodes)
            {
                if (Scene.Attributes["id"].Value.ToString() == Scene_ID)
                {
                    foreach (XmlNode SceneNode in Scene.ChildNodes)
                    {
                        if (SceneNode.Name.ToString() == "responds")
                        {
                            foreach (XmlNode Quote in SceneNode.ChildNodes)
                            {
                                Dictionary<string, int> reqs = new Dictionary<string, int>();
                                Dictionary<string, int> stats = Check_Stats(this);
                                foreach (XmlAttribute req in Quote.FirstChild.Attributes)
                                {
                                    reqs.Add(req.Name.ToString(), Convert.ToInt32(req.Value));
                                }
                                foreach (KeyValuePair<string, int> pair in stats)
                                {
                                    if (reqs[pair.Key] > pair.Value) error = true;
                                }
                                if (error != true)
                                {
                                    Respond answer = new Respond(Quote.Attributes["text"].Value,
                                        Quote.Attributes["Next_NPC"].Value,
                                        Quote.Attributes["Next_id"].Value,
                                        Quote.Attributes["Next_function"].Value,
                                        Quote.Attributes["Background"].Value);
                                    if (Quote.ChildNodes[1] != null)
                                    {
                                        foreach (XmlAttribute enemy in Quote.ChildNodes[1].Attributes)
                                        {
                                            if (enemy.Value != null) answer.Enemies.Add(enemy.Value);
                                        }
                                    }
                                    Responds.Add(answer);
                                }
                            }
                        }
                    }
                }
            }
        }
        public Dictionary<string, int> Check_Stats(Hero player)
        {
            Dictionary<string, int> stats = new Dictionary<string, int>() {
                { "Might", player.Stats.Might },
                { "Constitution", player.Stats.Constitution },
                { "Dexterity", player.Stats.Dexterity },
                { "Intelligence", player.Stats.Intelligence },
                { "Wisdom", player.Stats.Wisdom },
                { "Charisma", player.Stats.Charisma },
            };
            return stats;
        }
    }
}
