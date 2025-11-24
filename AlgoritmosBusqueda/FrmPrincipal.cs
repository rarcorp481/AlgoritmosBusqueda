namespace AlgoritmosBusqueda
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BinarySearch_Click(object sender, EventArgs e)
        {
            
        }

        private void LinearSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void TextSearch_Click(object sender, EventArgs e)
        {

        }

        private void ObjectSearch_Click(object sender, EventArgs e)
        {

        }

        private void ValueSearch_Click(object sender, EventArgs e)
        {

        }

        private void MatrixSearch_Click(object sender, EventArgs e)
        {

        }
    }
}

// Clase estudiantes

public class Estudiante
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public override string ToString() { return Id + " - " + Nombre; }
}
