using System;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Forms;

namespace BattleControl.Classes
{
    public class NPC
    {
        /// <summary>
        /// Шлях до XML-файлу з діалогом персонажа
        /// </summary>
        public string Dialog_Path { get; set; }
        /// <summary>
        /// Шлях до зображення персонажа
        /// </summary>
        public string Image { get; set; }
        public NPC(string name)
        {
            XmlDocument Characters = new XmlDocument();
            Characters.Load(Application.StartupPath + "\\Characters\\Characters.xml");
            XmlElement Root = Characters.DocumentElement;
            foreach (XmlNode npc in Root.ChildNodes)
            {
                if (npc.Attributes["name"].Value == name)
                {
                    Dialog_Path = npc.Attributes["name"].Value;
                    Image = npc.Attributes["image"].Value;
                }
            }
        }
        public string NPC_Line(string Scene_ID, Hero player, NPC speaker)
        {
            Dictionary<string, int> reqs = new Dictionary<string, int>();
            Dictionary<string, int> stats = Check_Stats(player);
            string line = "";
            bool error = false;
            XmlDocument Dialog = new XmlDocument();
            Dialog.Load(Application.StartupPath + "\\Dialogs\\" + speaker.Dialog_Path + ".xml");
            XmlElement Root = Dialog.DocumentElement;
            foreach (XmlNode Scene in Root.ChildNodes)
            {
                if (Scene.Attributes["id"].Value == Scene_ID)
                {
                    line = Scene.Attributes["NPC_Name"].Value + ":\t" + Scene.Attributes["text"].Value;
                    foreach (XmlNode SceneNode in Scene.ChildNodes)
                    {
                        if (SceneNode.Name == "additions")
                        {
                            if (!String.IsNullOrWhiteSpace(SceneNode.Attributes["text"].Value))
                            {
                                foreach (XmlAttribute req in SceneNode.FirstChild.Attributes)
                                {
                                    reqs.Add(req.Name, Convert.ToInt32(req.Value));
                                }
                                foreach (KeyValuePair<string, int> pair in stats)
                                {
                                    if (reqs[pair.Key] > pair.Value) error = true;
                                }
                                if (error != true) line += "\n" + SceneNode.Attributes["text"].Value;
                            }
                        }
                    }
                }
            }
            line = line.Replace("Player", player.Name);
            return line;
        }
        public Dictionary<string,int> Check_Stats (Hero player)
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
