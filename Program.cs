using System;

namespace IP_generator
{
    class GenerateSomeIp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите колиество генерируемых IP-адресов. От 1 до 100");
                int countOfIp;
                try
                {
                    countOfIp = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Некоректный ввод.\n");
                    continue;
                }
                countOfIp = countOfIp < 100 ? countOfIp : 100;
                Generator gener = new Generator(countOfIp);
                foreach (string ip in gener.Generate())
                {
                    Console.WriteLine(ip);
                }
            }
        }
    }
}
