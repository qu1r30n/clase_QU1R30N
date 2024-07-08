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

namespace clase_QU1R30N.sin_internet.con_formularios
{
    public partial class herramientas_para_elementos_del_form : Form
    {

        public herramientas_para_elementos_del_form()
        {
            InitializeComponent();
        }
        
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;

        var_fun_GG vf_GG = new var_fun_GG();
        operaciones_textos op_tex = new operaciones_textos();
        operaciones_arreglos op_arr = new operaciones_arreglos();


        //txt------------------------------------------------------------


        public void fun_txt_prediccion_palabra(TextBox txt_a_configurar, string tipo)
        {
            // Inicializar AutoCompleteStringCollection
            txt_a_configurar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_a_configurar.AutoCompleteSource = AutoCompleteSource.CustomSource;

            if (tipo == "codbar")
            {
                txt_a_configurar.AutoCompleteCustomSource = var_fun_GG.GG_autoCompleteCollection_codbar_venta;
            }
            else if (tipo == "producto")
            {
                txt_a_configurar.AutoCompleteCustomSource = var_fun_GG.GG_autoCompleteCollection_nom_produc_venta;
            }

        }

        public void fun_txt_procesar_tecleos(TextBox txt_a_configurar, ListBox lstb_a_configurar, Label lbl_configurar_desc_produc, Label lbl_configurar_cantidad_costo, Label lbl_configurar_total)
        {
            txt_a_configurar.KeyDown += (sender, e) =>
            {
                if (e.KeyValue == (char)Keys.Enter)
                {

                }

                else if (e.KeyValue == (char)(Keys.Add))
                {
                    //e.KeyChar = '\0';//este evita que escrivas cuando usas keypress
                    e.SuppressKeyPress = true;

                    if (lstb_a_configurar.Items.Count > 0)
                    {


                        string[] elemento_espliteado = lstb_a_configurar.Items[lstb_a_configurar.Items.Count - 1].ToString().Split(Convert.ToChar(G_caracter_separacion[0]));

                        double cantidad = 1;
                        string[] info_produc_del_invent = extraer_info_e_indise(elemento_espliteado[0]);
                        string[] info_split_produc_inv = info_produc_del_invent[0].Split(Convert.ToChar(G_caracter_separacion[0]));
                        if (info_split_produc_inv[8] == "2")
                        {
                            Ventana_emergente vent_emergent = new Ventana_emergente();
                            string[] enviar = { "2°producto°" + info_produc_del_invent[3], "1°cantidad en litros o kilos(se puede decimal)°°2" };
                            string result = vent_emergent.Proceso_ventana_emergente(enviar);
                            if (result != "")
                            {
                                cantidad = Convert.ToDouble(result);
                            }

                        }
                        string cantidad_sumada_o_restada = sumar_o_restar_producto(lstb_a_configurar, elemento_espliteado[0], cantidad);

                        if (info_produc_del_invent[0] != null)
                        {


                            if (lbl_configurar_desc_produc != null) { lbl_configurar_desc_produc.Text = elemento_espliteado[1] + " " + elemento_espliteado[2] + " " + elemento_espliteado[3] + " precio:$" + info_split_produc_inv[3]; }
                            if (lbl_configurar_cantidad_costo != null) { lbl_configurar_cantidad_costo.Text = cantidad_sumada_o_restada + " " + elemento_espliteado[1] + " " + elemento_espliteado[2] + "" + elemento_espliteado[3] + " $" + (Convert.ToDouble(cantidad_sumada_o_restada) * Convert.ToDouble(info_split_produc_inv[3])); }
                            sumar_precio_columna_lstbox(lstb_a_configurar, 4, 5, lbl_configurar_total);

                        }

                    }

                }

                else if (e.KeyValue == (char)(Keys.Subtract))
                {
                    e.SuppressKeyPress = true;

                    if (lstb_a_configurar.Items.Count > 0)
                    {


                        string[] elemento_espliteado = lstb_a_configurar.Items[lstb_a_configurar.Items.Count - 1].ToString().Split(Convert.ToChar(G_caracter_separacion[0]));

                        double cantidad = Convert.ToDouble(-1);
                        string[] info_produc_del_invent = extraer_info_e_indise(elemento_espliteado[0]);
                        string[] info_split_produc_inv = info_produc_del_invent[0].Split(Convert.ToChar(G_caracter_separacion[0]));
                        if (info_split_produc_inv[8] == "2")
                        {
                            Ventana_emergente vent_emergent = new Ventana_emergente();
                            string[] enviar = { "2°producto°" + info_produc_del_invent[3], "1°cantidad en litros o kilos(se puede decimal)°°2" };
                            string result = vent_emergent.Proceso_ventana_emergente(enviar);

                            if (result != "")
                            {
                                cantidad = (-1 * Convert.ToDouble(result));

                            }
                            else
                            {
                                return;
                            }

                        }
                        string cantidad_sumada_o_restada = sumar_o_restar_producto(lstb_a_configurar, elemento_espliteado[0], (cantidad));
                        if (cantidad_sumada_o_restada == "")
                        {
                            cantidad_sumada_o_restada = "0";
                        }
                        if (info_produc_del_invent[0] != null && cantidad_sumada_o_restada != "0")
                        {


                            if (lbl_configurar_desc_produc != null) { lbl_configurar_desc_produc.Text = elemento_espliteado[1] + " " + elemento_espliteado[2] + " " + elemento_espliteado[3] + " precio:$" + info_split_produc_inv[3]; }
                            if (lbl_configurar_cantidad_costo != null) { lbl_configurar_cantidad_costo.Text = cantidad_sumada_o_restada + " " + elemento_espliteado[1] + " " + elemento_espliteado[2] + "" + elemento_espliteado[3] + " $" + (Convert.ToDouble(cantidad_sumada_o_restada) * Convert.ToDouble(info_split_produc_inv[3])); }
                            sumar_precio_columna_lstbox(lstb_a_configurar, 4, 5, lbl_configurar_total);

                        }

                        else
                        {
                            lbl_configurar_desc_produc.Text = "nombre del producto";
                            lbl_configurar_cantidad_costo.Text = "$";
                            sumar_precio_columna_lstbox(lstb_a_configurar, 4, 5, lbl_configurar_total);

                        }

                    }

                }

            };
        }


        public string sumar_o_restar_producto(ListBox lstb_a_configurar, string codigo, double cantidad = 1)
        {
            bool esta_el_mismo_producto = false;
            string cantidad_retornar_string = "";
            for (int i = 0; i < lstb_a_configurar.Items.Count; i++)
            {
                string[] elemento_espliteado = lstb_a_configurar.Items[i].ToString().Split(Convert.ToChar(G_caracter_separacion[0]));
                if (codigo == elemento_espliteado[0])
                {
                    esta_el_mismo_producto = true;
                    double resultado = (Convert.ToDouble(elemento_espliteado[5]) + cantidad);
                    elemento_espliteado[5] = "" + resultado;
                    if (resultado <= 0)
                    {
                        funciones_de_botones(lstb_a_configurar, "eliminar_por_item", i + "");
                    }
                    else
                    {
                        lstb_a_configurar.Items[i] = string.Join(G_caracter_separacion[0], elemento_espliteado);
                        cantidad_retornar_string = elemento_espliteado[5];
                    }

                }
            }


            if (!esta_el_mismo_producto)
            {

                for (int j = G_donde_inicia_la_tabla; j < var_fun_GG.GG_inv_solo_lect.Count; j++)
                {
                    string[] producto_invent = var_fun_GG.GG_inv_solo_lect[j].Split(Convert.ToChar(G_caracter_separacion[0]));
                    if (codigo == producto_invent[4])
                    {
                        //id_0|producto_1|cantidad_producto_2|tipo_de_medida_3|precio_de_venta_4|0_5|cantidad_6|costo_compra_7|provedor_8|grupo_9|multiusos_10|cantidad_productos_por_paquete_11|produc_elaborados_12|ligar_productos_para_sabo_13|impuesto_14|tipo_producto_para_impuesto_15

                        lstb_a_configurar.Items.Add(producto_invent[4] + G_caracter_separacion[0] + producto_invent[0] + G_caracter_separacion[0] + producto_invent[1] + G_caracter_separacion[0] + producto_invent[2] + G_caracter_separacion[0] + producto_invent[3] + G_caracter_separacion[0] + cantidad + G_caracter_separacion[0] + j);
                        cantidad_retornar_string = "" + cantidad;
                        break;
                    }
                }
            }
            return cantidad_retornar_string;
        }

        public double sumar_precio_columna_lstbox(ListBox lstb_a_configurar, int columna_precios, int columna_cantidad, Label lbl_total = null, string caracter_separacion = null)
        {
            if (caracter_separacion == null)
            {
                caracter_separacion = G_caracter_separacion[0];
            }
            double total = 0;
            for (int i = 0; i < lstb_a_configurar.Items.Count; i++)
            {
                string[] dat_produc = lstb_a_configurar.Items[i].ToString().Split(Convert.ToChar(caracter_separacion));
                total = total + (Convert.ToDouble(dat_produc[columna_cantidad]) * Convert.ToDouble(dat_produc[columna_precios]));
            }

            if (lbl_total != null) { lbl_total.Text = "" + total; }

            return total;
        }

        public void funciones_de_botones(ListBox lstb_a_configurar, string proceso, string info_extra = "")
        {
            //eliminar_por_item,eliminar_seleccionado,eliminar_ultimo,eliminar_todo
            switch (proceso)
            {
                case "eliminar_por_item":
                    if (lstb_a_configurar.Items.Count > 0)
                    {
                        lstb_a_configurar.Items.RemoveAt(Convert.ToInt32(info_extra));
                    }
                    break;
                case "eliminar_seleccionado":

                    lstb_a_configurar.Items.RemoveAt(lstb_a_configurar.SelectedIndex);
                    break;

                case "eliminar_ultimo":
                    if (lstb_a_configurar.Items.Count > 0)
                    {
                        lstb_a_configurar.Items.RemoveAt(lstb_a_configurar.Items.Count - 1);
                    }
                    break;
                case "eliminar_todo":
                    lstb_a_configurar.Items.Clear();
                    break;

                case "procesar_venta":
                    ventana_introduce_cantidad_pagada(lstb_a_configurar);
                    lstb_a_configurar.Items.Clear();
                    break;

                default:
                    break;
            }
        }


        private void ventana_introduce_cantidad_pagada(ListBox lstb_a_configurar)
        {
            double total = sumar_precio_columna_lstbox(lstb_a_configurar, 4, 5);
            string[] arreglo_info_lstb = lstb_a_configurar.Items.Cast<string>().ToArray();//convierte el listbox a arreglo


            Ventana_emergente vent_emergent = new Ventana_emergente();
            string[] enviar = { "1|cantidad pagada|" + total + "|2" };

            string cantidad_en_dinero_dada = vent_emergent.Proceso_ventana_emergente(enviar);
            double cantidad_en_dinero_dada_double = Convert.ToDouble(cantidad_en_dinero_dada);



            if (total + "" == cantidad_en_dinero_dada)
            {
                //mod.modelo_unico("mod_venta", informacion_de_variables: arreglo_info_lstb);
            }
            else if (cantidad_en_dinero_dada_double > total)
            {
                //mod.modelo_unico("mod_venta", arreglo_info_lstb);
                MessageBox.Show("cambio: " + (cantidad_en_dinero_dada_double - total));
            }
            else if (cantidad_en_dinero_dada_double < total)
            {
                MessageBox.Show("falta: " + (total - cantidad_en_dinero_dada_double));
                ventana_introduce_cantidad_pagada(lstb_a_configurar);
            }

        }

        public string[] extraer_info_e_indise(string cod_bar, string caracter_separacion = null)
        {

            if (caracter_separacion == null)
            {
                caracter_separacion = G_caracter_separacion[0];
            }

            string[] informacionProducto = { null, null };

            bool encontrado = false;
            for (int i = G_donde_inicia_la_tabla; i < var_fun_GG.GG_inv_solo_lect.Count; i++)
            {
                string[] producto_espliteado = var_fun_GG.GG_inv_solo_lect[i].Split(Convert.ToChar(caracter_separacion));
                if (producto_espliteado[4] == cod_bar)
                {
                    informacionProducto[0] = var_fun_GG.GG_inv_solo_lect[i];
                    informacionProducto[1] = "" + i;
                    encontrado = true;
                    break;
                }
            }

            if (encontrado == false) {/*hacer algo si no lo encuentra*/}

            return informacionProducto;
        }



        //final clase-----------------------------------------------------------
    }
}
