namespace APP_InventariadoV2
{
    partial class HomeForm
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
            label1 = new Label();
            label2 = new Label();
            btnConsult = new Button();
            btnGestion = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Firebrick;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(776, 36);
            label1.TabIndex = 0;
            label1.Text = "Inventariado Tienda";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Firebrick;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(299, 84);
            label2.Name = "label2";
            label2.Size = new Size(219, 30);
            label2.TabIndex = 1;
            label2.Text = "Menu de operaciones";
            // 
            // btnConsult
            // 
            btnConsult.BackColor = Color.Firebrick;
            btnConsult.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsult.ForeColor = Color.White;
            btnConsult.Location = new Point(142, 147);
            btnConsult.Name = "btnConsult";
            btnConsult.Size = new Size(213, 65);
            btnConsult.TabIndex = 2;
            btnConsult.Text = "Consultas de Productos";
            btnConsult.UseVisualStyleBackColor = false;
            btnConsult.Click += btnConsult_Click;
            // 
            // btnGestion
            // 
            btnGestion.BackColor = Color.Firebrick;
            btnGestion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestion.ForeColor = Color.White;
            btnGestion.Location = new Point(440, 147);
            btnGestion.Name = "btnGestion";
            btnGestion.Size = new Size(213, 65);
            btnGestion.TabIndex = 3;
            btnGestion.Text = "Gestiones de Productos";
            btnGestion.UseVisualStyleBackColor = false;
            btnGestion.Click += btnGestion_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGestion);
            Controls.Add(btnConsult);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HomeForm";
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnConsult;
        private Button btnGestion;
    }
}
