﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseCaseHelper
{
    public partial class ActorName : Form
    {

        Form1 mainfrm;
        
        public ActorName(Form1 mainfrm)
        {
            InitializeComponent();
            this.mainfrm = mainfrm;
        }

        private void btnOke_Click(object sender, EventArgs e)
        {
            try
            {
                Actor actor = new Actor(txtActorName.Text);
                mainfrm.voegActorToe(actor);
                this.Dispose();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

    }
}
