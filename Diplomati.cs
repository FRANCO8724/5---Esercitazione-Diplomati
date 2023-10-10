using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___Esercitazione_Diplomati
{
    internal class Diplomati
    {
        //Attributi
        public string nome1;
        public int voto1;

        //Costruttore
        public Diplomati (string nome1, int voto1,string[] array1,int cont1,string cond)
        {
            this.nome1 = nome1;
            this.voto1 = voto1;

            array1[cont1] = "nome: " + nome1 + ";" + voto1 + ";" + cond;
        }

        //Attributi
        public void Stampa(string[] array1)
        {
            for(int i =0;i<array1.Length;i++)
            {
                if (array1[i] != null)
                {
                    Console.WriteLine(array1[i]);
                }
                else
                {
                    break;
                }
            }
        }

        public void Stampa2(string[] array1)
        {
            for(int i=0;i<array1.Length;i++)
            {
                if (array1[i] != null)
                {
                    string a = array1[i];
                    string[] b = a.Split(';');

                    if (b[2] == "sì")
                    {
                        if (Int32.Parse(b[1]) >= 70)
                        {
                            Console.WriteLine(a);
                        }
                    }
                    else
                    {
                        if (Int32.Parse(b[1]) >= 42)
                        {
                            Console.WriteLine(a);
                        }
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
