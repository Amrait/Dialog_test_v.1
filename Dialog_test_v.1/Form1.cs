using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BattleControl.Classes;
using System.Xml;

namespace Dialog_test_v._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Hero Player = new Hero("Амраит", 10, 10, 10, 10, 10, 10, 125);
        private void Confirm_Click(object sender, EventArgs e)
        {
            NPC Narrator = new NPC("Narrator");
            richTextBox1.Text += Narrator.NPC_Line("1", Player,Narrator);
            Player.Generate("1", "Narrator");
            this.Display_Answers();
        }
        private void answer_Click(object sender, EventArgs e)
        {
            Respond answer = sender as Respond;
            if (answer.Next_Function == "Dialog")
            {
                Player.Responds.Clear();
                groupBox2.Controls.Clear();
                NPC speaker = new NPC(answer.Next_NPC);
                richTextBox1.Text += "\n" + Player.Name + ":\t" + answer.Respond_Text;
                richTextBox1.Text += "\n" + speaker.NPC_Line(answer.Next_Scene, Player, speaker);
                Player.Generate(answer.Next_Scene, answer.Next_NPC);
                this.Display_Answers();
            }
            if (answer.Next_Function == "Fight")
            {

            }
        }
        private void Display_Answers()
        {
            int i = 0;
            foreach (Respond answer in Player.Responds)
            {
                groupBox2.Controls.Add(answer);
                answer.Location = new Point(20, 20 + i);
                i += 20;
                answer.Click += new EventHandler(answer_Click);
            }
        }
    }
 }
