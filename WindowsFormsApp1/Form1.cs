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
            REST_core.clsRespond r = new REST_core.clsRespond();

            switch (cbMethod.SelectedItem.ToString())
            {
                case "GET":
                    {
                         r = await REST_core.GET_API.SendGetRequest(txtURL.Text.Trim());                          
                       
                        break;
                    }
                case "POST":
                    {
                        r =  await REST_core.POST_API.SendPostRequest(txtURL.Text.Trim(), txtReqBody.Text.Trim());
                        
                        break;
                    }
                case "PUT":
                    {
                         r = await REST_core.PUT_API.SendPutRequest(txtURL.Text.Trim(), txtReqBody.Text.Trim());
                       
                        break;
                    }
                case "PATCH":
                    {
                        r =await REST_core.PATCH_API.SendPatchRequest(txtURL.Text.Trim(), txtReqBody.Text.Trim());
                       
                        break;
                    }
                case "DELETE":
                    {
                        r = await REST_core.DELETE_API.SendDeleteRequest(txtURL.Text.Trim());
                       
                        break;
                    }
            }

            if (r != null)
            {
                txtResponse.Text = r.body;
                lblStatus.Text = r.code.ToString();
            }
            else
            {
                txtResponse.Text = "erro could not connect to the sever";
                lblStatus.Text = "error";
            }
         





        }
        
    }
}