
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
            BinarySearch = new TabPage();
            TextSearch = new TabPage();
            ObjectSearch = new TabPage();
            ValueSearch = new TabPage();
            MatrixSearch = new TabPage();
            TabControl1.SuspendLayout();
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
            TabControl1.Size = new Size(949, 589);
            TabControl1.TabIndex = 0;
            // 
            // LinearSearch
            // 
            LinearSearch.Location = new Point(4, 29);
            LinearSearch.Name = "LinearSearch";
            LinearSearch.Padding = new Padding(3);
            LinearSearch.Size = new Size(941, 556);
            LinearSearch.TabIndex = 0;
            LinearSearch.Text = "Lineal";
            LinearSearch.UseVisualStyleBackColor = true;
            LinearSearch.Click += LinearSearch_Click;
            // 
            // BinarySearch
            // 
            BinarySearch.Location = new Point(4, 29);
            BinarySearch.Name = "BinarySearch";
            BinarySearch.Padding = new Padding(3);
            BinarySearch.Size = new Size(792, 417);
            BinarySearch.TabIndex = 1;
            BinarySearch.Text = "Binaria";
            BinarySearch.UseVisualStyleBackColor = true;
            BinarySearch.Click += BinarySearch_Click;
            // 
            // TextSearch
            // 
            TextSearch.Location = new Point(4, 29);
            TextSearch.Name = "TextSearch";
            TextSearch.Padding = new Padding(3);
            TextSearch.Size = new Size(792, 417);
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
            ObjectSearch.Size = new Size(792, 417);
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
            ValueSearch.Size = new Size(792, 417);
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
            MatrixSearch.Size = new Size(792, 417);
            MatrixSearch.TabIndex = 5;
            MatrixSearch.Text = "Matriz 2D";
            MatrixSearch.UseVisualStyleBackColor = true;
            MatrixSearch.Click += MatrixSearch_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 589);
            Controls.Add(TabControl1);
            Name = "FrmPrincipal";
            Text = "Algoritmos de Búsqueda";
            TabControl1.ResumeLayout(false);
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
    }
}
