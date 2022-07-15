using System.Diagnostics;

namespace Extractbase64
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.txt_rigths.Text = $"© {DateTime.Now.Year} Fredickzen";
        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                string folderPath = @"C:\Base64Converted\";

                if (!File.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string path = $"{folderPath}{Guid.NewGuid()}.{this.cbb_extension.Text}";

                string base64 = this.txt_base_64.Text;

                if (!string.IsNullOrEmpty(base64))
                {
                    Byte[] bytes = Convert.FromBase64String(base64);
                    File.WriteAllBytes(path, bytes);

                    //MessageBox.Show("Conversión correcta!");

                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        Arguments = folderPath,
                        FileName = "explorer.exe"
                    };

                    Process.Start(startInfo);
                }
                else
                {
                    MessageBox.Show("Debes ingresar el base64");
                }
            }
            catch (Exception)
            {
                string message = "Ha ocurrido un error, asegurate de haber ingresado datos correctos";
                MessageBox.Show(message);
            }

        }

    }
}