using System;
using System.Collections.Generic;

namespace IP_generator
{
    class Generator
    {
        private int count;
        public Generator(int count)
        {
            this.count = count;
        }
        public List<string> Generate()
        {
            Random rnd = new Random();
            var IP = new List<string>();
            for (int i = 0; i < count; i++)
            {
                IP.Add(rnd.Next(0, 255) + "." + rnd.Next(0, 255) + "." + rnd.Next(0, 255) + "."+ rnd.Next(0, 255) + "."+ rnd.Next(0, 255));
            }
            return IP;
        }
    }
}
