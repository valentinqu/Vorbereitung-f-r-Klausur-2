using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vorbereitung_für_Klausur_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Auswahlmenü");


            string wiederholung = null;
            do
            {
                Console.WriteLine("1: Zeichen ersetzen");
                Console.WriteLine("2: Vokale entfernen");
                Console.WriteLine("3: Quersumme berechnen");
                Console.WriteLine("4: Passwortstärke prüfen");
                int auswahl = Convert.ToInt32(Console.ReadLine());
                if(auswahl ==1)
                {
                    Console.WriteLine("Texte eingeben");
                    string b = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Welches Zeichen soll ersetzt werden");
                    char b_a = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Ersetzt mit?");
                    char b_b = Convert.ToChar(Console.ReadLine());
                    string b_c = null;
                    for(int i = 0; i < b.Length; i++)
                    {
                        if(b[i] == b_a)
                        {
                            b_c += b_b;
                        }
                        else
                        {
                            b_c += b[i];
                        }
                    }
                    Console.WriteLine(b_c);
                }

                else if (auswahl ==2)
                {
                    Console.WriteLine("Texte eingeben");
                    string t = Convert.ToString(Console.ReadLine());
                    string v = null;
                    for(int i = 0; i < t.Length; i++)
                    {
                        if(t[i] == 'a' || t[i] == 'e' || t[i] == 'i' || t[i] == 'o' || t[i] == 'u' || t[i] == 'A' || t[i] == 'E' || t[i] == 'I' || t[i] == 'O' || t[i] == 'U')
                        {
                            
                        }
                        else
                        {
                            v += t[i];
                        }
                    }
                    Console.WriteLine(v);
                }

                else if(auswahl == 3)
                {
                    Console.WriteLine("Ganze Zahl eingeben");
                    string a = Convert.ToString(Console.ReadLine());
                    int s = 0;
                    for(int i = 0; i < a.Length; i++)
                    {
                        s += Convert.ToInt32 (Convert.ToString(a[i]));
                    }
                    Console.WriteLine(s);
                }


                else if(auswahl == 4)
                {

                }
                

                








                Console.WriteLine("neue Auswahl?(j/n)");
                wiederholung = Console.ReadLine();
            } while (wiederholung == "j");
        }
        

    }
}
