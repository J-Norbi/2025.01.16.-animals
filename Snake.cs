using System.Windows.Forms;
using System.Drawing;

namespace _2025._01._16._animals
{
    internal class Snake : Animal
    {
        public Snake(string name, string type):base(name, type)
        {
            AnimalPanel.BackColor = System.Drawing.Color.Green;
            picture.Image = Image.FromFile("kigyo.jpg");
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            this.ForeColor = System.Drawing.Color.White;
        }
    }
}
