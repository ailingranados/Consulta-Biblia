using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion2
{
    public partial class Busqueda : Form
    {
        private static int usuarioActualId;

        private static DataTable Idiomas;
        private static DataTable Versiones;
        private static int id_idioma;

        private static DataTable Testamentos;
        private static int id_testamento;
        private static DataTable Libro;

        private static DataTable DT_Busqueda;

        public Busqueda(int id_usu)
        {
            usuarioActualId = id_usu;
            InitializeComponent();
        }

        private void Busqueda_Load(object sender, EventArgs e)
        {
            int i = 0;
            EnlaceDB ConsultarIdioma = new EnlaceDB();
            Idiomas = ConsultarIdioma.Consultar_Idioma();


            while (i < Idiomas.Rows.Count)
            {
                CB_idioma.Items.Add(Idiomas.Rows[i]["Nombre"].ToString());
                i++;
            }


        }

        private void CB_idioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            //limpiar items de version
            CB_version.Items.Clear();
            CB_testamento.Items.Clear();
            CB_libro.Items.Clear();

            int j = 0;
            EnlaceDB ConsultarVersion = new EnlaceDB();


            string idioma = CB_idioma.Text;

            id_idioma = ConsultarVersion.Buscar_Idioma(idioma);

            Versiones = ConsultarVersion.Consultar_Version(id_idioma);

            while (j < Versiones.Rows.Count)
            {
                CB_version.Items.Add(Versiones.Rows[j]["NombreVersion"].ToString());
                j++;
            }


            int a = 0;
            EnlaceDB ConsultarTestamento = new EnlaceDB();


            Testamentos = ConsultarTestamento.Consultar_Testamento(id_idioma);


            while (a < Testamentos.Rows.Count)
            {
                CB_testamento.Items.Add(Testamentos.Rows[a]["Nombre"].ToString());
                a++;
            }
        }

        private void CB_testamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_libro.Items.Clear();
            
            int b = 0;

            EnlaceDB ConsultarLibro = new EnlaceDB();
            string testamento = CB_testamento.Text;

            id_testamento = ConsultarLibro.Buscar_Testamento(testamento);

            Libro = ConsultarLibro.Consultar_Libros(id_idioma, id_testamento);

            while (b < Libro.Rows.Count)
            {
                CB_libro.Items.Add(Libro.Rows[b]["Nombre"].ToString());
                b++;
            }
        }

        private void BTN_buscar_Click(object sender, EventArgs e)
        {
            
            //limpiar campos
            TB_busqueda.Text = "";
            

            if (CB_idioma.Text == "")
            {
                MessageBox.Show("Debe seleccionar un idioma", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CB_version.Text == "")
            {
                MessageBox.Show("Debe seleccionar una version", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string palabras = TB_palabras.Text;
            EnlaceDB conexion = new EnlaceDB();
            conexion.Insertar_busqueda(usuarioActualId, palabras);

            EnlaceDB EDB_ConsultarDGV = new EnlaceDB();

            string STR_idioma = CB_idioma.Text;

            string STR_version = CB_version.Text;

            string STR_testamento = CB_testamento.Text;

            string STR_libro = CB_libro.Text;

            

            int id_versionB = EDB_ConsultarDGV.Buscar_Version(STR_version);

            int id_idiomaB = EDB_ConsultarDGV.Buscar_Idioma(STR_idioma);

            int id_testamentoB = EDB_ConsultarDGV.Buscar_Testamento(STR_testamento);

            int id_libroB = EDB_ConsultarDGV.Buscar_Libro(STR_libro);

           
            DT_Busqueda =  EDB_ConsultarDGV.BusquedaPorPalabra(id_idiomaB, id_versionB, id_testamentoB, id_libroB, palabras);

            DGV_busqueda.DataSource = DT_Busqueda;

           
            DGV_busqueda.Columns[4].HeaderText = "CAPITULO";
            DGV_busqueda.Columns[5].HeaderText = "NUMERO VERSICULO";
            
          

        }

        private void DGV_busqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_busqueda.Text = "";


            TB_busqueda.Text = DGV_busqueda.CurrentRow.Cells[6].Value.ToString();
            
        }
    }
}
