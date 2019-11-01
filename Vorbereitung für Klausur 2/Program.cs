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
                    Console.WriteLine("Die Quersumme von " + a + " beträgt " + s);
                }


                else if(auswahl == 4)
                {
                    Console.WriteLine("Das Passwort soll mindestens acht Zeichen lang sein und nur aus Zahlen, kleinen und großen Buchstaben bestehen");
                    PW:
                    Console.WriteLine("Passwort eingeben");
                    string p = Convert.ToString (Console.ReadLine());
           
                    
                        //Char.IsDigit(p[i]);
                        //Char.IsLetter(p[i]);
                        //Char.IsUpper(p[i]);
                        //Char.IsLower(p[i]);
                        if (p.Length < 8)
                        {
                            Console.WriteLine("Passwort zu kurz");
                        }
                        if (!ContainsLowerCase(p))
                        {
                            Console.WriteLine("Passwort enthält keine Kleinbuchstaben");
                        }
                        if (!ContainsUpperCase(p))
                        {
                            Console.WriteLine("Passwort enthält keine Großbuchstaben");
                        }
                        if (!ContainsDigitCase(p))
                        {
                            Console.WriteLine("Passwort enthält keine Zahlen");
                        }
                        if (!ContainsLetterCase(p))
                        {
                            Console.WriteLine("Passwort enthält keine Letter");
                        }  
                        goto PW;



                        /* else if(!ContainsLowerCase(p))
                         {
                             Console.WriteLine("Passwort enthält keine Kleinbuchstaben");
                             goto PW;
                         }
                         else if (!ContainsUpperCase(p))
                         {
                             Console.WriteLine("Passwort enthält keine Großbuchstaben");
                             goto PW;
                         }
                         else if (!ContainsDigitCase(p))
                         {
                             Console.WriteLine("Passwort enthält keine Zahlen");
                             goto PW;
                         }
                         else if (!ContainsLetterCase(p))
                         {
                             Console.WriteLine("Passwort enthält keine Letter");
                             goto PW;
                         } */

                    
           
                   

                }
                

                








                Console.WriteLine("neue Auswahl?(j/n)");
                wiederholung = Console.ReadLine();
            } while (wiederholung == "j");
        }

        static bool ContainsLowerCase(string p)
        {
            bool bed = false;
            for(int i = 0; i < p.Length; i++)
            {
                if (Char.IsLower(p[i])) bed = true;
            }
            return bed;
        }

        static bool ContainsUpperCase(string p)
        {
            bool bed = false;
            for (int i = 0; i < p.Length; i++)
            {
                if (Char.IsUpper(p[i])) bed = true;
            }
            return bed;
        }

        static bool ContainsDigitCase(string p)
        {
            bool bed = false;
            for (int i = 0; i < p.Length; i++)
            {
                if (Char.IsDigit(p[i])) bed = true;
            }
            return bed;
        }

        static bool ContainsLetterCase(string p)
        {
            bool bed = false;
            for (int i = 0; i < p.Length; i++)
            {
                if (Char.IsLetter(p[i])) bed = true;
            }
            return bed;
        }


    }
}
