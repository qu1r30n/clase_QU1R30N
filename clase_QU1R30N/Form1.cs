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
        
        
        public Form1()
        {
            InitializeComponent();
            iniciar_archivos inicio = new iniciar_archivos();
            inicio.iniciar();
        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            principal enl_princ = new principal();
            string info_resultado = null;
            //info_resultado = enl_princ.enlasador("analisis_datos~existe_producto§codigo");
            //0_id_usuario|1_id_pat_comp|2_tabla_pat_comp|3_id_enc_simp|4_tabla_enc_simp|5_puntos_d|6_puntos_d_a_dar|7_datos|8_niveles|9_id_horizontal

            //info_resultado = enl_princ.enlasador("modelo_afiliados~inscribir_simple_cod1§4|afiliados_simple|nom_pru°ap_pat_pru°ape_mat_pru°0°banco°curp°0000000000°direccion°colonia°municiopio°estado°correo@correo.com");
            //info_resultado = enl_princ.enlasador("modelo_afiliados~inscribir_complejo_cod2§4|afiliados_complejo|4|afiliados_simple|nom_pru°ap_pat_pru°ape_mat_pru°0°banco°curp°0000000000°direccion°colonia°municiopio°estado°correo@correo.com");
            info_resultado = enl_princ.enlasador("modelo_afiliados~inscribir_unificado_cod3_r_§4|afiliados_unificado|nom_pru°ap_pat_pru°ape_mat_pru°0╦banco°curp°0000000000°direccion°colonia°municiopio°estado°correo@correo.com");

        }
    }
}
