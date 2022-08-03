﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDiseñoFlyweight
{
    class CReceta : IFlyweight
    {
        private string nombre;
        private double costo;
        private double venta;
        public void CalculaCosto()
        {
            foreach (char letra in nombre)
                costo += (int)letra;

            venta = costo * 1.30;
        }

        public void ColocarNombre(string pNombre)
        {
            nombre = pNombre;
        }

        public void Mostrar()
        {
            Console.WriteLine("{0} cuesta {1}",nombre,venta);
        }

        public string obtenerNombre()
        {
            return nombre;
        }
    }
}
