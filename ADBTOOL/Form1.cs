using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADBTOOL
{
    public partial class Form1 : Form
    {
        private readonly string phpUrl = "http://localhost/php-scripts/";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initialization Area.
        }

        private async Task ExecuteADBCommand(string phpScript)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(phpUrl + phpScript);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    textBoxConsole.AppendText(responseBody + Environment.NewLine);
                }
            }
            catch (HttpRequestException ex)
            {
                textBoxConsole.AppendText("Error: " + ex.Message + Environment.NewLine);
            }
        }

        private async void buttonCheckDevice_Click(object sender, EventArgs e)
        {
            await ExecuteADBCommand("check_device.php");
        }

        private async void buttonRebootFastboot_Click(object sender, EventArgs e)
        {
            await ExecuteADBCommand("reboot_fastboot.php");
        }

        private async void buttonUnlockBootloader_Click(object sender, EventArgs e)
        {
            await ExecuteADBCommand("unlock_bootloader.php");
        }

        private async void buttonReadInfo_Click(object sender, EventArgs e)
        {
            await ExecuteADBCommand("read_info.php");
        }

        private void textBoxConsole_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
