﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    public class kopek:hayvan
    {
        public kopek(string isim):base(isim) { 
        }
        public override void konus()
        {
            Console.WriteLine(getIsım() + " havlıyor");
        }
    }
}
