using System;
using System.Collections.Generic;
using System.Text;

namespace NumWords
{
    class Program
    {
        private static String NumWordsWrapper(int n)
        {
            string words = "";
            int intPart;
            if (n == 0)
                Console.WriteLine("nol");
            try
            {
                string[] splitter = n.ToString().Split('.');
                intPart = int.Parse(splitter[0]);
            }
            catch
            {
                intPart = n;
            }
            words = NumWords(intPart);
            return words;
        }

        static String NumWords(int n)
        //merubah integrer ke dalam kata
        {
            string[] numbersArr = new string[] { "satu", "dua", "tiga", "empat", "lima", "enam", "tujuh", "delapan", "sembilan","sebelas","dua belas","tiga belas","empat belas","lima belas","enam belas","tujuh belas","dealapan belas","sembilan belas" };
            string[] tensArr = new string[] { "dua puluh", "tiga puluh", "empat puluh", "lima puluh", "enam puluh", "tujuh puluh", "delapan puluh", "sembilan puluh", "seratus" };
            string words = "";

            bool tens = false;

            //Untuk menampilkan nilai ratusan (200-999)
            if (0 <= n && n < 999)
            {
                if ((int)n / 100 > 0)
                {
                    words += NumWords(n / 100) + " ratus";
                    n %= 100;
                }



                //Untuk menampilkan nilai puluhan(20 - 99)
                if ((int)n / 10 > 1)
                {
                    if (words != "")
                        words += " ";
                    words += tensArr[(int)n / 10 - 2];
                    tens = true;
                    n %= 10;
                }

                //untuk menampilkan nilai satuan (1-9)
                if (n < 10 && n > 0)
                {
                    if (words != "" && tens == false)
                        words += " ";
                    words += (tens ? " " + numbersArr[(int)n - 1] : numbersArr[(int)n - 1]);
                    n -= (n);
                }
            }

            return words;

        }
        static void Main(string[] args)
        {
            Console.Write("Masukan Angka: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}", NumWordsWrapper(n));
        }
    }
}