using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseHelper
{
    public class Actor
    {
        public string name;

        public string getName(){
            return name;
        }

        public void setName(string nameSet)
        {
            nameSet = name;
        }
    }

}
