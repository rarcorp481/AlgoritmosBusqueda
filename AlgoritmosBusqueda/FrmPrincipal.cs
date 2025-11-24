namespace AlgoritmosBusqueda
{
    public partial class FrmPrincipal : Form
    {
        // Arreglos y listas globales para realizar las búsquedas con algoritmos
        int[] arregloLineal = new int[20];

        List<int> listaBinaria = new List<int>();

        List<Estudiante> listaEstudiantes = new List<Estudiante>();

        List<int> listaMinMax = new List<int>();

        int[,] matrizGlobal = new int[10, 10];

        public FrmPrincipal()
        {
            InitializeComponent();

        }

        private void BinarySearch_Click(object sender, EventArgs e) { }
        private void LinearSearch_Click(object sender, EventArgs e) { }
        private void TextSearch_Click(object sender, EventArgs e) { }
        private void ObjectSearch_Click(object sender, EventArgs e) { }
        private void ValueSearch_Click(object sender, EventArgs e) { }
        private void MatrixSearch_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void lstLineal_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtLinealInput_TextChanged(object sender, EventArgs e) { }
        private void lstPasosBinaria_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void lstBinaria_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtBinariaInput_TextChanged(object sender, EventArgs e) { }
        private void txtParrafo_TextChanged(object sender, EventArgs e) { }
        private void txtPalabra_TextChanged(object sender, EventArgs e) { }



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





        //Ejercicio 3: Búsqueda de texto en un párrafo
        private void btnCargarTexto_Click(object sender, EventArgs e)
        {
            // Texto largo para llenar tu TextBox grande
            txtParrafo.Text =
                "En el mundo del desarrollo de software, el código es la base de todo. " +
                "Un buen código no solo funciona, sino que es limpio y fácil de mantener. " +
                "Muchos programadores creen que escribir código rápido es mejor, pero " +
                "la realidad es que un código ordenado ahorra horas de depuración. " +
                "Cuando revisas el código de otra persona, aprendes nuevas técnicas. " +
                "El código fuente debe ser tratado como una obra de arte técnica. " +
                "Sin código, no existirían las aplicaciones que usamos a diario. " +
                "Recuerda siempre comentar tu código para que otros lo entiendan.";

            // Palabra sugerida para buscar
            txtPalabra.Text = "código";

            // Resetear label de resultado
            lblResultadoTexto.Text = "Resultado: -";
        }

        private void btnBuscarTexto_Click(object sender, EventArgs e)
        {
            string textoCompleto = txtParrafo.Text.ToLower();
            string palabraBusqueda = txtPalabra.Text.ToLower();

            if (string.IsNullOrEmpty(textoCompleto) || string.IsNullOrEmpty(palabraBusqueda))
            {
                MessageBox.Show("Ingresa texto y palabra primero.");
                return;
            }

            // Limpiar resaltados previos (resetear a blanco)
            txtParrafo.SelectAll();
            txtParrafo.SelectionBackColor = Color.White;
            txtParrafo.DeselectAll();

            int contadorCoincidencias = 0;
            int longitudTexto = textoCompleto.Length;
            int longitudPalabra = palabraBusqueda.Length;

            // Recorrer el texto principal posición por posición
            for (int indiceTexto = 0; indiceTexto <= longitudTexto - longitudPalabra; indiceTexto++)
            {
                int indicePalabra;

                // Comparar carácter por carácter con la palabra buscada
                for (indicePalabra = 0; indicePalabra < longitudPalabra; indicePalabra++)
                {
                    // Si un carácter no coincide, rompemos el ciclo interno
                    if (textoCompleto[indiceTexto + indicePalabra] != palabraBusqueda[indicePalabra])
                    {
                        break;
                    }
                }

                // Si el índice llegó al final, significa que todos los caracteres coincidieron
                if (indicePalabra == longitudPalabra)
                {
                    contadorCoincidencias++;

                    // Seleccionar y resaltar en amarillo la coincidencia encontrada
                    txtParrafo.Select(indiceTexto, longitudPalabra);
                    txtParrafo.SelectionBackColor = Color.Yellow;
                }
            }

            // Quitar la selección final para limpieza visual
            txtParrafo.DeselectAll();
            lblResultadoTexto.Text = $"La palabra '{txtPalabra.Text}' aparece {contadorCoincidencias} veces.";
        }





        // Ejercicio 4: Búsqueda de objetos en una lista
        private void btnCargarEstudiantes_Click(object sender, EventArgs e)
        {
            listaEstudiantes.Clear();

            // Carga de datos de prueba
            listaEstudiantes.Add(new Estudiante { Id = 10, Nombre = "Carlos" });
            listaEstudiantes.Add(new Estudiante { Id = 5, Nombre = "Ana" });
            listaEstudiantes.Add(new Estudiante { Id = 3, Nombre = "Zack" });
            listaEstudiantes.Add(new Estudiante { Id = 8, Nombre = "Beto" });
            listaEstudiantes.Add(new Estudiante { Id = 1, Nombre = "Maria" });
            listaEstudiantes.Add(new Estudiante { Id = 20, Nombre = "Luis" });
            listaEstudiantes.Add(new Estudiante { Id = 15, Nombre = "Dora" });
            listaEstudiantes.Add(new Estudiante { Id = 7, Nombre = "Elena" });
            listaEstudiantes.Add(new Estudiante { Id = 4, Nombre = "Pedro" });
            listaEstudiantes.Add(new Estudiante { Id = 2, Nombre = "Juan" });

            lstEstudiantes.Items.Clear();
            foreach (var est in listaEstudiantes) lstEstudiantes.Items.Add(est);
        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            if (listaEstudiantes.Count == 0) return;

            if (int.TryParse(txtObjetoInput.Text, out int idBuscado))
            {
                bool encontrado = false;
                lstEstudiantes.SelectedIndex = -1;

                // Recorrido secuencial (Lineal)
                for (int i = 0; i < listaEstudiantes.Count; i++)
                {
                    if (listaEstudiantes[i].Id == idBuscado)
                    {
                        lstEstudiantes.SelectedIndex = i; // Resaltar coincidencia
                        MessageBox.Show($"Encontrado: {listaEstudiantes[i].Nombre}");
                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado) MessageBox.Show("ID no encontrado.");
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido.");
            }
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            if (listaEstudiantes.Count == 0) return;

            string nombreBuscado = txtObjetoInput.Text;
            lstEstudiantes.SelectedIndex = -1;

            // Ordenar lista por Nombre 
            listaEstudiantes.Sort((x, y) => string.Compare(x.Nombre, y.Nombre));

            // Refrescar ListBox con el nuevo orden
            lstEstudiantes.Items.Clear();
            foreach (var est in listaEstudiantes) lstEstudiantes.Items.Add(est);

            int inicio = 0;
            int fin = listaEstudiantes.Count - 1;
            bool encontrado = false;

            // Algoritmo Binario
            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;
                string nombreMedio = listaEstudiantes[medio].Nombre;

                // Comparar ignorando mayúsculas/minúsculas
                int comparacion = string.Compare(nombreMedio, nombreBuscado, StringComparison.OrdinalIgnoreCase);

                if (comparacion == 0)
                {
                    lstEstudiantes.SelectedIndex = medio; // Resaltar coincidencia
                    MessageBox.Show($"Encontrado ID: {listaEstudiantes[medio].Id}");
                    encontrado = true;
                    break;
                }

                if (comparacion < 0)
                    inicio = medio + 1; // Buscar en la mitad derecha
                else
                    fin = medio - 1;    // Buscar en la mitad izquierda
            }

            if (!encontrado) MessageBox.Show("Nombre no encontrado.");
        }





        //Ejercicio 5: Búsqueda de valor máximo y mínimo en una lista
        private void btnGenerarMinMax_Click(object sender, EventArgs e)
        {
            lstNumerosMinMax.Items.Clear();
            listaMinMax.Clear();
            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                int numero = rnd.Next(1, 1000);
                listaMinMax.Add(numero);
                lstNumerosMinMax.Items.Add(numero);
            }

            lblResultadosMinMax.Text = "Resultados: (Esperando cálculo...)";
        }

        private void btnCalcularMinMax_Click(object sender, EventArgs e)
        {
            if (listaMinMax.Count == 0)
            {
                MessageBox.Show("Primero genera la lista.");
                return;
            }

            // Inicializamos con el primer elemento para asegurar que el valor sea válido
            int maximo = listaMinMax[0];
            int minimo = listaMinMax[0];
            int iteraciones = 0;

            foreach (int numero in listaMinMax)
            {
                iteraciones++;

                if (numero > maximo)
                {
                    maximo = numero;
                }

                if (numero < minimo)
                {
                    minimo = numero;
                }
            }

            lblResultadosMinMax.Text = $"Valor Máximo: {maximo}\nValor Mínimo: {minimo}\nIteraciones: {iteraciones}";
        }





        //Ejercicio 6: Búsqueda en una matriz 10x10
        private void btnGenerarMatriz_Click(object sender, EventArgs e)
        {
            rtbMatriz.Clear();
            Random rnd = new Random();

            // Llenar la matriz global de 10x10 declarada al inicio
            for (int fila = 0; fila < 10; fila++)
            {
                for (int col = 0; col < 10; col++)
                {
                    matrizGlobal[fila, col] = rnd.Next(1, 100);

                    // PadLeft(4) asegura que cada número ocupe el mismo espacio visual
                    rtbMatriz.AppendText(matrizGlobal[fila, col].ToString().PadLeft(4));
                }
                rtbMatriz.AppendText("\n"); // Salto de línea al terminar cada fila
            }
        }

        private void btnBuscarMatriz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtbMatriz.Text))
            {
                MessageBox.Show("Genera la matriz primero.");
                return;
            }

            if (int.TryParse(txtMatrizInput.Text, out int numeroBuscado))
            {
                // 1. Limpieza visual (quitar resaltados previos)
                rtbMatriz.SelectAll();
                rtbMatriz.SelectionBackColor = Color.White;
                rtbMatriz.DeselectAll();

                string coordenadasEncontradas = "";
                bool encontrado = false;

                for (int fila = 0; fila < 10; fila++)
                {
                    for (int col = 0; col < 10; col++)
                    {
                        if (matrizGlobal[fila, col] == numeroBuscado)
                        {
                            coordenadasEncontradas += $"[{fila},{col}] ";
                            encontrado = true;

                            // --- CÁLCULO DE POSICIÓN ---
                            // (Fila actual * 41 caracteres) + (Columna actual * 4 caracteres)
                            int indiceTexto = (fila * 41) + (col * 4);

                            // Seleccionamos el bloque de 4 espacios y lo pintamos
                            rtbMatriz.Select(indiceTexto, 4);
                            rtbMatriz.SelectionBackColor = Color.Yellow;
                        }
                    }
                }

                rtbMatriz.DeselectAll(); // Quitar la selección azul final

                if (encontrado)
                {
                    MessageBox.Show($"Número encontrado en:\n{coordenadasEncontradas}");
                }
                else
                {
                    MessageBox.Show("El número no existe en la matriz.");
                }
            }
            else
            {
                MessageBox.Show("Ingresa un número válido.");
            }
        }
    }


}

// Clase estudiantes

public class Estudiante
{
    public int Id { get; set; }
    public string Nombre { get; set; }

    public override string ToString()
    {
        return $"{Id} - {Nombre}";
    }
}
