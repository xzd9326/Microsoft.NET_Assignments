using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColloredBall
{
    public class Ball
    {
        public int Id { get; set; }
        public int Size { get; set; } 
        public Color Color { get; set; }
        public int TimesThrown { get; set; }
        public Ball(int id, int size, Color color)
        {
            Id = id;
            Size = size;
            Color = color;
            TimesThrown = 0;
            Console.WriteLine($"A new Ball ({Id}) has been created.");
        }
        public void Pop()
        {
            Size = 0;
            Console.WriteLine($"Pop ball ({Id}).");
        }
        public void Throw()
        {
            if (Size != 0)
            {
                TimesThrown++;
                Console.WriteLine($"Throw ball ({Id}).");
            }
            else
            {
                Console.WriteLine($"Cannot throw Ball ({Id}) because it has already been popped.");
            }
        }
        public int BeenThrown()
        {
            return TimesThrown;
        }
    }
}
