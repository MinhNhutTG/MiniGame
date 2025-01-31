using MiniGame.UC;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Media;
using System.Threading;

namespace MiniGame
{
    public partial class Form1 : Form
    {
        
       
        public Form1()
        {
            InitializeComponent();
            SoundReload();
            Thread.Sleep(3000);
            NewCard();
            Create4Player();
        }
        
     
        public  void  NewCard()
        {
            pnlCard.Controls.Clear();
            char[] namecard = { 'Q', 'K', 'A' };
            Random random = new Random();
            int numRandom = random.Next(0, 3);
            UC.Card card = new Card(namecard[numRandom]);
            pnlCard.Controls.Add(card);
            PlaySound(namecard[numRandom]);
        }
        public void PlaySound(char name)
        {
           
            SoundPlayer sound = new SoundPlayer();
            if (name == 'K')
            {
                sound.Stream = Properties.Resources.p_38163726_815;
            }
            else if (name == 'A')
            {
                sound.Stream = Properties.Resources.p_38163734_826;
            }
            else
            {
                sound.Stream = Properties.Resources.p_38163721_805;
            }
           
            sound.Play();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            NewCard();
        }

      
        public void Create4Player()
        {
            pllayer1.Controls.Clear();
            pllayer2.Controls.Clear();
            pllayer3.Controls.Clear();
            pllayer4.Controls.Clear();

            Player player1 = new Player("Nhựt");
            Player player2 = new Player("Lâm");
            Player player3 = new Player("Thuận");
            Player player4 = new Player("Phát");

            player1.DataPassed += NewCard;
            player2.DataPassed += NewCard;
            player3.DataPassed += NewCard;
            player4.DataPassed += NewCard;

            pllayer1.Controls.Add(player1);
            pllayer2.Controls.Add(player2);
            pllayer3.Controls.Add(player3);
            pllayer4.Controls.Add(player4);
        }

      
        private void SoundReload()
        {
            SoundPlayer sound = new SoundPlayer();
            sound.Stream = Properties.Resources.game_bonus_144751;
            sound.Play();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SoundReload();
            Thread.Sleep(3000);
            NewCard();
            Create4Player();
        }
    }
}
