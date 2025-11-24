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
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lstLineal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtLinealInput_TextChanged(object sender, EventArgs e)
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
                lstLineal.Items.Add($"[{i}]  ->  {arregloLineal[i]}");
            }
        }


        // Ejercicio 2: Búsqueda Binaria
        private void lstBinaria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBinariaInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerarBinaria_Click(object sender, EventArgs e)
        {
            lstBinaria.Items.Clear();
            lstPasosBinaria.Items.Clear();
            listaBinaria.Clear(); // Variable global
            Random rnd = new Random();

            // 1. Generar
            for (int i = 0; i < 30; i++) listaBinaria.Add(rnd.Next(1, 100));

            // 2. Ordenar (Obligatorio para binaria)
            listaBinaria.Sort();

            for (int i = 0; i < listaBinaria.Count; i++)
            {
                lstBinaria.Items.Add($"[{i}]  ->  {listaBinaria[i]}");
            }
        }

        private void btnBuscarBinaria_Click(object sender, EventArgs e)
        {
            if (listaBinaria.Count == 0) { MessageBox.Show("Genera la lista primero"); return; }

            lstPasosBinaria.Items.Clear();

            if (int.TryParse(txtBinariaInput.Text, out int buscado))
            {
                int inicio = 0;
                int fin = listaBinaria.Count - 1;
                bool encontrado = false;

                while (inicio <= fin)
                {
                    int medio = (inicio + fin) / 2;
                    int valorMedio = listaBinaria[medio];

                    //Mover la barra azul de la izquierda a donde estamos mirando
                    lstBinaria.SelectedIndex = medio;

                    //Escribir en la lista de la derecha qué estamos haciendo
                    lstPasosBinaria.Items.Add($"Mirando índice {medio} (Valor: {valorMedio})...");

                    //Pausa de 2000 ms para que se vea el proceso
                    Application.DoEvents(); // Actualiza la pantalla
                    System.Threading.Thread.Sleep(2000);
                    

                    if (valorMedio == buscado)
                    {
                        lstPasosBinaria.Items.Add(">>> ¡ENCONTRADO! <<<");
                        MessageBox.Show($"¡Número encontrado en la posición {medio}!");
                        encontrado = true;
                        break;
                    }

                    if (valorMedio < buscado)
                    {
                        lstPasosBinaria.Items.Add("El valor es muy pequeño. Voy a la derecha ->");
                        inicio = medio + 1;
                    }
                    else
                    {
                        lstPasosBinaria.Items.Add("El valor es muy grande. Voy a la izquierda <-");
                        fin = medio - 1;
                    }
                }

                if (!encontrado)
                {
                    lstPasosBinaria.Items.Add(">>> Fin: No existe. <<<");
                    MessageBox.Show("El número no está en la lista.");
                }
            }
        }

        private void lstPasosBinaria_SelectedIndexChanged(object sender, EventArgs e)
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
