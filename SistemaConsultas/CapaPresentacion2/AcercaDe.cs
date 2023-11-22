using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Speech.Synthesis;

namespace CapaPresentacion2
{
    public partial class AcercaDe : Form
    {
        public AcercaDe()
        {
            InitializeComponent();
        }

        private void AcercaDe_Load(object sender, EventArgs e)
        {




           

        }
     

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia de SpeechSynthesizer
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                // Configurar la voz y otros parámetros si es necesario
                synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);

                // Narrar el texto
                synth.Speak("Diseñadores");
                synth.Speak("Ailin Elizabeth Granados Cantu");
                synth.Speak("Emily Grace Castro Chacon");
                synth.Speak("Versiones");
                synth.Speak("Visual Studio 2022");
                synth.Speak("SQL Server Managnemt Studio 19");
                
            }
        }
    }
}
