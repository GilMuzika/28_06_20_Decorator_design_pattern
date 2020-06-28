using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28_06_20_Decorator_design_pattern
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Initialize();
            
        }

        private void Initialize()
        {
            this.Text = "Decorator design pattern";

            PictureBox basicPictrureBox = new PictureBox();
            basicPictrureBox.Width = 100;
            basicPictrureBox.Height = 150;

            basicPictrureBox.Location = new Point(50, 50);
            ImageDecorator decoratedImage = new ImageDecorator(Color.Red, 100, 150, new Border(Color.Green, 2), basicPictrureBox);

            basicPictrureBox.Location = new Point(300, 200);
            ImageDecorator decoratedImage2 = new ImageDecorator(Color.MediumOrchid, 400, 70, new Border(Color.DarkBlue, 20), basicPictrureBox);

            basicPictrureBox.Location = new Point(200, 100);
            ImageDecorator decoratedImage3 = new ImageDecorator(Color.DarkSlateBlue, 33, 140, new Border(Color.Crimson, 15), basicPictrureBox);

            this.Controls.Add(decoratedImage);
            this.Controls.Add(decoratedImage2);
            this.Controls.Add(decoratedImage3);


        }
    }
}
