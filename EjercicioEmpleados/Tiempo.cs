﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEmpleados
{
    internal class Tiempo
    {
        private double _segundos;

        public double Horas
        {
            get { return _segundos / 3600; }
            set {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException ("La hora debe estar entre 0 y 24.") ;
                }
                _segundos = value * 3600;
            }
        }
    }
}
