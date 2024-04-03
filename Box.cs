using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Generics
{
    internal class Box:IEquatable<Box>
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }


        public Box(int width, int height, int length)
        {
            this.Width = width;
            this.Height = height;
            this.Length = length;
        }

        public bool Equals(Box? other)
        {
            if (new BoxSameProp().Equals(this, other))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
