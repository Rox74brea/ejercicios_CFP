namespace FormIngresante
{
    partial class FormIngresante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngresante));
            btn_Agregar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.LightSkyBlue;
            btn_Agregar.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Agregar.Location = new Point(347, 314);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(179, 28);
            btn_Agregar.TabIndex = 0;
            btn_Agregar.Text = "AGREGAR";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightCyan;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(810, 196);
            dataGridView1.TabIndex = 1;
            // 
            // FormIngresante
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 420);
            Controls.Add(dataGridView1);
            Controls.Add(btn_Agregar);
            Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "FormIngresante";
            Text = "LISTADO DE INGRESANTES";
            TransparencyKey = Color.Transparent;
            Load += FormIngresante_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Agregar;
        private DataGridView dataGridView1;
    }
}
