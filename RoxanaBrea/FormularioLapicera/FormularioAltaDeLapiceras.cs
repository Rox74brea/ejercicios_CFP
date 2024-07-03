
using ClaseLapicera;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormularioLapicera
{
    public partial class FormularioAltaDeLapiceras : Form
    {
        Lapicera lapicera;

        public FormularioAltaDeLapiceras()
        {
            InitializeComponent();
        }

        public Lapicera Lapicera { get => lapicera; }


        private void AltaDeLapiceras_Load(object sender, EventArgs e)
        {
            this.cmb_Marcas.DataSource = Lapicera.ListadoDeMarcas();
        }


        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            string color = gpb_Color.Text;
            double precio = double.Parse(txt_Precio.Text);
            string marca = cmb_Marcas.Text;
            int nivelDeTinta = (int)numUD_NivelTinta.Value;

            int nivelDeTinta_Ingresado = 0;
            if (nivelDeTinta != 100)
            {
                nivelDeTinta_Ingresado = (int)numUD_NivelTinta.Value;
                nivelDeTinta = nivelDeTinta_Ingresado;
            }

            foreach (RadioButton colorElegido in gpb_Color.Controls)
            {
                if (colorElegido.Checked == true)
                {
                    color = colorElegido.Text;
                    break;
                }
            }

            lapicera = new Lapicera(color, precio, marca, nivelDeTinta); 
            DialogResult = DialogResult.OK;

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void numUD_NivelTinta_ValueChanged(object sender, EventArgs e)
        {
            prb_NivelTinta.Value = (int)numUD_NivelTinta.Value;
        }




        
        

       
    }
}
