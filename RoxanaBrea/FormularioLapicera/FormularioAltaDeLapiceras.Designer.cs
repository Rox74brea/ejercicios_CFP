namespace FormularioLapicera
{
    partial class FormularioAltaDeLapiceras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioAltaDeLapiceras));
            lbl_IngrLapicera = new Label();
            btn_Agregar = new Button();
            btn_Cancelar = new Button();
            gpb_Color = new GroupBox();
            rdb_Verde = new RadioButton();
            rdb_Rojo = new RadioButton();
            rdb_Negro = new RadioButton();
            rdb_Azul = new RadioButton();
            lbl_Marca = new Label();
            lbl_Precio = new Label();
            txt_Precio = new TextBox();
            lbl_NivelTinta = new Label();
            numUD_NivelTinta = new NumericUpDown();
            prb_NivelTinta = new ProgressBar();
            lbl_SignoPesos = new Label();
            ptb_ImagenLapicera = new PictureBox();
            cmb_Marcas = new ComboBox();
            lbl_VerNivelDeTinta = new Label();
            gpb_Color.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUD_NivelTinta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_ImagenLapicera).BeginInit();
            SuspendLayout();
            // 
            // lbl_IngrLapicera
            // 
            lbl_IngrLapicera.AutoSize = true;
            lbl_IngrLapicera.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_IngrLapicera.Location = new Point(205, 68);
            lbl_IngrLapicera.Name = "lbl_IngrLapicera";
            lbl_IngrLapicera.Size = new Size(249, 23);
            lbl_IngrLapicera.TabIndex = 0;
            lbl_IngrLapicera.Text = "INGRESO DE LAPICERAS";
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.PaleGreen;
            btn_Agregar.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Agregar.Location = new Point(140, 392);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(130, 34);
            btn_Agregar.TabIndex = 1;
            btn_Agregar.Text = "AGREGAR";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.Coral;
            btn_Cancelar.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cancelar.Location = new Point(393, 392);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(128, 34);
            btn_Cancelar.TabIndex = 2;
            btn_Cancelar.Text = "CANCELAR";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // gpb_Color
            // 
            gpb_Color.Controls.Add(rdb_Verde);
            gpb_Color.Controls.Add(rdb_Rojo);
            gpb_Color.Controls.Add(rdb_Negro);
            gpb_Color.Controls.Add(rdb_Azul);
            gpb_Color.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpb_Color.Location = new Point(327, 175);
            gpb_Color.Name = "gpb_Color";
            gpb_Color.Size = new Size(194, 86);
            gpb_Color.TabIndex = 3;
            gpb_Color.TabStop = false;
            gpb_Color.Text = "COLOR";
            // 
            // rdb_Verde
            // 
            rdb_Verde.AutoSize = true;
            rdb_Verde.Location = new Point(111, 49);
            rdb_Verde.Name = "rdb_Verde";
            rdb_Verde.Size = new Size(68, 18);
            rdb_Verde.TabIndex = 3;
            rdb_Verde.TabStop = true;
            rdb_Verde.Text = "VERDE";
            rdb_Verde.UseVisualStyleBackColor = true;
            // 
            // rdb_Rojo
            // 
            rdb_Rojo.AutoSize = true;
            rdb_Rojo.Location = new Point(110, 24);
            rdb_Rojo.Name = "rdb_Rojo";
            rdb_Rojo.Size = new Size(59, 18);
            rdb_Rojo.TabIndex = 2;
            rdb_Rojo.TabStop = true;
            rdb_Rojo.Text = "ROJO";
            rdb_Rojo.UseVisualStyleBackColor = true;
            // 
            // rdb_Negro
            // 
            rdb_Negro.AutoSize = true;
            rdb_Negro.Location = new Point(6, 47);
            rdb_Negro.Name = "rdb_Negro";
            rdb_Negro.Size = new Size(72, 18);
            rdb_Negro.TabIndex = 1;
            rdb_Negro.TabStop = true;
            rdb_Negro.Text = "NEGRO";
            rdb_Negro.UseVisualStyleBackColor = true;
            // 
            // rdb_Azul
            // 
            rdb_Azul.AutoSize = true;
            rdb_Azul.Location = new Point(6, 22);
            rdb_Azul.Name = "rdb_Azul";
            rdb_Azul.Size = new Size(57, 18);
            rdb_Azul.TabIndex = 0;
            rdb_Azul.TabStop = true;
            rdb_Azul.Text = "AZUL";
            rdb_Azul.UseVisualStyleBackColor = true;
            // 
            // lbl_Marca
            // 
            lbl_Marca.AutoSize = true;
            lbl_Marca.Font = new Font("Rockwell", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Marca.Location = new Point(136, 166);
            lbl_Marca.Name = "lbl_Marca";
            lbl_Marca.Size = new Size(58, 15);
            lbl_Marca.TabIndex = 5;
            lbl_Marca.Text = "MARCA";
            // 
            // lbl_Precio
            // 
            lbl_Precio.AutoSize = true;
            lbl_Precio.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Precio.Location = new Point(136, 224);
            lbl_Precio.Name = "lbl_Precio";
            lbl_Precio.Size = new Size(56, 14);
            lbl_Precio.TabIndex = 6;
            lbl_Precio.Text = "PRECIO";
            // 
            // txt_Precio
            // 
            txt_Precio.Location = new Point(180, 242);
            txt_Precio.Name = "txt_Precio";
            txt_Precio.PlaceholderText = "Ingese el precio";
            txt_Precio.Size = new Size(99, 23);
            txt_Precio.TabIndex = 8;
            // 
            // lbl_NivelTinta
            // 
            lbl_NivelTinta.AutoSize = true;
            lbl_NivelTinta.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_NivelTinta.Location = new Point(136, 286);
            lbl_NivelTinta.Name = "lbl_NivelTinta";
            lbl_NivelTinta.Size = new Size(109, 14);
            lbl_NivelTinta.TabIndex = 9;
            lbl_NivelTinta.Text = "NIVEL DE TINTA";
            // 
            // numUD_NivelTinta
            // 
            numUD_NivelTinta.Location = new Point(135, 304);
            numUD_NivelTinta.Name = "numUD_NivelTinta";
            numUD_NivelTinta.Size = new Size(144, 23);
            numUD_NivelTinta.TabIndex = 10;
            numUD_NivelTinta.ValueChanged += numUD_NivelTinta_ValueChanged;
            // 
            // prb_NivelTinta
            // 
            prb_NivelTinta.Location = new Point(327, 304);
            prb_NivelTinta.Name = "prb_NivelTinta";
            prb_NivelTinta.Size = new Size(193, 23);
            prb_NivelTinta.Step = 1;
            prb_NivelTinta.TabIndex = 11;
            // 
            // lbl_SignoPesos
            // 
            lbl_SignoPesos.AutoSize = true;
            lbl_SignoPesos.Font = new Font("Rockwell", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_SignoPesos.Location = new Point(110, 243);
            lbl_SignoPesos.Name = "lbl_SignoPesos";
            lbl_SignoPesos.Size = new Size(64, 18);
            lbl_SignoPesos.TabIndex = 12;
            lbl_SignoPesos.Text = "         $   ";
            // 
            // ptb_ImagenLapicera
            // 
            ptb_ImagenLapicera.BackgroundImage = (Image)resources.GetObject("ptb_ImagenLapicera.BackgroundImage");
            ptb_ImagenLapicera.Image = (Image)resources.GetObject("ptb_ImagenLapicera.Image");
            ptb_ImagenLapicera.Location = new Point(604, 149);
            ptb_ImagenLapicera.Name = "ptb_ImagenLapicera";
            ptb_ImagenLapicera.Size = new Size(189, 196);
            ptb_ImagenLapicera.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_ImagenLapicera.TabIndex = 13;
            ptb_ImagenLapicera.TabStop = false;
            // 
            // cmb_Marcas
            // 
            cmb_Marcas.FormattingEnabled = true;
            cmb_Marcas.Location = new Point(140, 191);
            cmb_Marcas.Name = "cmb_Marcas";
            cmb_Marcas.Size = new Size(139, 23);
            cmb_Marcas.TabIndex = 14;
          
            // 
            // lbl_VerNivelDeTinta
            // 
            lbl_VerNivelDeTinta.AutoSize = true;
            lbl_VerNivelDeTinta.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_VerNivelDeTinta.Location = new Point(327, 287);
            lbl_VerNivelDeTinta.Name = "lbl_VerNivelDeTinta";
            lbl_VerNivelDeTinta.Size = new Size(70, 14);
            lbl_VerNivelDeTinta.TabIndex = 15;
            lbl_VerNivelDeTinta.Text = "% de Tinta";
            // 
            // FormularioAltaDeLapiceras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 505);
            Controls.Add(lbl_VerNivelDeTinta);
            Controls.Add(cmb_Marcas);
            Controls.Add(ptb_ImagenLapicera);
            Controls.Add(lbl_SignoPesos);
            Controls.Add(prb_NivelTinta);
            Controls.Add(numUD_NivelTinta);
            Controls.Add(lbl_NivelTinta);
            Controls.Add(txt_Precio);
            Controls.Add(lbl_Precio);
            Controls.Add(lbl_Marca);
            Controls.Add(gpb_Color);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Agregar);
            Controls.Add(lbl_IngrLapicera);
            Name = "FormularioAltaDeLapiceras";
            Text = "AltaDeLapiceras";
            Load += AltaDeLapiceras_Load;
            gpb_Color.ResumeLayout(false);
            gpb_Color.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUD_NivelTinta).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_ImagenLapicera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_IngrLapicera;
        private Button btn_Agregar;
        private Button btn_Cancelar;
        private GroupBox gpb_Color;
        private RadioButton rdb_Verde;
        private RadioButton rdb_Rojo;
        private RadioButton rdb_Negro;
        private RadioButton rdb_Azul;
        private Label lbl_Marca;
        private Label lbl_Precio;
        private TextBox txt_Precio;
        private Label lbl_NivelTinta;
        private NumericUpDown numUD_NivelTinta;
        private ProgressBar prb_NivelTinta;
        private Label lbl_SignoPesos;
        private PictureBox ptb_ImagenLapicera;
        private ComboBox cmb_Marcas;
        private Label lbl_VerNivelDeTinta;
    }
}