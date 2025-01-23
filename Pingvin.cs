using System.Windows.Forms;


namespace _2025._01._16._animals
{
    internal class Pingvin : Animal
    {
        public Pingvin(string name, string type):base(name, type)
        {
            this.BackColor = System.Drawing.Color.Purple;
            this.ForeColor = System.Drawing.Color.White;
        }
        
    }
}
