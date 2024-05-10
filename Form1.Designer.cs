namespace AS2324._3G.SpagnoliEnrico.PSDBPCTO
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
            dgvDati = new DataGridView();
            btnElencoPiloti = new Button();
            btnElencoGare = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDati).BeginInit();
            SuspendLayout();
            // 
            // dgvDati
            // 
            dgvDati.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDati.Location = new Point(12, 201);
            dgvDati.Name = "dgvDati";
            dgvDati.Size = new Size(776, 237);
            dgvDati.TabIndex = 0;
            // 
            // btnElencoPiloti
            // 
            btnElencoPiloti.Location = new Point(270, 49);
            btnElencoPiloti.Name = "btnElencoPiloti";
            btnElencoPiloti.Size = new Size(129, 60);
            btnElencoPiloti.TabIndex = 1;
            btnElencoPiloti.Text = "Elenco piloti";
            btnElencoPiloti.UseVisualStyleBackColor = true;
            btnElencoPiloti.Click += btnElencoPiloti_Click_1;
            // 
            // btnElencoGare
            // 
            btnElencoGare.Location = new Point(405, 49);
            btnElencoGare.Name = "btnElencoGare";
            btnElencoGare.Size = new Size(129, 60);
            btnElencoGare.TabIndex = 2;
            btnElencoGare.Text = "Elenco gare";
            btnElencoGare.UseVisualStyleBackColor = true;
            btnElencoGare.Click += btnElencoGare_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnElencoGare);
            Controls.Add(btnElencoPiloti);
            Controls.Add(dgvDati);
            Name = "Form1";
            Text = "Spagnoli Enrico, 10/05/2024, verifica PSDBPCTO";
            ((System.ComponentModel.ISupportInitialize)dgvDati).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDati;
        private Button btnElencoPiloti;
        private Button btnElencoGare;
    }
}
