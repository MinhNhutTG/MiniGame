﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGame.UC
{
    public partial class Card : UserControl
    {
        public Card()
        {
            InitializeComponent();
        }
        public Card(char name)
        {
            InitializeComponent();
            lblNameCard.Text = name.ToString();
        }
    }
}
