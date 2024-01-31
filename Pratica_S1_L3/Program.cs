using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica_S1_L3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //+++++++++++++++++++++++++++++++ ESERCIZIO 2 +++++++++++++++++++++++++++++++++++++++++

            Console.WriteLine("Inserisci la lunghezza del tuo array di nomi");// i dati arrivano da fuori sotto forma di lettera, per cui devo convertire la stringa in numero
            int n = Convert.ToInt32(Console.ReadLine());//storo la stringa che ho preso dall'utente in una variabile n e converto in numero
            string[] Nomi = new string[n];// il mio array di stringhe Nomi verrà costruito col costruttore new ( la sintassi prevede il tipo, in questo caso string)
            for (int i = 0; i < n; i++)// qui ciclo la lunghezza del mio array tante volte quante quelle che l'utente ha inserito
            {
                Console.WriteLine("inserisci il " + (i + 1) + "°nome");//qui chiedo all'utente di inserire i nomi tante volte quanto è lungo l'array
                Nomi[i] = Console.ReadLine();// qui leggo in console i nomi che vengo inseriti di volta in volta

            }
            Console.WriteLine("Quale nome vuoi cercare?");
            string NomeDaCercare = Console.ReadLine();// qui è dove si andrà a storare il nome che l'utente inserirà
            bool Cerca = false;//imposto una variabile booleana su false perchè ancora non ho trovato il nome nell’array.
            for (int i = 0; i < n; i++)// Ciclo l’array per verificare se il nome è presente.
            {
                if (Nomi[i] == NomeDaCercare)// cerco il nome all'interno dell'array Nomi
                {
                    Cerca = true;//il nome è uguale a quello che cerco 
                }
            }
            if (Cerca)
            {
                Console.WriteLine("Il nome è presente nella lista");
            }
            else
            {
                Console.WriteLine("Il nome non è presente nella lista");
            }
            Console.ReadLine();







            //++++++++++++++++++++++++++++++++ ESERCIZIO 3 +++++++++++++++++++++++++++++++++++++++++


            /*Console.WriteLine("Inserisci la dimensione dell'array:");// chiedo all'utente di inserire la dimensione dell'array
            int n = Convert.ToInt32(Console.ReadLine());//converte in un numero intero. In particolare, Console.ReadLine() legge l’input dell’utente come una stringa, mentre Convert.ToInt32() converte la stringa in un numero intero. Il numero intero viene quindi assegnato alla variabile n.
            int[] arr = new int[n];//Questa riga di codice crea un nuovo array di interi con una dimensione specificata dall’utente
            int sum = 0;//stiamo calcolando la somma di tutti i numeri inseriti nell’array. 
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Inserisci il " + (i + 1) + "° numero:");//qui inserisco i numeri sulla base della dimensione dell'array, per questo i+1
                arr[i] = Convert.ToInt32(Console.ReadLine());//essendo l'array numerico, converto la stringa in intero con convert.toint32 e il valore viene assegnato ad i
                sum = sum + arr[i];
            }
            double avg = (double)sum / n;
            Console.WriteLine("La somma di tutti i numeri inseriti all'interno dell'array è: " + sum);
            Console.WriteLine("La media aritmetica di tutti i numeri inseriti all'interno dell'array è: " + avg);
            Console.ReadLine();*/


        }
    }
}

