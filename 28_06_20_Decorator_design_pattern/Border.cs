using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_06_20_Decorator_design_pattern
{
    public class Border
    {
        public Color Color { get; set; } 
        public int Width { get; set; }

        public Border(Color color, int width)
        {
            Color = color;
            Width = width;
        }
    }
}
