using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion2
{
    public partial class Historial : Form
    {
        private static int usuarioActualId;
        private static DataTable DT_Historial_referencias;
        public Historial(int id_usu)
        {
            usuarioActualId = id_usu;
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Historial_Load(object sender, EventArgs e)
        {
           

        }

        private void BTN_eliminar_Click(object sender, EventArgs e)
        {
            EnlaceDB conexion = new EnlaceDB();


            if (rb_todo.Checked)
            {
                if (DGV_historial.Rows.Count == 0)
                {
                    MessageBox.Show("No se tiene algo para borrar", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult salienda = MessageBox.Show("¿Desea eliminar todo su historial?", ":o", MessageBoxButtons.YesNoCancel);
                if (salienda == DialogResult.Yes)
                {


                    foreach (DataRow row in DT_Historial_referencias.Rows)
                    {
                        int historial = Convert.ToInt32(row["Id_historial"]);

                        conexion.Eliminar_historial(historial);
                    }
                    MessageBox.Show("Se ha borrado el historial completo", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                if(DGV_historial.CurrentRow == null)
                {
                    MessageBox.Show("No se ha seleccionado algo para borrar", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }   

                string STR_historial = DGV_historial.CurrentRow.Cells[0].Value.ToString();
                int historial;
                if (STR_historial == "")
                {
                    historial = 0;

                }
                else
                {

                    historial = int.Parse(STR_historial);
                }

                if (historial == 0)
                {
                    MessageBox.Show("No se ha seleccionado algo para borrar", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    conexion.Eliminar_historial(historial);
                    MessageBox.Show("Se ha borrado el historial seleccionado", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }


            }
        }

        private void BTN_consultas_Click(object sender, EventArgs e)
        {
            EnlaceDB conexion = new EnlaceDB();
            DT_Historial_referencias = conexion.Consultar_historial(usuarioActualId);

            DT_Historial_referencias.Columns.Add("IDIOMA", typeof(string));
            DT_Historial_referencias.Columns.Add("VERSION", typeof(string));
            DT_Historial_referencias.Columns.Add("TESTAMENTO", typeof(string));
            DT_Historial_referencias.Columns.Add("LIBRO", typeof(string));
            DT_Historial_referencias.Columns.Add("CAPITULO", typeof(string));
            DT_Historial_referencias.Columns.Add("VERSICULO", typeof(string));

            foreach (DataRow row in DT_Historial_referencias.Rows)
            {
                int Row_idioma = Convert.ToInt32(row["Id_Idioma"]);
                int Row_version = Convert.ToInt32(row["Id_Version"]);
                int Row_testamento = Convert.ToInt32(row["Id_Testamento"]);
                int Row_libro = Convert.ToInt32(row["Id_Libro"]);
                int Row_capitulo = Convert.ToInt32(row["Id_Capitulo"]);
                int Row_versiculo = Convert.ToInt32(row["Id_Versiculo"]);

                string idioma = conexion.IdiomaPorId(Row_idioma);
                string version = conexion.VersionPorId(Row_version);

                string testamento = null;
                string libro = null;
                string versiculo = null;
                string capitulo = null;
                if (Row_testamento != 0)
                {
                    testamento = conexion.TestamentoPorId(Row_testamento);
                }
                else
                {
                    testamento = "N/C";
                }

                if (Row_libro != 0)
                {
                    libro = conexion.LibroPorId(Row_libro);
                }
                else
                {
                    libro = "N/C";
                }

                if (Row_capitulo == 0)
                {
                    capitulo = "N/C";
                }
                else
                {
                    capitulo = Row_capitulo.ToString();
                }

                if (Row_versiculo != 0)
                {
                    versiculo = conexion.VersiculoPorId(Row_versiculo);
                }
                else
                {
                    versiculo = "N/C";
                }


                row["IDIOMA"] = idioma;
                row["VERSION"] = version;
                row["TESTAMENTO"] = testamento;
                row["LIBRO"] = libro;
                row["VERSICULO"] = versiculo;
                row["CAPITULO"] = capitulo;

            }

            DGV_historial.DataSource = DT_Historial_referencias;

            DGV_historial.Columns[0].Visible = false;
            DGV_historial.Columns[1].HeaderText = "BUSQUEDA";
            DGV_historial.Columns[2].HeaderText = "FECHA";
            DGV_historial.Columns[3].Visible = false;
            DGV_historial.Columns[4].Visible = false;
            DGV_historial.Columns[5].Visible = false;
            DGV_historial.Columns[6].Visible = false;
            DGV_historial.Columns[7].Visible = false;
            DGV_historial.Columns[8].Visible = false;
            DGV_historial.Columns[9].Visible = false;
            DGV_historial.Columns[10].Visible = false;

        }

        private void BTN_busquedas_Click(object sender, EventArgs e)
        {
            EnlaceDB conexion = new EnlaceDB();
            DT_Historial_referencias = conexion.Consultar_historialBusqueda(usuarioActualId);

           
            
            DGV_historial.DataSource = DT_Historial_referencias;

            DGV_historial.Columns[0].Visible = false;
            DGV_historial.Columns[1].HeaderText = "Tipo de busqueda";
            DGV_historial.Columns[2].HeaderText = "Fecha";
            DGV_historial.Columns[3].Visible = false;
            DGV_historial.Columns[4].Visible = false;
            DGV_historial.Columns[5].HeaderText = "Busqueda";

        }
    }
}
