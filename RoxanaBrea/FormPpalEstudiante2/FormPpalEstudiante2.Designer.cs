namespace FormPpalEstudiante2
{
    partial class FormPpalEstudiante2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPpalEstudiante2));
            lbl_Estudiantes = new Label();
            lbl_Materias = new Label();
            lst_Estudiantes = new ListBox();
            lst_Materias = new ListBox();
            btn_AgregAlum = new Button();
            btn_AgregMateria = new Button();
            SuspendLayout();
            // 
            // lbl_Estudiantes
            // 
            lbl_Estudiantes.AutoSize = true;
            lbl_Estudiantes.BackColor = Color.FromArgb(0, 192, 192);
            lbl_Estudiantes.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Estudiantes.Location = new Point(66, 38);
            lbl_Estudiantes.Name = "lbl_Estudiantes";
            lbl_Estudiantes.Size = new Size(105, 16);
            lbl_Estudiantes.TabIndex = 0;
            lbl_Estudiantes.Text = "ESTUDIANTES";
            // 
            // lbl_Materias
            // 
            lbl_Materias.AutoSize = true;
            lbl_Materias.BackColor = Color.FromArgb(0, 192, 192);
            lbl_Materias.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Materias.Location = new Point(311, 38);
            lbl_Materias.Name = "lbl_Materias";
            lbl_Materias.Size = new Size(80, 16);
            lbl_Materias.TabIndex = 1;
            lbl_Materias.Text = "MATERIAS";
            // 
            // lst_Estudiantes
            // 
            lst_Estudiantes.BackColor = Color.FromArgb(255, 192, 192);
            lst_Estudiantes.FormattingEnabled = true;
            lst_Estudiantes.ItemHeight = 13;
            lst_Estudiantes.Location = new Point(26, 57);
            lst_Estudiantes.Name = "lst_Estudiantes";
            lst_Estudiantes.Size = new Size(181, 303);
            lst_Estudiantes.TabIndex = 2;
            // 
            // lst_Materias
            // 
            lst_Materias.BackColor = Color.FromArgb(255, 192, 192);
            lst_Materias.FormattingEnabled = true;
            lst_Materias.ItemHeight = 13;
            lst_Materias.Location = new Point(258, 57);
            lst_Materias.Name = "lst_Materias";
            lst_Materias.Size = new Size(184, 303);
            lst_Materias.TabIndex = 3;
            // 
            // btn_AgregAlum
            // 
            btn_AgregAlum.BackColor = Color.FromArgb(255, 128, 128);
            btn_AgregAlum.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AgregAlum.Location = new Point(26, 382);
            btn_AgregAlum.Name = "btn_AgregAlum";
            btn_AgregAlum.Size = new Size(181, 23);
            btn_AgregAlum.TabIndex = 4;
            btn_AgregAlum.Text = "AGREGAR ALUMNO";
            btn_AgregAlum.UseVisualStyleBackColor = false;
            btn_AgregAlum.Click += button1_Click;
            // 
            // btn_AgregMateria
            // 
            btn_AgregMateria.BackColor = Color.FromArgb(255, 128, 128);
            btn_AgregMateria.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AgregMateria.Location = new Point(258, 382);
            btn_AgregMateria.Name = "btn_AgregMateria";
            btn_AgregMateria.Size = new Size(184, 23);
            btn_AgregMateria.TabIndex = 5;
            btn_AgregMateria.Text = "AGREGAR MATERIA";
            btn_AgregMateria.UseVisualStyleBackColor = false;
            // 
            // FormPpalEstudiante2
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(851, 483);
            Controls.Add(btn_AgregMateria);
            Controls.Add(btn_AgregAlum);
            Controls.Add(lst_Materias);
            Controls.Add(lst_Estudiantes);
            Controls.Add(lbl_Materias);
            Controls.Add(lbl_Estudiantes);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Name = "FormPpalEstudiante2";
            Text = "ESTUDIANTES";
            Load += FormPpalEstudiante2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Estudiantes;
        private Label lbl_Materias;
        private ListBox lst_Estudiantes;
        private ListBox lst_Materias;
        private Button btn_AgregAlum;
        private Button btn_AgregMateria;
    }
}
