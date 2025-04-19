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
    public partial class UserControlKeszlet : UserControl
    {
        List<Termek> termekek = new List<Termek>();
        public UserControlKeszlet()
        {
            InitializeComponent();
        }


        private static Api apiHivas()
        {
            string url = "http://rendfejl1013.northeurope.cloudapp.azure.com/";
            string kulcs = "1-8ad6ccaf-febb-4a3c-9f6d-ed494f55ccf1";
            Api proxy = new Api(url, kulcs);
            return proxy;
        }

        private void UserControlKeszlet_Load(object sender, EventArgs e)
        {
            Api proxy = apiHivas();

            var response_product = proxy.ProductsFindAll();

            if (response_product == null || response_product.Content == null || response_product.Content.Count == 0)
            {
                MessageBox.Show("Nem sikerült lekérni a termékeket vagy nincs adat.");
                return;
            }
            else
            {

                for (int i = 0; i < response_product.Content.Count; i++)
                {
                    Termek termek = new Termek();
                    termek.Név = response_product.Content[i].ProductName;
                    termek.BeszerzésiÁr = response_product.Content[i].SiteCost;

                    var keszlet = proxy.ProductInventoryFindForProduct(response_product.Content[i].Bvin);
                    termek.Raktáron = keszlet.Content[0].QuantityOnHand;
                    termek.MinimálisMennyiség = keszlet.Content[0].LowStockPoint;
                    
                    
                    if (keszlet.Content[0].LowStockPoint == 1)
                    {
                        termek.OptimálisMennyiség = 3;
                    }
                    else if (keszlet.Content[0].LowStockPoint == 5)
                    {
                        termek.OptimálisMennyiség = 10;
                    }
                    else if (keszlet.Content[0].LowStockPoint == 15)
                    {
                        termek.OptimálisMennyiség = 30;
                    }
                    else if (keszlet.Content[0].LowStockPoint == 50)
                    {
                        termek.OptimálisMennyiség = 100;
                    }
                    else
                    {
                        termek.OptimálisMennyiség = 300;
                    }


                    if (termek.OptimálisMennyiség > termek.Raktáron)
                    {
                        termek.OptimálishozSzükségesFt = (termek.OptimálisMennyiség - termek.Raktáron) * termek.BeszerzésiÁr;
                    }
                    else
                    {
                        termek.OptimálishozSzükségesFt = 0;
                    }


                        termekek.Add(termek);
                }

                dataGridView1.DataSource = termekek;

            }
        }
    }


}
