﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseHelper
{
    public class Actor
    {
        private int id;
        private string name;

        public Actor(string NAME)
        {
            name = NAME;
        }

        public string getName(){
            return name;
        }

        public void setName(string nameSet)
        {
            name = nameSet;
        }

        public int getID()
        {
            return id;
        }
    }

}
