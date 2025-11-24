namespace AlgoritmosBusqueda
{
    public partial class FrmPrincipal : Form
    {
        // Arreglos y listas globales para realizar las búsquedas con algoritmos
        int[] arregloLineal = new int[20];

        List<int> listaBinaria = new List<int>();

        List<Estudiante> listaEstudiantes = new List<Estudiante>();

        int[,] matrizGlobal = new int[10, 10];

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        // Ejercicio 1: Búsqueda Lineal

        private void btnBuscarLinear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLinealInput.Text)) MessageBox.Show("Ingrese un número válido.");

            else
            {
                if (int.TryParse(txtLinealInput.Text, out int buscado))
                {
                    bool encontrado = false;

                    for (int i = 0; i < 20; i++)
                    {
                        if (arregloLineal[i] == buscado)
                        {
                            MessageBox.Show($"¡Encontrado en posición {i}!");
                            lstLineal.SelectedIndex = i;
                            encontrado = true;
                            break;
                        }
                    }
                    if (!encontrado) MessageBox.Show("No existe en el arreglo.");
                }
                else MessageBox.Show("Ingrese un número válido.");
            }


        }

        private void btnGenerateLinear_Click(object sender, EventArgs e)
        {
            lstLineal.Items.Clear();
            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                arregloLineal[i] = rnd.Next(1, 100);
                lstLineal.Items.Add($"{i})   {arregloLineal[i]}");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Ejercicio 2: Búsqueda Binaria


    }

}

// Clase estudiantes

public class Estudiante
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public override string ToString() { return Id + " - " + Nombre; }
}
