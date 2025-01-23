using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025._01._16._animals
{
    public partial class Form1 : Form
    {
        public static PictureBox veryBigPicture;
        public Form1()
        {
            InitializeComponent();
            Start();
        }
        void Start()
        {
            veryBigPicture = new PictureBox()
            {
                Width = (int)(this.Width * 0.8),
                Height = (int)(this.Height * 0.8),
                Left = (int)(this.Width * 0.1),
                Top = (int)(this.Height * 0.1),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            this.Controls.Add(veryBigPicture);
            veryBigPicture.Hide();
            Snake oneSnake = new Snake("Boa", "óriáskígyó sárkányfejű gyíktestű szörnyszülött :)");
            this.Controls.Add(oneSnake);
            veryBigPicture.Click += ClickBigPicture;
        }
        void ClickBigPicture(object s, EventArgs e)
        {
            veryBigPicture.Hide();
        }
    }
}
