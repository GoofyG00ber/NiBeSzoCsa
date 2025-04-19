using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotcakes.CommerceDTO.v1.Client;

namespace kliens_alkalmazas
{
    public partial class UserControlRendeles : UserControl
    {
        List<Rendeles> rendelesek = new List<Rendeles>();
        public UserControlRendeles()
        {
            InitializeComponent();
        }

        private void UserControlRendeles_Load(object sender, EventArgs e)
        {
            Api proxy = apiHivas();

            var response = proxy.OrdersFindAll();

            if (response == null || response.Content == null || response.Content.Count == 0)
            {
                MessageBox.Show("Nem sikerült lekérni a rendeléseket vagy nincs adat.");
                return;
            }
            else
            {
                for (int i = 0; i < response.Content.Count; i++)
                {
                    Rendeles rendeles = new Rendeles();
                    rendeles.Id = response.Content[i].Id;
                    rendeles.Dátum = response.Content[i].TimeOfOrderUtc;
                    rendeles.Ár = response.Content[i].TotalGrand;
                    rendeles.Státusz = response.Content[i].StatusName;

                    rendelesek.Add(rendeles);
                }

                dataGridView1.DataSource = rendelesek;

            }

        }

        private static Api apiHivas()
        {
            string url = "http://rendfejl1013.northeurope.cloudapp.azure.com/";
            string kulcs = "1-8ad6ccaf-febb-4a3c-9f6d-ed494f55ccf1";
            Api proxy = new Api(url, kulcs);
            return proxy;
        }

        
    }
}
