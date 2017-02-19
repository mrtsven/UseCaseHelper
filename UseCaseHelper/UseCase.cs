using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace UseCaseHelper
{
    class UseCase
    {
        string name;
        string samenvatting;
        string preconditie;
        string beschrijving;
        string uitzonderingen;
        string postconditie;

        public void drawUseCase()
        {
            Label label = new Label();
            label.Tag = name;
            SolidBrush sb = new SolidBrush(Color.Black);

        }
    }

}
