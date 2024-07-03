namespace LapiceraPpal
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
            dataGridView1 = new DataGridView();
            lbl_Lapiceras = new Label();
            btn_Agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(123, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(559, 150);
            dataGridView1.TabIndex = 0;
            // 
            // lbl_Lapiceras
            // 
            lbl_Lapiceras.AutoSize = true;
            lbl_Lapiceras.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Lapiceras.Location = new Point(123, 126);
            lbl_Lapiceras.Name = "lbl_Lapiceras";
            lbl_Lapiceras.Size = new Size(76, 16);
            lbl_Lapiceras.TabIndex = 1;
            lbl_Lapiceras.Text = "LAPICERAS";
            // 
            // btn_Agregar
            // 
            btn_Agregar.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Agregar.Location = new Point(331, 334);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(96, 29);
            btn_Agregar.TabIndex = 2;
            btn_Agregar.Text = "AGREGAR";
            btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Agregar);
            Controls.Add(lbl_Lapiceras);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "LAPICERA";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lbl_Lapiceras;
        private Button btn_Agregar;
    }
}
