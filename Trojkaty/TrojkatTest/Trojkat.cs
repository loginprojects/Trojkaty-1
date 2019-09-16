﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrojkatTest
{
    class Trojkat
    {
        // fields
        private decimal a;
        private decimal b;
        private decimal c;

        // kostruktory
        public Trojkat(double a, double b, double c )
        {
            this.a = (decimal)a;
            this.b = (decimal)b;
            this.c = (decimal)c;
        }

        // przeciążenie ToString
        public override string ToString()
        {
            return $"Trojkat: a={a} b={b} c={c}";
        }

        public double Obwod()
        {
            return (double)(a + b + c);
        }

        public double Obwód
        {
            get { return (double)(a + b + c); }
        }
    }
}
