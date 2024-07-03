namespace FormularioEstudiante
{
    partial class FormAltas
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
            btn_Aceptar = new Button();
            btn_Cancelar = new Button();
            lbl_Legajo = new Label();
            lbl_Nombre = new Label();
            lbl_Apellido = new Label();
            txt_Legajo = new TextBox();
            txt_Nombre = new TextBox();
            txt_Apellido = new TextBox();
            SuspendLayout();
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.BackColor = Color.FromArgb(255, 192, 128);
            btn_Aceptar.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Aceptar.Location = new Point(71, 271);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(88, 23);
            btn_Aceptar.TabIndex = 0;
            btn_Aceptar.Text = "ACEPTAR";
            btn_Aceptar.UseVisualStyleBackColor = false;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.FromArgb(128, 255, 128);
            btn_Cancelar.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cancelar.Location = new Point(237, 271);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(86, 23);
            btn_Cancelar.TabIndex = 1;
            btn_Cancelar.Text = "CANCELAR";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // lbl_Legajo
            // 
            lbl_Legajo.AutoSize = true;
            lbl_Legajo.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Legajo.Location = new Point(31, 52);
            lbl_Legajo.Name = "lbl_Legajo";
            lbl_Legajo.Size = new Size(52, 14);
            lbl_Legajo.TabIndex = 2;
            lbl_Legajo.Text = "Legajo";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Nombre.Location = new Point(31, 86);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(59, 14);
            lbl_Nombre.TabIndex = 3;
            lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Apellido
            // 
            lbl_Apellido.AutoSize = true;
            lbl_Apellido.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Apellido.Location = new Point(31, 127);
            lbl_Apellido.Name = "lbl_Apellido";
            lbl_Apellido.Size = new Size(60, 14);
            lbl_Apellido.TabIndex = 4;
            lbl_Apellido.Text = "Apellido";
            // 
            // txt_Legajo
            // 
            txt_Legajo.Location = new Point(109, 49);
            txt_Legajo.Name = "txt_Legajo";
            txt_Legajo.Size = new Size(256, 23);
            txt_Legajo.TabIndex = 5;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(109, 86);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(256, 23);
            txt_Nombre.TabIndex = 6;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(109, 124);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(256, 23);
            txt_Apellido.TabIndex = 7;
            // 
            // FormAltas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(416, 450);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Nombre);
            Controls.Add(txt_Legajo);
            Controls.Add(lbl_Apellido);
            Controls.Add(lbl_Nombre);
            Controls.Add(lbl_Legajo);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Aceptar);
            Name = "FormAltas";
            Text = "ALTAS ESTUDIANTES";
            Load += FormAltas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Aceptar;
        private Button btn_Cancelar;
        private Label lbl_Legajo;
        private Label lbl_Nombre;
        private Label lbl_Apellido;
        private TextBox txt_Legajo;
        private TextBox txt_Nombre;
        private TextBox txt_Apellido;
    }
}