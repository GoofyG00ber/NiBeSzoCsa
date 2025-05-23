﻿using System;
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
                    rendeles.Ár = Math.Round(response.Content[i].TotalGrand,2);
                    rendeles.Státusz = response.Content[i].StatusName;
                    rendeles.Email = response.Content[i].UserEmail;
                    rendeles.Bvin = response.Content[i].bvin;

                    if (response.Content[i].IsPlaced == true)
                    {
                        rendelesek.Add(rendeles);
                    }
                  
                }

                dataGridView1.DataSource = rendelesek;
            }

            comboBoxStatusz.Items.Add("Received");
            comboBoxStatusz.Items.Add("Ready for Shipping");
            comboBoxStatusz.Items.Add("Ready for Payment");
            comboBoxStatusz.Items.Add("On Hold");
            comboBoxStatusz.Items.Add("Cancelled");
            comboBoxStatusz.Items.Add("Complete");

            comboBoxStatusz.SelectedIndex = 0;


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
                    string ujStatusz = comboBoxStatusz.SelectedItem.ToString();

                    // Az új státuszhoz tartozó kód beállítása
                    string statusCode = GetStatusCodeByName(ujStatusz);
                    if (string.IsNullOrEmpty(statusCode))
                    {
                        MessageBox.Show("Ismeretlen státusz.");
                        return;
                    }

                    Api proxy = apiHivas();
                    var findResponse = proxy.OrdersFind(selectedOrder.Bvin);
                    if (findResponse == null || findResponse.Content == null)
                    {
                        MessageBox.Show("Nem sikerült lekérni a rendelés részleteit.");
                        return;
                    }

                    var orderToUpdate = findResponse.Content;
                    orderToUpdate.StatusName = ujStatusz;
                    orderToUpdate.StatusCode = statusCode;

                    var updateResponse = proxy.OrdersUpdate(orderToUpdate);

                    if (updateResponse != null)
                    {
                        selectedOrder.Státusz = ujStatusz;
                        dataGridView1.Refresh();
                        MessageBox.Show("A rendelés státusza frissítve lett.");
                    }
                    else
                    {
                        MessageBox.Show("Nem sikerült frissíteni a rendelést.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Kérlek, válassz ki egy rendelést.");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                if (selectedIndex >= 0 && selectedIndex < rendelesek.Count)
                {
                    var selectedOrder = rendelesek[selectedIndex];

                    // Lekérjük a teljes rendelést az API-ból
                    Api proxy = apiHivas();
                    var response = proxy.OrdersFind(selectedOrder.Bvin);

                    if (response != null && response.Content != null)
                    {
                        listBox1.Items.Clear(); // töröljük a korábbi tételeket

                        foreach (var item in response.Content.Items)
                        {
                            listBox1.Items.Add(item.ProductName + " x" + item.Quantity + " db");
                        }
                    }
                    else
                    {
                        listBox1.Items.Clear();
                        listBox1.Items.Add("Nem sikerült lekérni a rendelés tételeit.");
                    }
                }
            }
        }

        private string GetStatusCodeByName(string statusName)
        {
            Dictionary<string, string> statuszKodok = new Dictionary<string, string>
    {
        { "Received", "F37EC405-1EC6-4a91-9AC4-6836215FBBBC" },
        { "Ready for Shipping", "0c6d4b57-3e46-4c20-9361-6b0e5827db5a" },
        { "Ready for Payment", "e42f8c28-9078-47d6-89f8-032c9a6e1cce" },
        { "On Hold", "88B5B4BE-CA7B-41a9-9242-D96ED3CA3135" },
        { "Cancelled", "A7FFDB90-C566-4cf2-93F4-D42367F359D5" },
        { "Complete", "09D7305D-BD95-48d2-A025-16ADC827582A" }
    };

            return statuszKodok.ContainsKey(statusName) ? statuszKodok[statusName] : null;
        }
    }
}
