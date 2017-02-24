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
    public partial class EditActorName : Form
    {
        public Actor actor;
        public Label label;

        public EditActorName(Label label, Actor actor)
        {
            InitializeComponent();
            this.label = label;
            this.actor = actor;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            actor.setName(txtEditName.Text);
            label.Text = txtEditName.Text;
            this.Close();
        }
    }
}
