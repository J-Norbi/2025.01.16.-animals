using System.Windows.Forms;
using System.Drawing;
using System;
namespace _2025._01._16._animals
{
    internal class Animal : UserControl, IAnimal
    {
        public Animal(string name, string type)
        {
            animalName = name;
            typeOfAnimal = type;
            nameLabel = new Label()
            {
                Text = name,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true,
                Top = 3,
                Left = 3
            };
            typeLabel = new Label()
            {
                Text = type,
                Top = nameLabel.Bottom,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true,
                Left = 3
            };
            AnimalPanel = new Panel()
            {
                BackColor = Color.White,
                Top = 3,
                Left = 3
            };
            this.BackColor = Color.Black;
            this.Controls.Add(AnimalPanel);
            AnimalPanel.Controls.Add(nameLabel);
            AnimalPanel.Controls.Add(typeLabel);
            picture = new PictureBox() 
            { 
                Left = 3,
                Top = typeLabel.Bottom +3,
                Width = typeLabel.Width,
                Height = (int)((double)typeLabel.Width / 16 * 9)          // (int)((double)...) hogy ne egész számmal számoljunk
                // pl.: Width: 12 => 12 / 16 *9
                // egész osztás => 1 * 9 = 9 lesz
                // valós osztás => 0,75 * 9 = 6,75 => kerekítés miatt 7 lesz
            };
            AnimalPanel.Controls.Add(picture);
            AnimalPanel.Width = typeLabel.Width + 6;
            AnimalPanel.Height = picture.Bottom + 9;
            this.Width = typeLabel.Width + 12;
            this.Height = picture.Bottom + 15;
            picture.Click += ClickPicture;
        }
        public void ClickPicture(object s,EventArgs e)
        {
            Form1.veryBigPicture.Image = picture.Image;
            Form1.veryBigPicture.Show();
        }
        public Label nameLabel { get; set; }
        public Label typeLabel { get; set; }
        public string animalName { get; set; }
        public int age { get; set; }
        public int weight { get; set; }
        public string typeOfAnimal { get; set; }
        public string foodType { get; set; }
        public PictureBox picture { get; set; }
        public Panel AnimalPanel { get; set; }
    }
}
