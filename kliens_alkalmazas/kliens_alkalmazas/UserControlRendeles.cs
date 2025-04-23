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
using Hotcakes.CommerceDTO.v1.Orders;
using Hotcakes.CommerceDTO.v1;
using System.Runtime.Remoting.Proxies;

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
                    rendeles.RendelésSzám = response.Content[i].OrderNumber;
                    rendeles.Dátum = response.Content[i].TimeOfOrderUtc;
                    rendeles.Ár = response.Content[i].TotalGrand;
                    rendeles.Státusz = response.Content[i].StatusName;
                    rendeles.Email = response.Content[i].UserEmail;
                    rendeles.Bvin = response.Content[i].bvin;

                    if (response.Content[i].IsPlaced == true)
                    {
                        rendelesek.Add(rendeles);
                    }
                  
                }

                dataGridView1.DataSource = rendelesek;

                //var orderid = response.Content[20].bvin.ToLower();
                //var response2 = proxy.OrdersFind(orderid);

                //listBox1.Items.Add(response2.Content.Items[1].ProductName);
            }


        }

        private static Api apiHivas()
        {
            string url = "http://rendfejl1013.northeurope.cloudapp.azure.com/";
            string kulcs = "1-8ad6ccaf-febb-4a3c-9f6d-ed494f55ccf1";
            Api proxy = new Api(url, kulcs);
            return proxy;
        }

        private void buttonSzallitas_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                if (selectedIndex >= 0 && selectedIndex < rendelesek.Count)
                {
                    Rendeles selectedOrder = rendelesek[selectedIndex];

                    if (selectedOrder.Státusz == "Received")
                    {
                        Api proxy = apiHivas();

                        // Lekérjük az eredeti rendelést az API-ból a teljes adattal
                        var findResponse = proxy.OrdersFind(selectedOrder.Bvin);
                        if (findResponse == null || findResponse.Content == null)
                        {
                            MessageBox.Show("Nem sikerült lekérni a rendelés részleteit.");
                            return;
                        }

                        var orderToUpdate = findResponse.Content;
                        orderToUpdate.StatusCode = "0c6d4b57-3e46-4c20-9361-6b0e5827db5a";
                        orderToUpdate.StatusName = "Ready for Shipping";

                        var updateResponse = proxy.OrdersUpdate(orderToUpdate);

                        if (updateResponse != null)
                        {
                            // Lokálisan is frissítjük a státuszt
                            selectedOrder.Státusz = "Ready for Shipping";
                            dataGridView1.Refresh();

                            MessageBox.Show("A rendelés státusza sikeresen frissítve lett.");
                        }
                        else
                        {
                            MessageBox.Show("Nem sikerült frissíteni a rendelést az API-n keresztül.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ez a rendelés nem 'Received' státuszú.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Kérlek, válassz ki egy rendelést.");
            }
        }
    }
}
