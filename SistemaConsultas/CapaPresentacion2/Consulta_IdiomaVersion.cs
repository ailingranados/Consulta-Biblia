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
        private static DataTable DT_Capitulo;

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
            CB_testamento.Items.Clear();
            CB_versiculo.Items.Clear();
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

        private void Aceptar_Click(object sender, EventArgs e)
        {
            //limpiar campos
            label6.Text = "";
            L_capitulo.Text = "";

            if(CB_idioma.Text == "")
            {
                MessageBox.Show("Debe seleccionar un idioma", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CB_version.Text == "")
            {
                MessageBox.Show("Debe seleccionar una version", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            EnlaceDB EDB_ConsultarDGV = new EnlaceDB();

            string STR_idioma = CB_idioma.Text;

            string STR_version = CB_version.Text;

            string STR_testamento = CB_testamento.Text;

            string STR_libro = CB_libro.Text;

            string STR_capitulo = CB_capitulo.Text;

            string STR_versiculo = CB_versiculo.Text;

            int INT_versiculo;
            if (STR_versiculo == "")
            {
                INT_versiculo = 0;
                
            }
            else
            {
                
                INT_versiculo = int.Parse(STR_versiculo);
            }

            int INT_capitulo;
            if (STR_capitulo == "")
            {
                INT_capitulo = 0;
            }
            else
            {
                INT_capitulo = int.Parse(STR_capitulo);
            }
         

            int id_versionB = EDB_ConsultarDGV.Buscar_Version(STR_version);

            int id_idiomaB = EDB_ConsultarDGV.Buscar_Idioma(STR_idioma);

            int id_testamentoB = EDB_ConsultarDGV.Buscar_Testamento(STR_testamento);

            int id_libroB = EDB_ConsultarDGV.Buscar_Libro(STR_libro);

            EDB_ConsultarDGV.Agregar_referencia(id_idiomaB, id_versionB, id_testamentoB, id_libroB, INT_capitulo, INT_versiculo);

            int id_referencia = EDB_ConsultarDGV.Buscar_referencia(id_idiomaB, id_versionB, id_testamentoB, id_libroB, INT_capitulo, INT_versiculo);
            



            if ((id_testamentoB == 0) & (id_libroB == 0) & (INT_versiculo == 0) & (INT_capitulo == 0))
            {
                DT_consulta = EDB_ConsultarDGV.Consultar_IV(id_idiomaB, id_versionB);
                DGV_consulta.DataSource = DT_consulta;
            }
            else if((id_libroB == 0) & (INT_versiculo == 0) & (INT_capitulo == 0))
            {
                DT_consulta = EDB_ConsultarDGV.Consultar_IVT(id_idiomaB, id_versionB, id_testamentoB);
                DGV_consulta.DataSource = DT_consulta;
            }
            else if (INT_versiculo == 0 & (INT_capitulo == 0))
            {
                DT_consulta = EDB_ConsultarDGV.Consultar_IVTL(id_idiomaB, id_versionB, id_testamentoB, id_libroB);
                DGV_consulta.DataSource = DT_consulta;
            }
            else if (INT_versiculo == 0)
            {
                DT_consulta = EDB_ConsultarDGV.Consultar_IVTLC(id_idiomaB, id_versionB, id_testamentoB, id_libroB, INT_capitulo);
                DGV_consulta.DataSource = DT_consulta;
            }
            else
            {
                DT_consulta = EDB_ConsultarDGV.Consultar_IVTLVE(id_idiomaB, id_versionB, id_testamentoB, id_libroB, INT_capitulo, INT_versiculo);
                DGV_consulta.DataSource = DT_consulta;
            }
            
            //bool B_consulta = 
             EDB_ConsultarDGV.Insertar_consulta(id_referencia, usuarioActualId);

            //if (B_consulta)
            //{
            //    MessageBox.Show("Busqueda Realizada", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("No se ha podido agregar :(", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        public void CB_testamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_libro.Items.Clear();
            CB_versiculo.Items.Clear();

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
            CB_capitulo.Items.Clear();

            int c = 0;

            EnlaceDB EDB_ConsultarVersiculo = new EnlaceDB();
            
            string STR_libro = CB_libro.Text;

            string STR_version = CB_version.Text;

            id_version = EDB_ConsultarVersiculo.Buscar_Version(STR_version);

            id_libro = EDB_ConsultarVersiculo.Buscar_Libro(STR_libro);

            DT_Capitulo = EDB_ConsultarVersiculo.Consultar_Capitulos(id_version, id_libro);

            while (c < DT_Capitulo.Rows.Count)
            {
                CB_capitulo.Items.Add(DT_Capitulo.Rows[c]["NumeroCap"].ToString());
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
            //STR_Versiculo = DGV_consulta.CurrentRow.Cells[5].Value.ToString();
            //INT_Versiculo = int.Parse(DGV_consulta.CurrentRow.Cells[5].Value.ToString());
           
            if (int.TryParse(DGV_consulta.CurrentRow.Cells[5].Value.ToString(), out INT_Versiculo))
            {
                INT_Versiculo = int.Parse(DGV_consulta.CurrentRow.Cells[5].Value.ToString());
            }
            else
            {
                // Handle the case where CB_versiculo.Text is not a valid integer
                INT_Versiculo = 0;
            }

            
            
            if (int.TryParse(DGV_consulta.CurrentRow.Cells[4].Value.ToString(), out INT_Capitulo))
            {
                INT_Capitulo = int.Parse(DGV_consulta.CurrentRow.Cells[4].Value.ToString());
            }
            else
            {
                // Handle the case where CB_versiculo.Text is not a valid integer
                INT_Capitulo = 0;
            }

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

        private void CB_version_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //CB_versiculo.Items.Clear();
            
        }

        private void Limpiar_CB_Click(object sender, EventArgs e)
        {
            //CB_idioma.Items.Clear();
            CB_version.Items.Clear();
            CB_testamento.Items.Clear();
            CB_versiculo.Items.Clear();
            CB_libro.Items.Clear();
            CB_capitulo.Items.Clear();

            DGV_consulta.DataSource = null;
        }

        private void CB_capitulo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CB_versiculo.Items.Clear();
           

            int D = 0;

            EnlaceDB EDB_ConsultarVersiculo = new EnlaceDB();

            string STR_libro = CB_libro.Text;

            string STR_version = CB_version.Text;

            string STR_capitulo = CB_capitulo.Text;

            id_version = EDB_ConsultarVersiculo.Buscar_Version(STR_version);

            id_libro = EDB_ConsultarVersiculo.Buscar_Libro(STR_libro);

            id_capitulo = int.Parse(STR_capitulo);
 

            DT_Versiculo = EDB_ConsultarVersiculo.Consultar_Versiculos(id_version, id_libro, id_capitulo);

            while (D < DT_Versiculo.Rows.Count)
            {
                CB_versiculo.Items.Add(DT_Versiculo.Rows[D]["NumeroVers"].ToString());
                D++;
            }
        }
    }
}
