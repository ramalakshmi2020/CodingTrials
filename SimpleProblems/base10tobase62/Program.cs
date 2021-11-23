using System;

namespace base10tobase62
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
          
            
            /*Random rand = new Random();
            byte[] buf = new byte[8];
            rand.NextBytes(buf);
            ulong longRand = BitConverter.ToUInt64(buf, 1);*/

            //Console.WriteLine("long value of generated using randow generator {0} ",longRand);
            long n = 1;
            string shortURL = "";
            string basechar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            while (n > 0) {
                long rem = n % 62;
                shortURL = basechar[(int)rem] + shortURL;
                n = n / 62;
                    }
            
            Console.WriteLine("Base 62 value of {0} is {1} ",n, shortURL);
            //convert it back to input
            long id =0;
            for(int i=0; i< shortURL.Length; i++)
            {
                if (shortURL[i] == '&') continue;
                if ('a' <= shortURL[i] &&
                       shortURL[i] <= 'z')
                    id = id * 62 + shortURL[i] - 'a';
                if ('A' <= shortURL[i] &&
                           shortURL[i] <= 'Z')
                    id = id * 62 + shortURL[i] - 'A' + 26;
                if ('0' <= shortURL[i] &&
                           shortURL[i] <= '9')
                    id = id * 62 + shortURL[i] - '0' + 52;
            }
            Console.WriteLine("Base 10 value of {0} is {1} ", shortURL, id);

            

        }

    }
}
