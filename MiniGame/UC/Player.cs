﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGame.UC
{
    public partial class Player : UserControl
    {
        public delegate void DataPassedEventHandler();
        public event DataPassedEventHandler DataPassed;
        Class.User us = new Class.User();
        public Player(string name)
        {
            InitializeComponent();
            us.LoadGun();
            lblName.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (us.live == true)
            {
                us.Shoot();
                Thread.Sleep(3000);
                DataPassed?.Invoke();
            }
            else
            {
                MessageBox.Show("Người chơi đã bị hạ , không thể bắn");
            }
          
        }
      
        private void Player_Load(object sender, EventArgs e)
        {
            checkkill();
        }
    }
}
