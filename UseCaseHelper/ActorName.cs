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
    public partial class ActorName : Form
    {
        public Actor actorName = new Actor();

        public ActorName()
        {
            InitializeComponent();
        }

        private void btnOke_Click(object sender, EventArgs e)
        {
            try
            {
                actorName.setName(txtActorName.Text);
                this.Dispose();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

    }
}
