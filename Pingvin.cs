using System.Windows.Forms;


namespace _2025._01._16._animals
{
    internal class Pingvin : UserControl, IAnimal
    {
        public Pingvin(string name, string type)
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
