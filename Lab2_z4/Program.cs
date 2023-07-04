using System;

namespace Lab2_z4
{
    class Program
    {
        static bool DaLiJePalindrom(string s)
        {
            char[] pojedinacnaSlova = new char[s.Length];
            int stvarnaDuzina = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsWhiteSpace(s[i]) && !char.IsPunctuation(s[i]))
                {
                    if (char.IsUpper(s[i]))
                    {
                        pojedinacnaSlova[stvarnaDuzina] = char.ToLower(s[i]);
                        stvarnaDuzina++;
                    }
                    else
                    {
                        pojedinacnaSlova[stvarnaDuzina] = s[i];
                        stvarnaDuzina++;
                    }
                }
            }

            bool palindrom = true;
            int pomocna = stvarnaDuzina - 1;
            for(int i = 0; i < stvarnaDuzina; i++)
            {
                if (pojedinacnaSlova[i] != pojedinacnaSlova[pomocna])
                    palindrom = false;
                pomocna--;
            }

            return palindrom;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Unesite string: ");
            string s = Console.ReadLine();
            string ishod = DaLiJePalindrom(s) ? "jeste" : "nije";
            Console.WriteLine("Uneseni string {0} palindrom.", ishod);
        }
    }
}