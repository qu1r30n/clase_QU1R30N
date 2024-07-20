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
    public partial class inventario : Form
    {

        herramientas_para_elementos_del_form herr_form = new herramientas_para_elementos_del_form();
        public inventario()
        {
            InitializeComponent();


            herr_form.fun_botones(lst_cod_bar, btn_cargar_archivo_inv, "INV_FORM_CARGAR_ARCHIVO");
            herr_form.fun_botones(lst_cod_bar, Btn_eliminar_seleccionado, "ELIMINAR_SELECCIONADO");
            herr_form.fun_botones(lst_cod_bar, Btn_eliminar_todo, "ELIMINAR_TODO");
            herr_form.fun_botones(lst_cod_bar, Btn_elim_ultimo, "ELIMINAR_ULTIMO");
            herr_form.fun_botones(lst_cod_bar, Btn_verificar_inv, "INV_VERIFICAR");


            herr_form.fun_botones(lst_todos_los_agregados, Btn_eliminar_seleccionado2, "ELIMINAR_SELECCIONADO");
            herr_form.fun_botones(lst_todos_los_agregados, Btn_eliminar_todo2, "ELIMINAR_TODO");
            herr_form.fun_botones(lst_todos_los_agregados, Btn_elim_ultimo2, "ELIMINAR_ULTIMO");
        }
    }
}
