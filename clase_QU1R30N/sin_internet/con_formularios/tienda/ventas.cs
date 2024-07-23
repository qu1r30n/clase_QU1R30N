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

        herramientas_para_elementos_del_form herr_form = new herramientas_para_elementos_del_form();


        public ventas()
        {
            InitializeComponent();


            // Inicializar AutoCompleteStringCollection
            herr_form.fun_txt_prediccion_palabra(Txt_Codbar, "codbar");
            herr_form.fun_txt_prediccion_palabra(Txt_nom_producto, "producto");

            herr_form.fun_txt_procesar_tecleos_ventas(Txt_Codbar, Lst_ventas, Lbl_nom_product_list, Lbl_costo_product_list, Lbl_cuenta);
            herr_form.fun_txt_nom_produc_pasar_a_txt_codigo(Txt_nom_producto, Txt_Codbar);

            herr_form.fun_botones(Lst_ventas, Btn_eliminar_seleccionado, "ELIMINAR_SELECCIONADO", Lbl_nom_product_list, Lbl_costo_product_list, Lbl_cuenta);
            herr_form.fun_botones(Lst_ventas, Btn_eliminar_todo, "ELIMINAR_TODO", Lbl_nom_product_list, Lbl_costo_product_list, Lbl_cuenta);
            herr_form.fun_botones(Lst_ventas, Btn_elim_ultimo, "ELIMINAR_ULTIMO", Lbl_nom_product_list, Lbl_costo_product_list, Lbl_cuenta);
            herr_form.fun_botones(Lst_ventas, Btn_procesar_venta, "PROCESAR_VENTA", Lbl_nom_product_list, Lbl_costo_product_list, Lbl_cuenta);

            herr_form.fun_ventana_cargar_cadaves_que_regresa_a_la_ventana(this, Txt_Codbar, Txt_nom_producto);

            //------------------------------------------------------------------------------------

        }

        

    }
}
