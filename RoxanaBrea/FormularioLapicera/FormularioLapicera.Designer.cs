namespace FormularioLapicera
{
    partial class FormularioLapicera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioLapicera));
            lbl_Lapiceras = new Label();
            dgv_InfoLapiceras = new DataGridView();
            btn_Agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_InfoLapiceras).BeginInit();
            SuspendLayout();
            // 
            // lbl_Lapiceras
            // 
            lbl_Lapiceras.AutoSize = true;
            lbl_Lapiceras.BackColor = Color.LightSalmon;
            lbl_Lapiceras.Font = new Font("Rockwell", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Lapiceras.Location = new Point(58, 145);
            lbl_Lapiceras.Name = "lbl_Lapiceras";
            lbl_Lapiceras.Size = new Size(95, 18);
            lbl_Lapiceras.TabIndex = 0;
            lbl_Lapiceras.Text = "LAPICERAS";
            // 
            // dgv_InfoLapiceras
            // 
            dgv_InfoLapiceras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_InfoLapiceras.BackgroundColor = Color.PaleGoldenrod;
            dgv_InfoLapiceras.BorderStyle = BorderStyle.None;
            dgv_InfoLapiceras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_InfoLapiceras.Location = new Point(58, 180);
            dgv_InfoLapiceras.Name = "dgv_InfoLapiceras";
            dgv_InfoLapiceras.Size = new Size(568, 150);
            dgv_InfoLapiceras.TabIndex = 1;
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.LightGreen;
            btn_Agregar.Font = new Font("Rockwell", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Agregar.Location = new Point(191, 350);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(111, 31);
            btn_Agregar.TabIndex = 2;
            btn_Agregar.Text = "AGREGAR";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // FormularioLapicera
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(929, 450);
            Controls.Add(btn_Agregar);
            Controls.Add(dgv_InfoLapiceras);
            Controls.Add(lbl_Lapiceras);
            Font = new Font("Rockwell", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "FormularioLapicera";
            Text = "LAPICERA";
            Load += FormularioLapicera_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_InfoLapiceras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Lapiceras;
        private DataGridView dgv_InfoLapiceras;
        private Button btn_Agregar;
    }
}
