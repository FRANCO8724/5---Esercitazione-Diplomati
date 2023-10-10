using _5___Esercitazione_Diplomati;
using System;
using System.Reflection.Metadata.Ecma335;

namespace _5_Esercitazione_Diplomati
{
    class program
    {        

        static void Main()
        {
            int scelta = 0;
            int cont = 0;
            string[] elenco = new string[100];
            Diplomati a = new Diplomati("", 1, elenco, cont, ""); ;

            //stuttura menù
            do
            {
                //stampa delle opzioni

                Console.Clear();
                Console.WriteLine("5 - Esercitazione Diplomati");
                Console.WriteLine(" ");
                Console.WriteLine("          1 - Aggiunta di un diplomato: ");
                Console.WriteLine("          2 - stampa di tutti i diplomati: ");
                Console.WriteLine("          3 - stampa dei diplomati abili ai concorsi: ");
                Console.WriteLine(" ");
                Console.WriteLine("0 - uscita");
                Console.WriteLine(" ");
                //scelta dell'opzione
                Console.WriteLine("inserisci la scelta ");
                scelta = int.Parse(Console.ReadLine());


                //esecuzione dell'opzione
                switch (scelta)
                {
                    case 1:


                        Console.WriteLine("Inserisci nome diplomato: ");
                        string nome = Console.ReadLine();

                        Console.WriteLine("E' un nuovo diplomato: ");
                        string cond = Console.ReadLine();

                        int voto = 0;

                        if (cond == "sì")
                        {
                            Console.WriteLine("Inserisci punteggio tra 60 e 100: ");
                            voto = int.Parse(Console.ReadLine());                            
                        }
                        else
                        {
                            Console.WriteLine("Inserisci punteggio tra 36 e 60: ");
                            voto = int.Parse(Console.ReadLine());
                        }

                        a = new Diplomati(nome, voto, elenco, cont,cond);
                        
                        cont++;

                        break;

                        case 2:

                        a.Stampa(elenco);

                        break;

                        case 3:

                        a.Stampa2(elenco);

                        break;
                }

                Console.ReadLine();
            } while (scelta != 0);
        }   
    }

}