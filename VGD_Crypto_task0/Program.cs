using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGD_Crypto_task0
{

    internal class Program
    {
        static void Cool_WriteLine(int[] w, string alph)
        {
            Console.WriteLine("Частоты символов в тексте:");
            for (int i = 0; i < w.Length; i++)
            {
                Console.WriteLine(alph[i] + " - " + w[i]);
            }
        }

        static List<string> ReadFromFile(string filename)
        {
            List<string> Q = new List<string>();
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Q.Add(line);
                }
            }
            return Q;
        }

        static void Main(string[] args)
        {   

           
            int[] q = new int[33];
            string alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string filename = "input.txt";
            List<string> Q = ReadFromFile(filename);
            for (int i = 0; i < Q.Count; i++)
            {
                string s = Q[i].ToLower();
                for (int ii = 0; ii < s.Length; ii++)
                {
                    char c = s[ii];
                    if (alph.Contains(c))
                    {
                        if (s[ii] == 'ё')
                        {
                            q[6]++;
                        }
                        else
                        {
                            q[(int)s[ii] - 1072]++;
                        }
                    }
                    //Console.WriteLine(c + " " + (int)c);

                }
            }


            Cool_WriteLine(q, alph);
            //
        }
    }
}
