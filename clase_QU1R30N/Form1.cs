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
        iniciar_archivos inicio = new iniciar_archivos();

        public Form1()
        {
            InitializeComponent();
            inicio.iniciar();
        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            principal enl_princ = new principal();
            string info_resultado = null;
            //info_resultado = enl_princ.enlasador("analisis_datos~existe_producto§codigo");
            //0_id_usuario|1_id_pat_comp|2_tabla_pat_comp|3_id_enc_simp|4_tabla_enc_simp|5_puntos_d|6_puntos_d_a_dar|7_datos|8_niveles|9_id_horizontal

            //inscribir afiliado simple
            //info_resultado = enl_princ.enlasador("MODELO_AFILIADOS~INSCRIBIR_SIMPLE_COD1§4|AFILIADOS_SIMPLE|NOM_PRU°AP_PAT_PRU°APE_MAT_PRU°0°BANCO°CURP°0000000000°DIRECCION°COLONIA°MUNICIOPIO°ESTADO°CORREO@CORREO.COM");
            //inscribir afiliado complejo
            //info_resultado = enl_princ.enlasador("MODELO_AFILIADOS~INSCRIBIR_COMPLEJO_COD2§4|AFILIADOS_COMPLEJO|4|AFILIADOS_SIMPLE|NOM_PRU°AP_PAT_PRU°APE_MAT_PRU°0°BANCO°CURP°0000000000°DIRECCION°COLONIA°MUNICIOPIO°ESTADO°CORREO@CORREO.COM");
            //inscribir afiliado unificado
            //info_resultado = enl_princ.enlasador("MODELO_AFILIADOS~INSCRIBIR_UNIFICADO_COD3_R_§4|AFILIADOS_UNIFICADO|0_NOM_PRU°1_AP_PAT_PRU°2_APE_MAT_PRU°0╦BANCO°4_CURP°5_CLAV_ELECTOR°6_OTRA_ID_IDENTIFICACION°7_0000000000°8_DIRECCION°9_COLONIA°10_MUNICIOPIO°11_ESTADO°12_CORREO@CORREO.COM");

            //info_resultado = enl_princ.enlasador("MODELO_APRENDICES_E~REGISTRO_APRENDICES_E§NOMBRE|APELLIDO_PATERNO|APELLIDO_MATERNO|FECHA_DE_NACIMIENTO|GÉNERO|DIRECCIÓN|CIUDAD|ESTADO_PROVINCIA|CÓDIGO_POSTAL|PAÍS|CORREO_ELECTRÓNICO|TELÉFONO|FECHA_DE_INGRESO|DONACIONES_DE_PUNTOS_D|CARGO|ESTADO_DE_APRENDIS_DE_APRENDIS_E|SUPERVISOR|NOTAS|AFILIADO|FECHA_DE_TERMINACIÓN|MOTIVO_DE_TERMINACIÓN|HORAS_DEL_CURSO_POR_DIA|EVALUACIONES_DE_DESEMPEÑO|HABILIDADES_Y_CERTIFICACIONES|IDIOMAS|FECHA_DE_ÚLTIMA_PROMOCIÓN|ID_DEL_DEPARTAMENTO_DE_SUPERVISIÓN|HISTORIAL_DE_CAPACITACIÓN|ÚLTIMO_AUMENTO_DE_PUNTOS_D|TIPO_DE_APRENDIS_DE_EMPLEADO");
            //info_resultado = enl_princ.enlasador("MODELO_COMPRAS~COMPRA§COD_BAR4|1|200|PROVEDOR3|NOM_PRODUCTO_SI_NO_ESTA|SUC_9");
            info_resultado = enl_princ.enlasador("MODELO_VENTAS~VENTA§COD_BAR|1|PLATAFORMA1|4");
        }
    }
}
