namespace FormIngresante
{
    partial class FormAlta
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
            gpb_Ingresante = new GroupBox();
            num_Edad = new NumericUpDown();
            txt_Apellido = new TextBox();
            txt_Nombre = new TextBox();
            lbl_Edad = new Label();
            lbl_Apellido = new Label();
            lbl_Nombre = new Label();
            gpb_Genero = new GroupBox();
            rdb_NoBinario = new RadioButton();
            rdb_Femenino = new RadioButton();
            rdb_Masculino = new RadioButton();
            gpb_Cursos = new GroupBox();
            chk_Angular = new CheckBox();
            chk_Node = new CheckBox();
            chk_JavaScript = new CheckBox();
            chk_Phyton = new CheckBox();
            chk_CSharp = new CheckBox();
            lst_Paises = new ListBox();
            btn_Agregar = new Button();
            btn_Cancelar = new Button();
            lbl_Ingresante = new Label();
            lbl_ListaPaises = new Label();
            lbl_Genero = new Label();
            lbl_Cursos = new Label();
            gpb_Ingresante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_Edad).BeginInit();
            gpb_Genero.SuspendLayout();
            gpb_Cursos.SuspendLayout();
            SuspendLayout();
            // 
            // gpb_Ingresante
            // 
            gpb_Ingresante.Controls.Add(num_Edad);
            gpb_Ingresante.Controls.Add(txt_Apellido);
            gpb_Ingresante.Controls.Add(txt_Nombre);
            gpb_Ingresante.Controls.Add(lbl_Edad);
            gpb_Ingresante.Controls.Add(lbl_Apellido);
            gpb_Ingresante.Controls.Add(lbl_Nombre);
            gpb_Ingresante.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpb_Ingresante.Location = new Point(30, 26);
            gpb_Ingresante.Name = "gpb_Ingresante";
            gpb_Ingresante.Size = new Size(314, 159);
            gpb_Ingresante.TabIndex = 1;
            gpb_Ingresante.TabStop = false;
            gpb_Ingresante.Text = "Datos Personales";
            // 
            // num_Edad
            // 
            num_Edad.Location = new Point(100, 97);
            num_Edad.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            num_Edad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_Edad.Name = "num_Edad";
            num_Edad.Size = new Size(183, 22);
            num_Edad.TabIndex = 4;
            num_Edad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(102, 60);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.PlaceholderText = "Ingrese su apellido";
            txt_Apellido.Size = new Size(181, 22);
            txt_Apellido.TabIndex = 3;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(103, 23);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.PlaceholderText = "Ingrese su nombre";
            txt_Nombre.Size = new Size(180, 22);
            txt_Nombre.TabIndex = 2;
            // 
            // lbl_Edad
            // 
            lbl_Edad.AutoSize = true;
            lbl_Edad.Location = new Point(11, 105);
            lbl_Edad.Name = "lbl_Edad";
            lbl_Edad.Size = new Size(44, 14);
            lbl_Edad.TabIndex = 2;
            lbl_Edad.Text = "EDAD";
            // 
            // lbl_Apellido
            // 
            lbl_Apellido.AutoSize = true;
            lbl_Apellido.Location = new Point(11, 65);
            lbl_Apellido.Name = "lbl_Apellido";
            lbl_Apellido.Size = new Size(76, 14);
            lbl_Apellido.TabIndex = 1;
            lbl_Apellido.Text = "APELLIDO";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(11, 26);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(65, 14);
            lbl_Nombre.TabIndex = 0;
            lbl_Nombre.Text = "NOMBRE";
            // 
            // gpb_Genero
            // 
            gpb_Genero.Controls.Add(rdb_NoBinario);
            gpb_Genero.Controls.Add(rdb_Femenino);
            gpb_Genero.Controls.Add(rdb_Masculino);
            gpb_Genero.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpb_Genero.Location = new Point(468, 26);
            gpb_Genero.Name = "gpb_Genero";
            gpb_Genero.Size = new Size(187, 159);
            gpb_Genero.TabIndex = 6;
            gpb_Genero.TabStop = false;
            gpb_Genero.Text = "Genero";
            // 
            // rdb_NoBinario
            // 
            rdb_NoBinario.AutoSize = true;
            rdb_NoBinario.Location = new Point(24, 100);
            rdb_NoBinario.Name = "rdb_NoBinario";
            rdb_NoBinario.Size = new Size(110, 18);
            rdb_NoBinario.TabIndex = 9;
            rdb_NoBinario.TabStop = true;
            rdb_NoBinario.Text = "NO BINARIO";
            rdb_NoBinario.UseVisualStyleBackColor = true;
            // 
            // rdb_Femenino
            // 
            rdb_Femenino.AutoSize = true;
            rdb_Femenino.Location = new Point(24, 61);
            rdb_Femenino.Name = "rdb_Femenino";
            rdb_Femenino.Size = new Size(97, 18);
            rdb_Femenino.TabIndex = 8;
            rdb_Femenino.TabStop = true;
            rdb_Femenino.Text = "FEMENINO";
            rdb_Femenino.UseVisualStyleBackColor = true;
            // 
            // rdb_Masculino
            // 
            rdb_Masculino.AutoSize = true;
            rdb_Masculino.Location = new Point(24, 26);
            rdb_Masculino.Name = "rdb_Masculino";
            rdb_Masculino.Size = new Size(108, 18);
            rdb_Masculino.TabIndex = 7;
            rdb_Masculino.TabStop = true;
            rdb_Masculino.Text = "MASCULINO";
            rdb_Masculino.UseVisualStyleBackColor = true;
            // 
            // gpb_Cursos
            // 
            gpb_Cursos.Controls.Add(chk_Angular);
            gpb_Cursos.Controls.Add(chk_Node);
            gpb_Cursos.Controls.Add(chk_JavaScript);
            gpb_Cursos.Controls.Add(chk_Phyton);
            gpb_Cursos.Controls.Add(chk_CSharp);
            gpb_Cursos.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpb_Cursos.Location = new Point(468, 232);
            gpb_Cursos.Name = "gpb_Cursos";
            gpb_Cursos.Size = new Size(187, 154);
            gpb_Cursos.TabIndex = 10;
            gpb_Cursos.TabStop = false;
            gpb_Cursos.Text = "Cursos";
            // 
            // chk_Angular
            // 
            chk_Angular.AutoSize = true;
            chk_Angular.Location = new Point(9, 116);
            chk_Angular.Name = "chk_Angular";
            chk_Angular.Size = new Size(91, 18);
            chk_Angular.TabIndex = 15;
            chk_Angular.Text = "ANGULAR";
            chk_Angular.UseVisualStyleBackColor = true;
            // 
            // chk_Node
            // 
            chk_Node.AutoSize = true;
            chk_Node.Location = new Point(9, 95);
            chk_Node.Name = "chk_Node";
            chk_Node.Size = new Size(65, 18);
            chk_Node.TabIndex = 14;
            chk_Node.Text = "NODE";
            chk_Node.UseVisualStyleBackColor = true;
            // 
            // chk_JavaScript
            // 
            chk_JavaScript.AutoSize = true;
            chk_JavaScript.Location = new Point(9, 70);
            chk_JavaScript.Name = "chk_JavaScript";
            chk_JavaScript.Size = new Size(110, 18);
            chk_JavaScript.TabIndex = 13;
            chk_JavaScript.Text = "JAVASCRIPT";
            chk_JavaScript.UseVisualStyleBackColor = true;
            // 
            // chk_Phyton
            // 
            chk_Phyton.AutoSize = true;
            chk_Phyton.Location = new Point(10, 47);
            chk_Phyton.Name = "chk_Phyton";
            chk_Phyton.Size = new Size(84, 18);
            chk_Phyton.TabIndex = 12;
            chk_Phyton.Text = "PHYTON";
            chk_Phyton.UseVisualStyleBackColor = true;
            // 
            // chk_CSharp
            // 
            chk_CSharp.AutoSize = true;
            chk_CSharp.Location = new Point(10, 24);
            chk_CSharp.Name = "chk_CSharp";
            chk_CSharp.Size = new Size(49, 18);
            chk_CSharp.TabIndex = 11;
            chk_CSharp.Text = "C #";
            chk_CSharp.UseVisualStyleBackColor = true;
            // 
            // lst_Paises
            // 
            lst_Paises.FormattingEnabled = true;
            lst_Paises.ItemHeight = 15;
            lst_Paises.Location = new Point(30, 232);
            lst_Paises.Name = "lst_Paises";
            lst_Paises.Size = new Size(314, 154);
            lst_Paises.TabIndex = 5;
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.LightSalmon;
            btn_Agregar.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Agregar.Location = new Point(175, 408);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(112, 30);
            btn_Agregar.TabIndex = 16;
            btn_Agregar.Text = "AGREGAR";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.LightSalmon;
            btn_Cancelar.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cancelar.Location = new Point(414, 408);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(106, 30);
            btn_Cancelar.TabIndex = 17;
            btn_Cancelar.Text = "CANCELAR";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // lbl_Ingresante
            // 
            lbl_Ingresante.AutoSize = true;
            lbl_Ingresante.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Ingresante.Location = new Point(30, 8);
            lbl_Ingresante.Name = "lbl_Ingresante";
            lbl_Ingresante.Size = new Size(94, 14);
            lbl_Ingresante.TabIndex = 6;
            lbl_Ingresante.Text = "INGRESANTE";
            // 
            // lbl_ListaPaises
            // 
            lbl_ListaPaises.AutoSize = true;
            lbl_ListaPaises.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ListaPaises.Location = new Point(30, 214);
            lbl_ListaPaises.Name = "lbl_ListaPaises";
            lbl_ListaPaises.Size = new Size(40, 14);
            lbl_ListaPaises.TabIndex = 7;
            lbl_ListaPaises.Text = "PAIS";
            // 
            // lbl_Genero
            // 
            lbl_Genero.AutoSize = true;
            lbl_Genero.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Genero.Location = new Point(468, 9);
            lbl_Genero.Name = "lbl_Genero";
            lbl_Genero.Size = new Size(63, 14);
            lbl_Genero.TabIndex = 8;
            lbl_Genero.Text = "GENERO";
            // 
            // lbl_Cursos
            // 
            lbl_Cursos.AutoSize = true;
            lbl_Cursos.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Cursos.Location = new Point(468, 214);
            lbl_Cursos.Name = "lbl_Cursos";
            lbl_Cursos.Size = new Size(64, 14);
            lbl_Cursos.TabIndex = 9;
            lbl_Cursos.Text = "CURSOS";
            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(714, 450);
            Controls.Add(lbl_Cursos);
            Controls.Add(lbl_Genero);
            Controls.Add(lbl_ListaPaises);
            Controls.Add(lbl_Ingresante);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Agregar);
            Controls.Add(lst_Paises);
            Controls.Add(gpb_Cursos);
            Controls.Add(gpb_Genero);
            Controls.Add(gpb_Ingresante);
            Name = "FormAlta";
            Text = "ALTA DE INGRESANTES";
            Load += FormAlta_Load;
            gpb_Ingresante.ResumeLayout(false);
            gpb_Ingresante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_Edad).EndInit();
            gpb_Genero.ResumeLayout(false);
            gpb_Genero.PerformLayout();
            gpb_Cursos.ResumeLayout(false);
            gpb_Cursos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpb_Ingresante;
        private GroupBox gpb_Genero;
        private GroupBox gpb_Cursos;
        private ListBox lst_Paises;
        private Button btn_Agregar;
        private Button btn_Cancelar;
        private TextBox txt_Apellido;
        private TextBox txt_Nombre;
        private Label lbl_Edad;
        private Label lbl_Apellido;
        private Label lbl_Nombre;
        private Label lbl_Ingresante;
        private Label lbl_ListaPaises;
        private Label lbl_Genero;
        private Label lbl_Cursos;
        private NumericUpDown num_Edad;
        private RadioButton rdb_NoBinario;
        private RadioButton rdb_Femenino;
        private RadioButton rdb_Masculino;
        private CheckBox chk_Angular;
        private CheckBox chk_Node;
        private CheckBox chk_JavaScript;
        private CheckBox chk_Phyton;
        private CheckBox chk_CSharp;
    }
}