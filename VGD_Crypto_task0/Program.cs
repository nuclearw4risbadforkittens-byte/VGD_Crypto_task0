using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGD_Crypto_task0
{

    internal class Program
    {
        static void Cool_WriteLine(int[] w, string alph)
        {
            for (int i = 0; i < w.Length; i++)
            {
                Console.WriteLine(alph[i] + " " + w[i]);
            }
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine().ToLower();
            int[] q = new int[33];
            string alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if(alph.Contains(c))
                {
                    if (s[i] == 'ё')
                    {
                        q[6]++;
                    }
                    else
                    {
                        q[(int)s[i] - 1072]++;
                    }
                }
                //Console.WriteLine(c + " " + (int)c);

            }

            Cool_WriteLine(q, alph);

            //for (int i = 0; i < q.Length; i++)
            //{
            //    Console.WriteLine(q[i]);
            //}
        }
    }
}
