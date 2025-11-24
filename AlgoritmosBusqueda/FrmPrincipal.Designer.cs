
namespace AlgoritmosBusqueda
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabControl1 = new TabControl();
            LinearSearch = new TabPage();
            btnGenerateLinear = new Button();
            btnBuscarLinear = new Button();
            label2 = new Label();
            label1 = new Label();
            txtLinealInput = new TextBox();
            lstLineal = new ListBox();
            BinarySearch = new TabPage();
            btnGenerarBinaria = new Button();
            btnBuscarBinaria = new Button();
            label3 = new Label();
            label4 = new Label();
            txtBinariaInput = new TextBox();
            lstBinaria = new ListBox();
            TextSearch = new TabPage();
            ObjectSearch = new TabPage();
            ValueSearch = new TabPage();
            MatrixSearch = new TabPage();
            lstPasosBinaria = new ListBox();
            label5 = new Label();
            TabControl1.SuspendLayout();
            LinearSearch.SuspendLayout();
            BinarySearch.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(LinearSearch);
            TabControl1.Controls.Add(BinarySearch);
            TabControl1.Controls.Add(TextSearch);
            TabControl1.Controls.Add(ObjectSearch);
            TabControl1.Controls.Add(ValueSearch);
            TabControl1.Controls.Add(MatrixSearch);
            TabControl1.Dock = DockStyle.Fill;
            TabControl1.Location = new Point(0, 0);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(860, 624);
            TabControl1.TabIndex = 0;
            // 
            // LinearSearch
            // 
            LinearSearch.Controls.Add(btnGenerateLinear);
            LinearSearch.Controls.Add(btnBuscarLinear);
            LinearSearch.Controls.Add(label2);
            LinearSearch.Controls.Add(label1);
            LinearSearch.Controls.Add(txtLinealInput);
            LinearSearch.Controls.Add(lstLineal);
            LinearSearch.Location = new Point(4, 29);
            LinearSearch.Name = "LinearSearch";
            LinearSearch.Padding = new Padding(3);
            LinearSearch.Size = new Size(852, 591);
            LinearSearch.TabIndex = 0;
            LinearSearch.Text = "Lineal";
            LinearSearch.UseVisualStyleBackColor = true;
            LinearSearch.Click += LinearSearch_Click;
            // 
            // btnGenerateLinear
            // 
            btnGenerateLinear.Location = new Point(538, 215);
            btnGenerateLinear.Name = "btnGenerateLinear";
            btnGenerateLinear.Size = new Size(229, 87);
            btnGenerateLinear.TabIndex = 6;
            btnGenerateLinear.Text = "Generar 20 números";
            btnGenerateLinear.UseVisualStyleBackColor = true;
            btnGenerateLinear.Click += btnGenerateLinear_Click;
            // 
            // btnBuscarLinear
            // 
            btnBuscarLinear.Location = new Point(538, 321);
            btnBuscarLinear.Name = "btnBuscarLinear";
            btnBuscarLinear.Size = new Size(229, 87);
            btnBuscarLinear.TabIndex = 5;
            btnBuscarLinear.Text = "Buscar";
            btnBuscarLinear.UseVisualStyleBackColor = true;
            btnBuscarLinear.Click += btnBuscarLinear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 45);
            label2.Name = "label2";
            label2.Size = new Size(194, 20);
            label2.TabIndex = 3;
            label2.Text = "Lista de números aleatorios:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(517, 93);
            label1.Name = "label1";
            label1.Size = new Size(260, 20);
            label1.TabIndex = 2;
            label1.Text = "Ingresa el número que deseas buscar: ";
            label1.Click += label1_Click;
            // 
            // txtLinealInput
            // 
            txtLinealInput.Location = new Point(517, 134);
            txtLinealInput.Name = "txtLinealInput";
            txtLinealInput.Size = new Size(268, 27);
            txtLinealInput.TabIndex = 1;
            // 
            // lstLineal
            // 
            lstLineal.FormattingEnabled = true;
            lstLineal.Location = new Point(63, 77);
            lstLineal.Name = "lstLineal";
            lstLineal.Size = new Size(373, 464);
            lstLineal.TabIndex = 0;
            // 
            // BinarySearch
            // 
            BinarySearch.Controls.Add(label5);
            BinarySearch.Controls.Add(lstPasosBinaria);
            BinarySearch.Controls.Add(btnGenerarBinaria);
            BinarySearch.Controls.Add(btnBuscarBinaria);
            BinarySearch.Controls.Add(label3);
            BinarySearch.Controls.Add(label4);
            BinarySearch.Controls.Add(txtBinariaInput);
            BinarySearch.Controls.Add(lstBinaria);
            BinarySearch.Location = new Point(4, 29);
            BinarySearch.Name = "BinarySearch";
            BinarySearch.Padding = new Padding(3);
            BinarySearch.Size = new Size(852, 591);
            BinarySearch.TabIndex = 1;
            BinarySearch.Text = "Binaria";
            BinarySearch.UseVisualStyleBackColor = true;
            BinarySearch.Click += BinarySearch_Click;
            // 
            // btnGenerarBinaria
            // 
            btnGenerarBinaria.Location = new Point(493, 157);
            btnGenerarBinaria.Name = "btnGenerarBinaria";
            btnGenerarBinaria.Size = new Size(229, 87);
            btnGenerarBinaria.TabIndex = 12;
            btnGenerarBinaria.Text = "Generar 30 números:";
            btnGenerarBinaria.UseVisualStyleBackColor = true;
            // 
            // btnBuscarBinaria
            // 
            btnBuscarBinaria.Location = new Point(493, 263);
            btnBuscarBinaria.Name = "btnBuscarBinaria";
            btnBuscarBinaria.Size = new Size(229, 87);
            btnBuscarBinaria.TabIndex = 11;
            btnBuscarBinaria.Text = "Buscar número";
            btnBuscarBinaria.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 32);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 10;
            label3.Text = "Lista de números:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(473, 47);
            label4.Name = "label4";
            label4.Size = new Size(260, 20);
            label4.TabIndex = 9;
            label4.Text = "Ingresa el número que deseas buscar: ";
            // 
            // txtBinariaInput
            // 
            txtBinariaInput.Location = new Point(473, 88);
            txtBinariaInput.Name = "txtBinariaInput";
            txtBinariaInput.Size = new Size(268, 27);
            txtBinariaInput.TabIndex = 8;
            // 
            // lstBinaria
            // 
            lstBinaria.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstBinaria.FormattingEnabled = true;
            lstBinaria.ItemHeight = 23;
            lstBinaria.Location = new Point(43, 66);
            lstBinaria.Name = "lstBinaria";
            lstBinaria.Size = new Size(334, 487);
            lstBinaria.TabIndex = 7;
            // 
            // TextSearch
            // 
            TextSearch.Location = new Point(4, 29);
            TextSearch.Name = "TextSearch";
            TextSearch.Padding = new Padding(3);
            TextSearch.Size = new Size(941, 556);
            TextSearch.TabIndex = 2;
            TextSearch.Text = "Texto";
            TextSearch.UseVisualStyleBackColor = true;
            TextSearch.Click += TextSearch_Click;
            // 
            // ObjectSearch
            // 
            ObjectSearch.Location = new Point(4, 29);
            ObjectSearch.Name = "ObjectSearch";
            ObjectSearch.Padding = new Padding(3);
            ObjectSearch.Size = new Size(941, 556);
            ObjectSearch.TabIndex = 3;
            ObjectSearch.Text = "Objeto";
            ObjectSearch.UseVisualStyleBackColor = true;
            ObjectSearch.Click += ObjectSearch_Click;
            // 
            // ValueSearch
            // 
            ValueSearch.Location = new Point(4, 29);
            ValueSearch.Name = "ValueSearch";
            ValueSearch.Padding = new Padding(3);
            ValueSearch.Size = new Size(941, 556);
            ValueSearch.TabIndex = 4;
            ValueSearch.Text = "Valor mínimo y Máximo";
            ValueSearch.UseVisualStyleBackColor = true;
            ValueSearch.Click += ValueSearch_Click;
            // 
            // MatrixSearch
            // 
            MatrixSearch.Location = new Point(4, 29);
            MatrixSearch.Name = "MatrixSearch";
            MatrixSearch.Padding = new Padding(3);
            MatrixSearch.Size = new Size(941, 556);
            MatrixSearch.TabIndex = 5;
            MatrixSearch.Text = "Matriz 2D";
            MatrixSearch.UseVisualStyleBackColor = true;
            MatrixSearch.Click += MatrixSearch_Click;
            // 
            // lstPasosBinaria
            // 
            lstPasosBinaria.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstPasosBinaria.FormattingEnabled = true;
            lstPasosBinaria.Location = new Point(424, 434);
            lstPasosBinaria.Name = "lstPasosBinaria";
            lstPasosBinaria.Size = new Size(375, 124);
            lstPasosBinaria.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(424, 392);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 14;
            label5.Text = "Historial de pasos:";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 624);
            Controls.Add(TabControl1);
            Name = "FrmPrincipal";
            Text = "Algoritmos de Búsqueda";
            TabControl1.ResumeLayout(false);
            LinearSearch.ResumeLayout(false);
            LinearSearch.PerformLayout();
            BinarySearch.ResumeLayout(false);
            BinarySearch.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private TabControl TabControl1;
        private TabPage LinearSearch;
        private TabPage BinarySearch;
        private TabPage TextSearch;
        private TabPage ObjectSearch;
        private TabPage ValueSearch;
        private TabPage MatrixSearch;
        private ListBox lstLineal;
        private Label label1;
        private TextBox txtLinealInput;
        private Button btnBuscarLinear;
        private Label label2;
        private Button btnGenerateLinear;
        private Button btnGenerarBinaria;
        private Button btnBuscarBinaria;
        private Label label3;
        private Label label4;
        private TextBox txtBinariaInput;
        private ListBox lstBinaria;
        private Label label5;
        private ListBox lstPasosBinaria;
    }
}
