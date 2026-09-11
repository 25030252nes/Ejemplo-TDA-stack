using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_DTA
{
    internal class Pila
    {
        int[] datos = new int[3];
        int tope = -1;

        public void Push(int x) => datos[++tope] = x;

        public bool Buscar(int x)
        {
            for (int i = 0; i <= tope; i++)
                if (datos[i] == x) return true;
            return false;
        }
    }
}
