namespace Primer_Formulario
{
    partial class FormAuto
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
            txt_Nombre = new TextBox();
            txt_Apellido = new TextBox();
            txt_Password = new TextBox();
            lbl_Nombre = new Label();
            lbl_Apellido = new Label();
            lbl_Password = new Label();
            lst_Salida = new ListBox();
            SuspendLayout();
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(203, 85);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(127, 23);
            txt_Nombre.TabIndex = 0;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(203, 145);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(127, 23);
            txt_Apellido.TabIndex = 1;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(203, 213);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(127, 23);
            txt_Password.TabIndex = 2;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(239, 67);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(51, 15);
            lbl_Nombre.TabIndex = 3;
            lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Apellido
            // 
            lbl_Apellido.AutoSize = true;
            lbl_Apellido.Location = new Point(239, 127);
            lbl_Apellido.Name = "lbl_Apellido";
            lbl_Apellido.Size = new Size(51, 15);
            lbl_Apellido.TabIndex = 4;
            lbl_Apellido.Text = "Apellido";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(239, 195);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(57, 15);
            lbl_Password.TabIndex = 5;
            lbl_Password.Text = "Password";
            // 
            // lst_Salida
            // 
            lst_Salida.FormattingEnabled = true;
            lst_Salida.ItemHeight = 15;
            lst_Salida.Location = new Point(368, 50);
            lst_Salida.Name = "lst_Salida";
            lst_Salida.Size = new Size(147, 199);
            lst_Salida.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(492, 259);
            Controls.Add(lst_Salida);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Apellido);
            Controls.Add(lbl_Nombre);
            Controls.Add(txt_Password);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Nombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Nombre;
        private TextBox txt_Apellido;
        private TextBox txt_Password;
        private Label lbl_Nombre;
        private Label lbl_Apellido;
        private Label lbl_Password;
        private ListBox lst_Salida;
        private Button btn_Ingresar;
    }
}
