using System;

namespace csharp_prednaska
{

    public struct Pair
    {
        public int x;
        public int y;
        public Pair(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Pair p = new Pair(1,2);
            p.x = 12;
            p.y = 3;
        }
    }
}
