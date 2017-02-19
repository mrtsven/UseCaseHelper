using System;
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
    public partial class Form1 : Form
    {
        int y;
        int x;
        int i;
        List<Actor> actorList = new List<Actor>();
        List<UseCase> useCaseList = new List<UseCase>();

        public Form1()
        {
            InitializeComponent();
            pActor1.Visible = false;
            pActor2.Visible = false;
            pActor3.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (rbtnActor.Checked && rbtnCreate.Checked)
            {

                if (this.i < 4)
                {
                    i++;
                    actorList.Add(new Actor());
                    if (i == 1)
                    {
                        pActor1.Visible = true;
                    }
                    if (i == 2)
                    {
                        pActor2.Visible = true;
                    }
                    if (i == 3)
                    {
                        pActor3.Visible = true;
                    }
                }
            }
        }

    }
}
