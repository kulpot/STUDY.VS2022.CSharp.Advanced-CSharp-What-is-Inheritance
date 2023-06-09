using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using What_is_Inheritance;

//ref link:https://www.youtube.com/watch?v=-ct4npH2v2k&list=PLhq7kqloVlM9iFmPZpQMgFjL6LytLv1Md&index=2
//

namespace WhatisInheritance
{
    class Program
    {
        // What is Inheritance - derive classes inherit the characteristic of base class
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Name = "Kulpot";
            e.Age = 30;
            e.ID = "1234fsg3";

            e.IntroduceSelf();
        }
    }
}