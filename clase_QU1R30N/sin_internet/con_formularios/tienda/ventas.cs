using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase_QU1R30N.sin_internet.con_formularios.tienda
{
    public partial class ventas : Form
    {
        Tex_base bas = new Tex_base();
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;


        string[] G_direcciones_REGISTROS =
        {
            Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[1,0],//inventario
            
        };
        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;

        herramientas_para_elementos_del_form herr_form = new herramientas_para_elementos_del_form();
        public ventas()
        {
            InitializeComponent();


            // Inicializar AutoCompleteStringCollection
            herr_form.fun_txt_prediccion_palabra(Txt_buscar_producto, "codbar");
            herr_form.fun_txt_prediccion_palabra(Txt_nom_producto, "producto");

            herr_form.fun_txt_procesar_tecleos(Txt_buscar_producto, Lst_ventas, Lbl_nom_product_list, Lbl_costo_product_list, Lbl_cuenta);
            herr_form.fun_txt_nom_produc_pasar_a_txt_codigo(Txt_nom_producto, Txt_buscar_producto, "4");

            //------------------------------------------------------------------------------------
        }

        private void provedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void prestamosdeproddinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comprasabajoarribaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lstb_descripcion_promo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstb_promociones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstb_promociones_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_venta_Click(object sender, EventArgs e)
        {

        }

        private void Btn_elim_ultimo_Click(object sender, EventArgs e)
        {

        }

        private void Btn_procesar_venta_Click(object sender, EventArgs e)
        {

        }

        private void Btn_eliminar_todo_Click(object sender, EventArgs e)
        {

        }

        private void Btn_eliminar_seleccionado_Click(object sender, EventArgs e)
        {

        }

        private void Lst_ventas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lst_ventas_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Txt_nom_producto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Txt_buscar_producto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Txt_buscar_producto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Btn_procesar_venta_Click_1(object sender, EventArgs e)
        {

        }
    }
}
