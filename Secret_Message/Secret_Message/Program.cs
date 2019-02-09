/*
 * Patrick Collins
 * Assignment 7 
 * 11/26/2018
 */
using System;
using System.IO;
using System.Linq;
using System.Collections;

namespace Secret_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read encoded message
            File s = new File();
            s.Read();
            s.Count(s.instring);
            s.writeMessage();
            Console.ReadKey();
        }
    }
    class File
    {
        public StreamReader infile;
        public string instring { get; set; }

        //Parallel Arrays for letter counting
        public int Counter { get; set; }
        char[] s = { 'A','B','C','D','E','F','G','H',
                    'I','J','K','L','M','N','O','P',
                    'Q','R','S','T','U','V','W','X','Y','Z' };
        int[] alphaCount = new int[26];
        //Constructor
        public File()
        {

        }
        //Read Encoded Message
        public void Read()
        {
            try
            {
                infile = new StreamReader("C:/Users/collinp/OneDrive - University of Southern Indiana/CS258/Secret_Message/Secret_Message/MessageIn.txt");
                instring = infile.ReadToEnd();
                Console.WriteLine(instring);
                infile.Close();
            }
            catch (IOException exc)
            {
                Console.WriteLine("ERROR!");
            }
        }
        //Count Repeated Letters
        public void Count(string message)
        {

            Console.WriteLine("Count the repeating letters in the secret message");
            char[] messageArray = message.ToCharArray();
            //This will cycle through the Alphabet array to find match
            //Then add 1 to the int parallel array matched 
            foreach (char letter in messageArray)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (letter == s[i])
                    {
                        alphaCount[i] = alphaCount[i] + 1;
                    }
                }

            }
            for (int i = 0; i < alphaCount.Length; i++)
            {
                Console.WriteLine(s[i] + " " + alphaCount[i]);
            }

        }
        //Decode Secret Message and Display
        public void writeMessage()
        {
            string message = "";
            char[] messChar = instring.ToCharArray();
            Console.WriteLine("This is the MAX Value");
            Console.WriteLine(s[Array.IndexOf(alphaCount, alphaCount.Max())] + " " + alphaCount.Max());
            int maxValue = alphaCount.Max() - 1;
            foreach (char letter in messChar)
            {
                if (Array.IndexOf(s, letter) + maxValue <= 25)
                {
                    message = message + s[Convert.ToInt32(Array.IndexOf(s, letter) + 12)];
                }
                if (Array.IndexOf(s, letter) + 12 > 25)
                {
                    int num = (Convert.ToInt32(Array.IndexOf(s, letter)) + maxValue) - 26;
                    message = message + s[num];
                }

            }
            Console.WriteLine(message);

        }
        //In Class Notes
        public void arrayListExample()
        {
            //using System.Collections
            ArrayList test = new ArrayList();
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add("Hello");
            Console.WriteLine((int)test[0] + (int)test[1]);
        }
    }
}
