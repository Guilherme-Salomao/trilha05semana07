﻿using Semana07.Classes;
using Semana07.Modulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.ExibirLogo();
            menu.ExibirMenu();
        }
    }
}
