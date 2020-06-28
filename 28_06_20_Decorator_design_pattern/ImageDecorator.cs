using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28_06_20_Decorator_design_pattern
{    
    public class ImageDecorator : PictureBox
    {
        protected Image _image = new Bitmap(1, 1);
        protected Color _color;
        protected int _width;
        protected int _height;
        protected Border _border;

        public ImageDecorator(Color color, int width, int height, Border border, PictureBox pictureBox)
        {
            if(pictureBox.Image != null) _image = pictureBox.Image;
            _color = color;
            _width = width;
            _height = height;
            _border = border;

            this.Location = pictureBox.Location;

            
            this.SetSize();
            this.SetColor();
            this.SetBorder();
            this.Width = _width;
            this.Height = _height;
            this.Image = _image;

            



        }

        protected virtual void SetBorder()
        {                    
            Graphics graphicsObj = Graphics.FromImage(_image);

            Pen myPen = new Pen(this._border.Color, this._border.Width);
            graphicsObj.DrawRectangle(myPen, 0, 0, _image.Width - 1, _image.Height - 1);
            graphicsObj.Dispose();
        }


        protected virtual void SetColor()
        {
            Graphics gr = Graphics.FromImage(_image);            
            gr.FillRectangle(new SolidBrush(this._color), new Rectangle(new Point(this._border.Width / 2, this._border.Width / 2), new Size(_image.Width - this._border.Width, _image.Height - this._border.Width)));            
            gr.Dispose();
        }

        protected virtual void SetSize()
        {
            _image = new Bitmap(_image, new Size(this._width, this._height));
        }
    }
}
