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
            //info_resultado = enl_princ.enlasador("modelo_afiliados~inscribir_unificado_cod3_r_§4|afiliados_unificado|0_nom_pru°1_ap_pat_pru°2_ape_mat_pru°0╦banco°4_curp°5_clav_elector°6_otra_id_identificacion°7_0000000000°8_direccion°9_colonia°10_municiopio°11_estado°12_correo@correo.com");
            //info_resultado = enl_princ.enlasador("modelo_empleados~registro_empleado§Nombre|Apellido_paterno|Apellido_materno|Fecha_de_nacimiento|Género|Dirección|Ciudad|Estado_Provincia|Código_postal|País|Correo_electrónico|Teléfono|Fecha_de_ingreso|donaciones_de_puntos_d|Cargo|Estado_de_aprendis_de_empleado|Supervisor|Notas|Afiliado|Fecha_de_terminación|Motivo_de_terminación|Horas_del_curso_por_dia|Evaluaciones_de_desempeño|Habilidades_y_certificaciones|Idiomas|Fecha_de_última_promoción|ID_del_departamento_de_supervisión|Historial_de_capacitación|Último_aumento_de_puntos_d|tipo_de_aprendis_de_empleado");
            info_resultado = enl_princ.enlasador("modelo_compras~compra§codigo|1|2");

        }
    }
}
