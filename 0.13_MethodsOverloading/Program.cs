﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_MethodsOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player();
            newPlayer.Attack(400, "Fireball", 50);
        }
    }
}
