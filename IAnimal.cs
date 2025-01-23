using System.Windows.Forms;

namespace _2025._01._16._animals
{
    internal interface IAnimal
    {
        string animalName { get; set; }
        int age { get; set; }
        int weight { get; set; }
        string typeOfAnimal { get; set; }
        string foodType { get; set; }
        Label nameLabel { get; set; }
        Label typeLabel { get; set; }
        PictureBox picture { get; set; }
        Panel AnimalPanel { get; set; }
    }
}
