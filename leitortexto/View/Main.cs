using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leitortexto.View
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string endereco = @"C:\senac\teste007.txt";

            try
            {
                if (!System.IO.File.Exists(endereco))
                {
                    throw new Exception(
                        "Arquivo teste007.txt não foi localizado."
                        );
                }

                string[] dados = new string[4];

                System.IO.StreamReader Leitor = new System.IO.StreamReader(endereco);

                lbxReultado.Items.Add(
                    "Código".PadRight(7) +
                    "Cliente".PadRight(40) +
                    "Cidade".PadRight(20) +
                    "Pais"
                    );
                lbxReultado.Items.Add(new string('-', 80));

                while (!Leitor.EndOfStream)
                {
                    dados = Leitor.ReadLine().Split(';');

                    lbxReultado.Items.Add(
                        dados[0].PadRight(7) +
                        dados[1].PadRight(40) +
                        dados[2].PadRight(20) +
                        dados[3]);
                }

                Leitor.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Alerta de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw;
            }
        }
    }
}
