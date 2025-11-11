using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Configuration;

namespace SAGA_EV3
{


    public partial class Form2 : Form
    {

        DataTable dt = new DataTable();
        DataTable dt_usuarios = new DataTable();
        List<Usuario> usuarios = new List<Usuario>();
        string  usuario;
        string rol;
        public Form2(string usuario, string rol)
        {
            InitializeComponent();
            CargarDatosUsuarios();
            Cargardatos();
            this.usuario = usuario;
            this.rol = rol;
            Lbl_usuario_logeado.Text = $"Usuario: {usuario} - Rol: {rol}";
        }
        private void Tsm_nuevo_prod_Click(object sender, EventArgs e)
        {
            DGV_inventario.Refresh();
            //Adjusting panel visibility
            Pnl_agregar_nuevo.Visible = true;
            Pnl_agregar_existente.Visible = false;
            PNL_eliminacion_producto.Visible = false;
            PNL_eliminacion_cantidad.Visible = false;
            Pnl_gestionUsuarios .Visible = false;
            //Adjusting checks
            Tsm_agregar_existente.Checked = false;
            Tsm_agregar.Checked = true;
            Tsm_Eliminar.Checked = false;
            Tsm_nuevo_prod.Checked = true;


        }

        private void Tsm_agregar_existente_Click(object sender, EventArgs e)
        {
            DGV_inventario.Refresh();
            //Adjusting panel visibility
            Pnl_agregar_existente.Visible = true;
            Pnl_agregar_nuevo.Visible = false;
            PNL_eliminacion_producto.Visible = false;
            PNL_eliminacion_cantidad.Visible = false;
            Pnl_gestionUsuarios.Visible = false;
            //Adjusting checks
            Tsm_nuevo_prod.Checked = false;
            Tsm_Eliminar.Checked = false;
            Tsm_agregar.Checked = true;
            Tsm_agregar_existente.Checked = true;



        }

        private void Tsm_Eliminar_Click(object sender, EventArgs e)
        {

        }
        private void CargarDatosUsuarios()
        {   //inicio de seccion redundante(separar en un metodo unico)
            //Code to load data into the DataGridView
            if (!File.Exists("Users.TXT")) return;
            dt_usuarios.Clear();
            dt_usuarios.Columns.Add("Nombre de Usuario", typeof(string));
            dt_usuarios.Columns.Add("Tipo de usuario", typeof(string));
            dt_usuarios.Columns.Add("Fecha de creacion", typeof(string));
            try
            {
                string[] lines = File.ReadAllLines("Users.TXT");

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(';');
                    if (parts.Length == 4)
                    {
                        usuarios.Add(new Usuario(parts[0], parts[1], parts[2], parts[3]));
                        dt_usuarios.Rows.Add(usuarios[i].GetNombre(), usuarios[i].GetRol(), usuarios[i].GetFechaCreacion());
                    }

                }
            }
            catch (Exception) 
            {
                MessageBox.Show("El inventario ha quedado vacio", "Emergencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //fin de seccion redundante(separar en un metodo unico)
            Dgv_gestionUsuarios.DataSource = dt_usuarios;
        }
        private void Cargardatos()
        {   //inicio de seccion redundante(separar en un metodo unico para reutilizar codigo)
            //Code to load data into the DataGridView
            if (!File.Exists("Inventario.TXT")) return;
            dt.Clear();
            dt.Columns.Clear();
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Cantidad", typeof(int));
            dt.Columns.Add("Tipo", typeof(string));
            try
            {
                string[] lines = File.ReadAllLines("Inventario.TXT");

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(';');
                    if (parts.Length == 3)
                    {
                        dt.Rows.Add(parts[0], int.Parse(parts[1]), parts[2]);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("El inventario ha quedado vacio", "Emergencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //fin de seccion redundante
            // Assigning DataTable to DataGridView and ComboBox
            DGV_inventario.DataSource = dt;
            CBX_producto_eliminacion.DataSource = dt;
            CBX_producto_eliminacion.DisplayMember = "Nombre";
            CBX_producto_eliminacion.ValueMember = "Nombre";
            CBX_producto_eliminacion.SelectedIndex = -1;
            CBX_producto_eliminacion.DropDownStyle = ComboBoxStyle.DropDownList;
            CBX_existencia.DataSource = dt;
            CBX_existencia.DisplayMember = "Nombre";
            CBX_existencia.ValueMember = "Nombre";
            CBX_existencia.SelectedIndex = -1;
            CBX_existencia.DropDownStyle = ComboBoxStyle.DropDownList;
            CBX_eliminacion.DataSource = dt;
            CBX_eliminacion.DisplayMember = "Nombre";
            CBX_eliminacion.ValueMember = "Nombre";
            CBX_eliminacion.SelectedIndex = -1;
            CBX_eliminacion.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbx_filtro_tipo_usuario.DataSource = dt_usuarios.DefaultView.ToTable(true, "Tipo de usuario");
            Cbx_filtro_tipo_usuario.DisplayMember = "Tipo de usuario";
            Cbx_filtro_tipo_usuario.ValueMember = "Tipo de usuario";
            Cbx_modificar_tipo_usuario.DataSource = dt_usuarios.DefaultView.ToTable(true, "Tipo de usuario");
            Cbx_modificar_tipo_usuario.DisplayMember = "Tipo de usuario";
            Cbx_modificar_tipo_usuario.ValueMember = "Tipo de usuario";




        }
        private void Btn_Agregar_prod_nuevo_Click(object sender, EventArgs e)
        {
            if (Txb_producto_nuevo.Text == "" || Txb_cantidad.Text == "" || Cbx_tipo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(Txb_cantidad.Text, out int cantidad) || cantidad < 0)
            {
                MessageBox.Show("Por favor ingrese una cantidad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            

            else if (Existe_producto(Txb_producto_nuevo.Text))
            {
                MessageBox.Show("El producto ya existe, si desea agregar existencias vaya al apartado correspondiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string nombre_producto = Txb_producto_nuevo.Text.Trim();
                using (StreamWriter inventario = new StreamWriter("Inventario.TXT", true))
                {
                    inventario.WriteLine($"{Txb_producto_nuevo.Text};{cantidad};{Cbx_tipo.SelectedItem.ToString()}");
                }

                MessageBox.Show("Producto agregado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cargardatos();  

            }
        }
        private bool Existe_producto(string nombre)
        {
            foreach (DataRow row in dt.Rows)
            {
                if (row["Nombre"].ToString().Equals(nombre, StringComparison.OrdinalIgnoreCase   ))
                {
                    return true;
                }
            }
            return false;
        }
        private bool validar_modificacion(ComboBox seleccion, TextBox numero)
        { 

            if (seleccion.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un producto para agregar o restar existencias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            DataRow[] fila_objetivo = dt.Select($"Nombre = '{seleccion.SelectedValue.ToString()}'");
            int cantidad_actual= int.Parse(fila_objetivo[0]["Cantidad"].ToString());

            if (!int.TryParse(numero.Text, out int cantidad) || int.Parse(numero.Text) <= 0 || int.Parse(numero.Text) > cantidad_actual)
            {
                MessageBox.Show("La cantidad agregada debe ser mayor que cero y menor que la cantidad total en inventario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }
        private void BTN_agregar_existencias_Click(object sender, EventArgs e)
        {
  

             if (validar_modificacion(CBX_existencia,Txb_cantidad))
            {
                int cantidad_ingresada = int.Parse(TXB_agregar_cantidad_existencia.Text);
                try
                {
                
                    using (StreamWriter inventario = new StreamWriter("Inventario.TXT", true))
                    {
                        DataRow[] fila = dt.Select($"Nombre = '{CBX_existencia.SelectedValue.ToString()}'");
                        fila[0]["Cantidad"] = (int.Parse(fila[0]["Cantidad"].ToString())) + cantidad_ingresada;

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar existencias: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void BTN_eliminar_Click(object sender, EventArgs e)
        {
            // Validar selección
            if (CBX_producto_eliminacion.SelectedIndex == -1 || CBX_producto_eliminacion.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar el producto a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string seleccionado = CBX_producto_eliminacion.SelectedValue.ToString();
            var sb = new StringBuilder();

            // Construir todo el contenido nuevo en memoria (sin el producto a eliminar)
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var nombreObj = dt.Rows[i]["Nombre"];
                if (nombreObj == null || nombreObj == DBNull.Value) continue;

                string nombre = nombreObj.ToString();
                //Transferir solo los que no coinciden con el seleccionado
                if (!string.Equals(nombre, seleccionado, StringComparison.Ordinal))
                {
                    sb.AppendFormat("{0};{1};{2}\n", dt.Rows[i]["Nombre"], dt.Rows[i]["Cantidad"], dt.Rows[i]["Tipo"]);
                }
            }
            File.WriteAllText("Inventario.TXT", sb.ToString());

            MessageBox.Show("Producto eliminado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Cargardatos();
        }
        private void BTN_eliminar_cantidad_Click(object sender, EventArgs e)
        {
            if (validar_modificacion(CBX_eliminacion,TXB_Eliminacion_cantidad))
            {
                int cantidad_ingresada = int.Parse(TXB_Eliminacion_cantidad.Text);
                try
                {

                    using (StreamWriter inventario = new StreamWriter("Inventario.TXT", true))
                    {
                        DataRow[] fila = dt.Select($"Nombre = '{CBX_eliminacion.SelectedValue.ToString()}'");
                        fila[0]["Cantidad"] = (int.Parse(fila[0]["Cantidad"].ToString())) - cantidad_ingresada;

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al restar existencias: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void TSM_eliminar_producto_Click(object sender, EventArgs e)
        {
            PNL_eliminacion_producto.Visible = true;
            PNL_eliminacion_cantidad.Visible = false;
            Pnl_agregar_existente.Visible = false;
            Pnl_agregar_nuevo.Visible = false;
            Pnl_gestionUsuarios.Visible = false;

            TSM_eliminar_producto.Checked = true;
            Tsm_Eliminar.Checked = true;
            TSM_eliminar_existencias.Checked = false;
            Tsm_agregar.Checked = false;
            Tsm_agregar_existente.Checked = false;
            Tsm_nuevo_prod.Checked = false;
        }

        private void TSM_eliminar_existencias_Click(object sender, EventArgs e)
        {
            PNL_eliminacion_cantidad.Visible = true;
            PNL_eliminacion_producto.Visible = false;
            Pnl_agregar_existente.Visible = false;
            Pnl_agregar_nuevo.Visible = false;
            Pnl_gestionUsuarios.Visible = false;

            Tsm_Eliminar.Checked = true;
            TSM_eliminar_existencias.Checked = true;
            TSM_eliminar_producto.Checked = false;
            Tsm_nuevo_prod.Checked = false;
            Tsm_agregar_existente.Checked = false;
            
            Tsm_agregar.Checked = false;


            Tsm_agregar.Checked = false;
            Tsm_agregar_existente.Checked = false;
            Tsm_nuevo_prod.Checked = false;
        }

        private void Tsm_agregar_Click(object sender, EventArgs e)
        {

        }

        private void Tsm_gestion_usuarios_Click(object sender, EventArgs e)
        {
             
            Pnl_gestionUsuarios.Visible = true;
            Pnl_agregar_existente.Visible = false;
            Pnl_agregar_nuevo.Visible = false;
            PNL_eliminacion_cantidad.Visible = false;
            PNL_eliminacion_producto.Visible = false;
        }

        private void Lbl_usuario_logeado_Click(object sender, EventArgs e)
        {

        }

        private void Btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void Btn_filtrar_Click(object sender, EventArgs e)
        {
            string filtro_tipo = Cbx_filtro_tipo_usuario.SelectedValue.ToString();
            string filtro_nombre= Txb_filtro_nombre_usuario.Text.Trim();
            DataView dv = dt_usuarios.DefaultView;
            try
            {
                dv.RowFilter = $"[Tipo de usuario] LIKE '%{filtro_tipo}%' AND [Nombre de Usuario] LIKE '%{filtro_nombre}%'";
                Dgv_gestionUsuarios.DataSource = dv.ToTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar filtro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

        }
        string usuario_seleccionado;
        private void Btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Pnl_edicion.Visible = true;
                if (Dgv_gestionUsuarios.SelectedRows.Count == 1)
                {
                    usuario_seleccionado = Dgv_gestionUsuarios.SelectedRows[0].Cells["Nombre de Usuario"].Value.ToString();
                    Txb_modificar_nombre_usuario.Text = usuario_seleccionado;
                    
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un solo usuario para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }   
        }
        
        private void Btn_guardar_cambios_Click(object sender, EventArgs e)
        {
            try
            {
               if (Txb_modificar_nombre_usuario.Text.Trim() != "" && Cbx_modificar_tipo_usuario.SelectedIndex != 0)
               {
                    var user = usuarios.FirstOrDefault(x => x.GetNombre() == usuario_seleccionado);
                    user._Nombre = Txb_modificar_nombre_usuario.Text.Trim();
                    user._Rol = Cbx_modificar_tipo_usuario.SelectedValue.ToString();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Cargardatos();
        }

        private void Dgv_gestionUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            Btn_editar.Enabled = Dgv_gestionUsuarios.SelectedRows.Count == 1;
        }

        private void Cbx_filtro_tipo_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
