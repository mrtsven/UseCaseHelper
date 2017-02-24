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
        int actorAmount = 0;
        List<UseCase> useCaseList = new List<UseCase>();
        List<Actor> actorList = new List<Actor>();
        List<Label> actorLabels;

        public Form1()
        {
            InitializeComponent();
            pActor1.Visible = false;
            pActor2.Visible = false;
            pActor3.Visible = false;

            //Voeg labels toe aan lijst
            actorLabels = new List<Label>();
            actorLabels.Add(lblActor1);
            actorLabels.Add(lblActor2);
            actorLabels.Add(lblActor3);
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

        private void pActor1_Click(object sender, EventArgs e)
        {
            if (rbtnSelect.Checked)
            {
                ActorName frm = new ActorName(this);
                frm.ShowDialog();
            }
        }

        private void pActor2_Click(object sender, EventArgs e)
        {
            if (rbtnSelect.Checked)
            {
                ActorName frm = new ActorName(this);
                frm.ShowDialog();
            }
        }

        private void pActor3_Click(object sender, EventArgs e)
        {
            if (rbtnSelect.Checked)
            {
                ActorName frm = new ActorName(this);
                frm.ShowDialog();
            }
        }

        public void voegActorToe(Actor actor)
        {
            actorList.Add(actor);
            actorLabels[actorAmount].Text = actor.getName();
            actorLabels[actorAmount].Click += labelClick;
            actorLabels[actorAmount].Tag = actor;

            actorAmount++;
        }

        void labelClick(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            Actor actor = (Actor)lbl.Tag;
            EditActorName editActor = new EditActorName(lbl, actor);
            editActor.ShowDialog();
        }


    }
}
