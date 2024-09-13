namespace APP_InventariadoV2
{
    partial class FormConsultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            IdConculta = new TextBox();
            btnConsultarP = new Button();
            dataGridView1 = new DataGridView();
            RegreCons = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Brown;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(777, 45);
            label1.TabIndex = 0;
            label1.Text = "Consultas de productos de la tienda ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Brown;
            label2.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 70);
            label2.Name = "label2";
            label2.Size = new Size(147, 23);
            label2.TabIndex = 1;
            label2.Text = "ID Producto";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IdConculta
            // 
            IdConculta.Location = new Point(177, 70);
            IdConculta.Name = "IdConculta";
            IdConculta.Size = new Size(384, 23);
            IdConculta.TabIndex = 2;
            // 
            // btnConsultarP
            // 
            btnConsultarP.BackColor = Color.Brown;
            btnConsultarP.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultarP.ForeColor = Color.White;
            btnConsultarP.Location = new Point(17, 106);
            btnConsultarP.Name = "btnConsultarP";
            btnConsultarP.Size = new Size(144, 29);
            btnConsultarP.TabIndex = 3;
            btnConsultarP.Text = "Consultar Producto";
            btnConsultarP.UseVisualStyleBackColor = false;
            btnConsultarP.Click += btnConsultarP_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 283);
            dataGridView1.TabIndex = 4;
            // 
            // RegreCons
            // 
            RegreCons.BackColor = Color.Brown;
            RegreCons.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegreCons.ForeColor = Color.White;
            RegreCons.Location = new Point(177, 106);
            RegreCons.Name = "RegreCons";
            RegreCons.Size = new Size(144, 29);
            RegreCons.TabIndex = 5;
            RegreCons.Text = "Regresar al menu";
            RegreCons.UseVisualStyleBackColor = false;
            RegreCons.Click += RegreCons_Click;
            // 
            // FormConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(RegreCons);
            Controls.Add(dataGridView1);
            Controls.Add(btnConsultarP);
            Controls.Add(IdConculta);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormConsultas";
            Text = "FormConsultas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox IdConculta;
        private Button btnConsultarP;
        private DataGridView dataGridView1;
        private Button RegreCons;
    }
}