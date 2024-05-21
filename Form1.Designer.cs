namespace CodigosPostales
{
    partial class Form1
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
            DataGVCodP = new DataGridView();
            cBoxEstado = new ComboBox();
            cBoxMunicipio = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGVCodP).BeginInit();
            SuspendLayout();
            // 
            // DataGVCodP
            // 
            DataGVCodP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGVCodP.Location = new Point(28, 119);
            DataGVCodP.Name = "DataGVCodP";
            DataGVCodP.RowHeadersWidth = 51;
            DataGVCodP.Size = new Size(913, 400);
            DataGVCodP.TabIndex = 0;
            // 
            // cBoxEstado
            // 
            cBoxEstado.FormattingEnabled = true;
            cBoxEstado.Location = new Point(28, 65);
            cBoxEstado.Name = "cBoxEstado";
            cBoxEstado.Size = new Size(262, 28);
            cBoxEstado.TabIndex = 1;
            cBoxEstado.SelectedIndexChanged += cBoxEstado_SelectedIndexChanged;
            // 
            // cBoxMunicipio
            // 
            cBoxMunicipio.FormattingEnabled = true;
            cBoxMunicipio.Location = new Point(679, 65);
            cBoxMunicipio.Name = "cBoxMunicipio";
            cBoxMunicipio.Size = new Size(262, 28);
            cBoxMunicipio.TabIndex = 2;
            cBoxMunicipio.SelectedIndexChanged += cBoxMunicipio_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 28);
            label1.Name = "label1";
            label1.Size = new Size(88, 26);
            label1.TabIndex = 3;
            label1.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(679, 28);
            label2.Name = "label2";
            label2.Size = new Size(118, 26);
            label2.TabIndex = 4;
            label2.Text = "Municipio";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(970, 531);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cBoxMunicipio);
            Controls.Add(cBoxEstado);
            Controls.Add(DataGVCodP);
            Name = "Form1";
            Text = "Codigos Postales";
            ((System.ComponentModel.ISupportInitialize)DataGVCodP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGVCodP;
        private ComboBox cBoxEstado;
        private ComboBox cBoxMunicipio;
        private Label label1;
        private Label label2;
    }
}
