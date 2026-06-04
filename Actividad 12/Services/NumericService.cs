using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_12.Services
{
    internal class NumericService
    {
        private int[] LUs = new int[100];
        private string[] Nombres = new string[100];
        private double[] Notas = new double[100];
        private int Contador;
        public NumericService()
        {
            Contador = 0;
        }
        public void RegistrarAlumno(int lu, string nombre, double nota)
        {
            LUs[Contador] = lu;
            Nombres[Contador] = nombre;
            Notas[Contador] = nota;
            Contador++;
        }
        public int VerContador()
        {
            return Contador;
        }
        public string VerAlumno(int idx)
        {
            string alumno = "";
            if (idx >= 0 && idx < Contador)
            {
                alumno = $"{LUs[idx]} - {Nombres[idx]} - {Notas[idx]}";
            }
            return alumno;
        }
        public int BuscarPorLUSecuencial(int lu)
        {
            int i = 0, idx = -1;
            bool corte = false;
            while (!corte && i < Contador)
            {
                if (LUs[i] == lu)
                {
                    idx = i;
                    corte = true;
                }
                else
                {
                    i++;
                }
            }
            return idx;
        }
        public void OrdenarPorLUBurbuja()
        {
            for (int a=0; a < Contador - 1; a++)
            {
                for(int b = a + 1; b < Contador; b++)
                {
                    if (LUs[a]> LUs[b])
                    {
                        int lu_aux = LUs[a];
                        LUs[a] = LUs[b];
                        LUs[b] = lu_aux;
                        string nom_aux = Nombres[a];
                        Nombres[a] = Nombres[b];
                        Nombres[b] = nom_aux;
                        double nota_aux = Notas[a];
                        Notas[a] = Notas[b];
                        Notas[b] = nota_aux;
                    }
                }
            }
        }
    }
}
