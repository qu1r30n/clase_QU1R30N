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
using clase_QU1R30N.sin_internet.con_formularios.tienda;
using clase_QU1R30N.con_internet.herramientas_internet;
using System.Threading;

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
            info_resultado = enl_princ.enlasador("MODELO_VENTAS~VENTA§COD_BAR¬1¬PLATAFORMA1╝4¬VENTAS°COD_BAR1¬1¬PLATAFORMA1╝4¬VENTAS°COD_BAR¬3¬PLATAFORMA1╝4¬VENTAS");
            //info_resultado = enl_princ.enlasador("MODELO_SUCURSALES~REGISTRAR_SUCURSAL§_1_NOMBRE_SUCUR|_2_NOMBRE_ENCARGADO|_3_DIRECCIÓN_SUCUR|_4_CIUDAD_SUCUR|_5_ESTADO_SUCUR|_6_CÓDIGO_POSTAL|_7_PAÍS|_8_CORREO_ELECTRÓNICO|0000000000|1111111111|_11_TIPO_DE_SUCUR|_12_PRODUCTOS_SERVICIOS_SUMINISTRADOS|99999999999999999999|_14_UBICACIÓN_(GPS)|_15_NOTAS|_16_RECORDATORIO|ACTIVO|1000°2300|");
            //info_resultado = enl_princ.enlasador("MODELO_PROVEDORES~REGISTRO_PROVEDOR§EJEMPLO_1_NOMBRE_EMPRESA|EJEMPLO_2_NOMBRE_ENCARGADO|EJEMPLO_3_DIRECCIÓN_EMPRESA|EJEMPLO_4_CIUDAD_EMPRESA|EJEMPLO_5_ESTADO_EMPRESA|EJEMPLO_6_CÓDIGO_POSTAL|EJEMPLO_7_PAÍS|EJEMPLO_8_CORREO_ELECTRÓNICO|EJEMPLO_9_TELÉFONO_ENCARGADO|EJEMPLO_10_TELEFONO_EMPRESA|EJEMPLO_11_TIPO_DE_PROVEEDOR|EJEMPLO_12_PRODUCTOS_SERVICIOS_SUMINISTRADOS|EJEMPLO_13_CUENTA_BANCO|EJEMPLO_14_UBICACIÓN_(GPS)|EJEMPLO_15_NOTAS|EJEMPLO_16_RECORDATORIO|EJEMPLO_17_ACTIVO_O_NO_ACTIVO|EJEMPLO_18_CALIFICACION_PREVENTA¬0°CALIFICACION_ENTREGA¬0|EJEMPLO_19_COMENTARIOS_PREVENTA_ENTREGA|EJEMPLO_20_SUCURSALES_QUE_LE_COMPRAN|EJEMPLO_21_DINERO_A_COMPRARLE|EJEMPLO_22_DIAS_DE_PREVENTA_0°DIAS_DE_PREVENTA_1|EJEMPLO_23_DIAS_DE_ENTREGA_0°DIAS_DE_ENTREGA_1");
            //info_resultado = enl_princ.enlasador("MODELO_PRODUCTOS_E_INVENTARIO~AGREGAR_SINO_EXISTE§EJEMPLO_PRODUCTO|12.34|EJEMPLO_TIPO_MEDIDA|56.78|EJEMPLO_COD_BARRAS|9.01|23.45|EJEMPLO_PROVEDOR|EJEMPLO_GRUPO|67.89|EJEMPLO_COD_BAR_PAQUETE|EJEMPLO_LIGAR_PRODUC_SAB|EJEMPLO_IMPUESTOS|EJEMPLO_MATERIA_PRIMA|EJEMPLO_CADUCIDAD|2|EJEMPLO_SUCURSAL_VENT|EJEMPLO_CLASIFICACION_PRODUCTO|EJEMPLO_DIRECCION_IMAGEN_INTERNET|EJEMPLO_DIRECCION_IMAGEN_COMPUTADORA|EJEMPLO_NO_PONER_NADA");

            /*
            ventas ventas = new ventas();
            ventas.Show();
            */
            /*
            compras comp = new compras();
            comp.Show();
            */
            /*
            inventario invent = new inventario();
            invent.Show();
            */
            /*
            conexion con = new conexion();

            while(true)
            {

                Thread.Sleep(2000);
                con.datos_recibidos_a_procesar_y_borrar("IA");

            }
            */

        }
    }
}
