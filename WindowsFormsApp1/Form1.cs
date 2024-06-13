using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourNamespace
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            cbMethod.SelectedIndex = 0;
        }
        
        private async void button2_Click(object sender, EventArgs e)
        {
             

            switch(cbMethod.SelectedItem.ToString())
            {
                case "GET":
                    {
                        REST_core.clsRespond r = await REST_core.GET_API.SendGetRequest(txtURL.Text.Trim());
                        txtResponse.Text = r.body;
                        lblStatus.Text = r.code.ToString();
                        break;
                    }
                case "POST":
                    {
                        REST_core.clsRespond r = 
                            await REST_core.POST_API.SendPostRequest(txtURL.Text.Trim(), txtReqBody.Text.Trim());
                        txtResponse.Text = r.body;
                        lblStatus.Text = r.code.ToString();
                        break;
                    }
                case "PUT":
                    {
                        REST_core.clsRespond r =
                            await REST_core.PUT_API.SendPutRequest(txtURL.Text.Trim(), txtReqBody.Text.Trim());
                        txtResponse.Text = r.body;
                        lblStatus.Text = r.code.ToString();
                        break;
                    }
                case "PATCH":
                    {
                        REST_core.clsRespond r =
                            await REST_core.PATCH_API.SendPatchRequest(txtURL.Text.Trim(), txtReqBody.Text.Trim());
                        txtResponse.Text = r.body;
                        lblStatus.Text = r.code.ToString();
                        break;
                    }
                case "DELETE":
                    {
                        REST_core.clsRespond r =
                            await REST_core.DELETE_API.SendDeleteRequest(txtURL.Text.Trim());
                        txtResponse.Text = r.body;
                        lblStatus.Text = r.code.ToString();
                        break;
                    }
            }







        }
        
    }
}