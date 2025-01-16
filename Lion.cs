using System.Windows.Forms;

namespace _2025._01._16._animals
{
    internal class Lion : UserControl, IAnimal           // csak egy Class-t tudsz örökölni, de korlátlan interfészt
                                                         // Interfész: csak a felépítését tárolja meg a Class-nek
    {
        public Lion(string name, string type)
        {
            animalName = name;
            typeOfAnimal = type;
            nameLabel = new Label() { Text = name };
            typeLabel = new Label() { Text = type };
        }
        public Label nameLabel { get; set; }
        public Label typeLabel { get; set; }
        public string animalName { get; set; }
        public int age { get; set; }
        public int weight { get; set; }
        public string typeOfAnimal { get; set; }
        public string foodType { get; set; }
    }
}
