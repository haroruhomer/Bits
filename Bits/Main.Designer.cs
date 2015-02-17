namespace Bits
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.CH_Grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TB_Bits = new System.Windows.Forms.TextBox();
            this.L_Bits = new System.Windows.Forms.Label();
            this.LB_Opciones = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.CH_Grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // CH_Grafico
            // 
            chartArea1.Name = "ChartArea1";
            this.CH_Grafico.ChartAreas.Add(chartArea1);
            this.CH_Grafico.Location = new System.Drawing.Point(12, 38);
            this.CH_Grafico.Name = "CH_Grafico";
            this.CH_Grafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.CH_Grafico.Size = new System.Drawing.Size(769, 443);
            this.CH_Grafico.TabIndex = 0;
            this.CH_Grafico.Text = "Paso de Bits";
            // 
            // TB_Bits
            // 
            this.TB_Bits.Location = new System.Drawing.Point(116, 12);
            this.TB_Bits.Name = "TB_Bits";
            this.TB_Bits.Size = new System.Drawing.Size(383, 20);
            this.TB_Bits.TabIndex = 1;
            this.TB_Bits.Text = "01001100011";
            // 
            // L_Bits
            // 
            this.L_Bits.AutoSize = true;
            this.L_Bits.Location = new System.Drawing.Point(31, 19);
            this.L_Bits.Name = "L_Bits";
            this.L_Bits.Size = new System.Drawing.Size(79, 13);
            this.L_Bits.TabIndex = 2;
            this.L_Bits.Text = "Cadena de Bits";
            // 
            // LB_Opciones
            // 
            this.LB_Opciones.FormattingEnabled = true;
            this.LB_Opciones.Items.AddRange(new object[] {
            "NRZ-L",
            "NRZI",
            "Bipolar-AMI",
            "Pseudoternario",
            "Manchester",
            "Manchester Diferencial",
            "B8ZS",
            "HDB3"});
            this.LB_Opciones.Location = new System.Drawing.Point(787, 90);
            this.LB_Opciones.Name = "LB_Opciones";
            this.LB_Opciones.Size = new System.Drawing.Size(120, 108);
            this.LB_Opciones.TabIndex = 3;
            this.LB_Opciones.SelectedIndexChanged += new System.EventHandler(this.LB_Opciones_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 493);
            this.Controls.Add(this.LB_Opciones);
            this.Controls.Add(this.L_Bits);
            this.Controls.Add(this.TB_Bits);
            this.Controls.Add(this.CH_Grafico);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CH_Grafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart CH_Grafico;
        private System.Windows.Forms.TextBox TB_Bits;
        private System.Windows.Forms.Label L_Bits;
        private System.Windows.Forms.ListBox LB_Opciones;
    }
}

