using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Player:IRecodable,IPlayable
    {
        public void Record() { Console.WriteLine("Record"); }
        public void Pause() { Console.WriteLine("Pause interface 1 and 2"); }
        public void Stop() { Console.WriteLine("Stop interface 1 and 2"); }
        public void Play() { Console.WriteLine("Play"); }
    }
}
