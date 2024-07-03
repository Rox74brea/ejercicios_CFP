namespace FormularioEstudiante
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            lbl_Estudiantes = new Label();
            lbl_Informacion = new Label();
            lst_Estudiantes = new ListBox();
            dgv_Informacion = new DataGridView();
            btn_Agregar = new Button();
            btn_Evaluar = new Button();
            btn_Mostrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Informacion).BeginInit();
            SuspendLayout();
            // 
            // lbl_Estudiantes
            // 
            lbl_Estudiantes.AutoSize = true;
            lbl_Estudiantes.BackColor = Color.FromArgb(255, 128, 0);
            lbl_Estudiantes.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Estudiantes.Location = new Point(12, 42);
            lbl_Estudiantes.Name = "lbl_Estudiantes";
            lbl_Estudiantes.Size = new Size(102, 14);
            lbl_Estudiantes.TabIndex = 0;
            lbl_Estudiantes.Text = "ESTUDIANTES";
            // 
            // lbl_Informacion
            // 
            lbl_Informacion.AutoSize = true;
            lbl_Informacion.BackColor = Color.FromArgb(255, 128, 0);
            lbl_Informacion.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Informacion.Location = new Point(506, 42);
            lbl_Informacion.Name = "lbl_Informacion";
            lbl_Informacion.Size = new Size(107, 14);
            lbl_Informacion.TabIndex = 1;
            lbl_Informacion.Text = "INFORMACION";
            // 
            // lst_Estudiantes
            // 
            lst_Estudiantes.FormattingEnabled = true;
            lst_Estudiantes.ItemHeight = 15;
            lst_Estudiantes.Location = new Point(12, 60);
            lst_Estudiantes.Name = "lst_Estudiantes";
            lst_Estudiantes.Size = new Size(120, 289);
            lst_Estudiantes.TabIndex = 2;
            // 
            // dgv_Informacion
            // 
            dgv_Informacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Informacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Informacion.Location = new Point(172, 60);
            dgv_Informacion.Name = "dgv_Informacion";
            dgv_Informacion.Size = new Size(831, 292);
            dgv_Informacion.TabIndex = 3;
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.FromArgb(255, 128, 0);
            btn_Agregar.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Agregar.ForeColor = SystemColors.ControlText;
            btn_Agregar.Location = new Point(371, 367);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(103, 34);
            btn_Agregar.TabIndex = 4;
            btn_Agregar.Text = "AGREGAR";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // btn_Evaluar
            // 
            btn_Evaluar.BackColor = Color.FromArgb(255, 128, 0);
            btn_Evaluar.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Evaluar.Location = new Point(537, 367);
            btn_Evaluar.Name = "btn_Evaluar";
            btn_Evaluar.Size = new Size(98, 34);
            btn_Evaluar.TabIndex = 5;
            btn_Evaluar.Text = "EVALUAR";
            btn_Evaluar.UseVisualStyleBackColor = false;
            btn_Evaluar.Click += btn_Evaluar_Click;
            // 
            // btn_Mostrar
            // 
            btn_Mostrar.BackColor = Color.FromArgb(255, 128, 0);
            btn_Mostrar.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Mostrar.Location = new Point(715, 367);
            btn_Mostrar.Name = "btn_Mostrar";
            btn_Mostrar.Size = new Size(94, 34);
            btn_Mostrar.TabIndex = 6;
            btn_Mostrar.Text = "MOSTRAR";
            btn_Mostrar.UseVisualStyleBackColor = false;
            btn_Mostrar.Click += btn_Mostrar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1046, 450);
            Controls.Add(btn_Mostrar);
            Controls.Add(btn_Evaluar);
            Controls.Add(btn_Agregar);
            Controls.Add(dgv_Informacion);
            Controls.Add(lst_Estudiantes);
            Controls.Add(lbl_Informacion);
            Controls.Add(lbl_Estudiantes);
            Name = "FormPrincipal";
            Text = "ESTUDIANTE";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Informacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Estudiantes;
        private Label lbl_Informacion;
        private ListBox lst_Estudiantes;
        private DataGridView dgv_Informacion;
        private Button btn_Agregar;
        private Button btn_Evaluar;
        private Button btn_Mostrar;
    }
}
