using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using clase_QU1R30N.sin_internet.sin_formularios;

namespace clase_QU1R30N
{
    public partial class Form1 : Form
    {
        principal enl_princ = new principal();
        public Form1()
        {
            InitializeComponent();
            iniciar_archivos inicio = new iniciar_archivos();
            inicio.iniciar();
        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {

            enl_princ.enlasador("analisis_datos~existe_producto§codigo");

        }
    }
}
