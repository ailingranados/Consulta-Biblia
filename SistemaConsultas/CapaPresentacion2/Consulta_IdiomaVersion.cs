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
    public partial class Consulta_IdiomaVersion : Form
    {
        private static int usuarioActualId;

        private static DataTable Idiomas;
        private static DataTable Versiones;
        private static int id_idioma;
        private static int id_version;
        private static DataTable Testamentos;
        private static int id_testamento;
        private static DataTable Libro;
        private static int id_libro;
        private static DataTable DT_Versiculo;
        private static int id_versiculo;
        private static int id_capitulo;

        private static DataTable DT_consulta;


        //favoritos

        private static string STR_Idioma;
        private static string STR_Version;
        private static string STR_Testamento;
        private static string STR_Libro;
        private static int INT_Capitulo;
        private static int INT_Versiculo;

        public Consulta_IdiomaVersion(int id_usu)
        {
            usuarioActualId = id_usu;
            InitializeComponent();
        }

        private void Consulta_IdiomaVersion_Load(object sender, EventArgs e)
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

        public void CB_idioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            //limpiar items de version
            CB_version.Items.Clear();

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

            //testamento
            CB_testamento.Items.Clear();

            int a = 0;
            EnlaceDB ConsultarTestamento = new EnlaceDB();

            
            Testamentos = ConsultarTestamento.Consultar_Testamento(id_idioma);

            
            while (a < Testamentos.Rows.Count)
            {
                CB_testamento.Items.Add(Testamentos.Rows[a]["Nombre"].ToString());
                a++;
            }


        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            //limpiar campos
            label6.Text = "";
            L_capitulo.Text = "";

            EnlaceDB EDB_ConsultarDGV = new EnlaceDB();

            string STR_idioma = CB_idioma.Text;

            string STR_version = CB_version.Text;

            string STR_testamento = CB_testamento.Text;

            string STR_libro = CB_libro.Text;

            string STR_versiculo = CB_versiculo.Text;

            int id_versionB = EDB_ConsultarDGV.Buscar_Version(STR_version);

            int id_idiomaB = EDB_ConsultarDGV.Buscar_Idioma(STR_idioma);

            int id_testamentoB = EDB_ConsultarDGV.Buscar_Testamento(STR_testamento);

            int id_libroB = EDB_ConsultarDGV.Buscar_Libro(STR_libro);


            int id_versiculoB = EDB_ConsultarDGV.Buscar_Ver(STR_versiculo);

            if ((id_testamentoB == 0) & (id_libroB == 0) & (id_versiculoB == 0))
            {
                DT_consulta = EDB_ConsultarDGV.Consultar_IV(id_idiomaB, id_versionB);
                DGV_consulta.DataSource = DT_consulta;
            }
            else if((id_libroB == 0) & (id_versiculoB == 0))
            {
                DT_consulta = EDB_ConsultarDGV.Consultar_IVT(id_idiomaB, id_versionB, id_testamentoB);
                DGV_consulta.DataSource = DT_consulta;
            }
            else if (id_versiculoB == 0)
            {
                DT_consulta = EDB_ConsultarDGV.Consultar_IVTL(id_idiomaB, id_versionB, id_testamentoB, id_libroB);
                DGV_consulta.DataSource = DT_consulta;
            }
            else
            {
                DT_consulta = EDB_ConsultarDGV.Consultar_IVTLVE(id_idiomaB, id_versionB, id_testamentoB, id_libroB, id_versiculoB);
                DGV_consulta.DataSource = DT_consulta;
            }
            

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        public void CB_testamento_SelectedIndexChanged(object sender, EventArgs e)
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

        private void CB_capitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CB_versiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CB_libro_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_versiculo.Items.Clear();
            int c = 0;

            EnlaceDB EDB_ConsultarVersiculo = new EnlaceDB();
            
            string STR_libro = CB_libro.Text;

            string STR_version = CB_version.Text;

            id_version = EDB_ConsultarVersiculo.Buscar_Version(STR_version);

            id_libro = EDB_ConsultarVersiculo.Buscar_Libro(STR_libro);

            DT_Versiculo = EDB_ConsultarVersiculo.Consultar_Versiculos(id_version, id_libro);

            while (c < DT_Versiculo.Rows.Count)
            {
                CB_versiculo.Items.Add(DT_Versiculo.Rows[c]["NumeroVers"].ToString());
                c++;
            }
        }

        private void DGV_consulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //limpiar campos
            label6.Text = "";
            L_capitulo.Text = "";

            L_capitulo.Text = DGV_consulta.CurrentRow.Cells[4].Value.ToString();
            label6.Text = DGV_consulta.CurrentRow.Cells[6].Value.ToString();
            STR_Idioma = DGV_consulta.CurrentRow.Cells[0].Value.ToString();
            STR_Version = DGV_consulta.CurrentRow.Cells[1].Value.ToString();
            STR_Testamento = DGV_consulta.CurrentRow.Cells[2].Value.ToString();
            STR_Libro = DGV_consulta.CurrentRow.Cells[3].Value.ToString();
            INT_Versiculo = int.Parse(DGV_consulta.CurrentRow.Cells[5].Value.ToString()); ;

            
            INT_Capitulo = int.Parse(DGV_consulta.CurrentRow.Cells[4].Value.ToString());

        }

        private void CI_favorito_Click(object sender, EventArgs e)
        {
            EnlaceDB EDB_AgregarFavorito = new EnlaceDB();

            bool B_favorito = false;
            
            int INT_id_referencia;

            string NombreFav = Convert.ToString(CIV_favorito.Text);

            id_idioma = EDB_AgregarFavorito.Buscar_Idioma(STR_Idioma);

            id_version = EDB_AgregarFavorito.Buscar_Version(STR_Version);

            id_testamento = EDB_AgregarFavorito.Buscar_Testamento(STR_Testamento);
            
            id_libro = EDB_AgregarFavorito.Buscar_Libro(STR_Libro);

            id_versiculo = INT_Versiculo;

            id_capitulo = INT_Capitulo;
            
            if (RB_capitulo.Checked)
            {
                EDB_AgregarFavorito.Agregar_referencia(id_idioma, id_version, id_testamento, id_libro, id_capitulo, 0);

                INT_id_referencia = EDB_AgregarFavorito.Buscar_referencia(id_idioma, id_version, id_testamento, id_libro, id_capitulo, 0);

                B_favorito = EDB_AgregarFavorito.Agregar_fav(usuarioActualId, INT_id_referencia, NombreFav);

            }

            if (RB_versiculo.Checked)
            {
                EDB_AgregarFavorito.Agregar_referencia(id_idioma, id_version, id_testamento, id_libro, id_capitulo, id_versiculo);

                INT_id_referencia = EDB_AgregarFavorito.Buscar_referencia(id_idioma, id_version, id_testamento, id_libro, id_capitulo, id_versiculo);

                B_favorito = EDB_AgregarFavorito.Agregar_fav(usuarioActualId, INT_id_referencia, NombreFav);

            }

            if (B_favorito)
            {
                MessageBox.Show("Se ha agregado a favoritos con exito", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se ha podido agregar :(", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
