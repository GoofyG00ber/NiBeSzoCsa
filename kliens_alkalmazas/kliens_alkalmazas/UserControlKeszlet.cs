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
using System.IO;
using System.Globalization;

namespace kliens_alkalmazas
{
    public partial class UserControlKeszlet : UserControl
    {
        BindingList<Termek> termekek = new BindingList<Termek>();
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

            //termékek betöltése datagridviewba
            var response_product = proxy.ProductsFindAll();
            var beszallitok = proxy.ManufacturerFindAll();

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
                        termek.OptimálishozSzükségesDb = termek.OptimálisMennyiség - termek.Raktáron;
                    }
                    else
                    {
                        termek.OptimálishozSzükségesFt = 0;
                        termek.OptimálishozSzükségesDb = 0;
                    }

                    if (response_product.Content[i].ManufacturerId == "d579958c-9637-4680-958a-171f5ef37452")
                    {
                        termek.Beszállító = "BakeBeam Grillsütőgyártó kft.";
                    }
                    else if (response_product.Content[i].ManufacturerId == "067ff943-bb21-4f5f-bfec-1b66124df77e")
                    {
                        termek.Beszállító = "BakeBeam Mikrógyártó kft.";
                    }
                    else if (response_product.Content[i].ManufacturerId == "8e3d70b5-8050-4958-81aa-1f2f417d630e")
                    {
                        termek.Beszállító = "BakeBeam Kellékgyártó kft.";
                    }
                    else if (response_product.Content[i].ManufacturerId == "25afa805-3277-4272-8bfc-c5531289239b")
                    {
                        termek.Beszállító = "BakeBeam Airfryergyártó kft.";
                    }
                    else
                    {
                        termek.Beszállító = "BakeBeam Sütőgyártó kft.";
                    }

                    termekek.Add(termek);

                }

                dataGridView1.DataSource = termekek;

                //beszállítók betöltése listboxba


                for (int i = 0; i < beszallitok.Content.Count; i++)
                {
                    listBoxBeszallitok.Items.Add(beszallitok.Content[i].DisplayName);

                }

            }
        }
        //beszállítók szerint szűrés
        private void listBoxBeszallitok_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = listBoxBeszallitok.SelectedItem;
            if (index != null)
            {
                List<Termek> szures = new List<Termek>();
                for (int i = 0; i < termekek.Count; i++)
                {
                    if (termekek[i].Beszállító == index.ToString())
                    {
                        szures.Add(termekek[i]);

                    }
                }

                dataGridView1.DataSource = szures;

            }
        }

        private void buttonCsv_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                MessageBox.Show("Nincs exportálható adat.");
                return;
            }

            // Csak azokat a termékeket exportáljuk, ahol OptimálishozSzükségesFt > 0
            var adatok = ((IEnumerable<Termek>)dataGridView1.DataSource)
                            .Where(t => t.OptimálishozSzükségesFt > 0)
                            .ToList();

            if (adatok.Count == 0)
            {
                MessageBox.Show("Nincs olyan termék, ami exportálható lenne.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV fájl (*.csv)|*.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                        {
                            // Csak a kiválasztott oszlopok fejlécét írjuk ki
                            sw.WriteLine("Név;OptimálishozSzükségesFt;OptimálishozSzükségesDb;Beszállító");

                            foreach (var t in adatok)
                            {
                                string sor = $"{t.Név};{t.OptimálishozSzükségesFt.ToString("F2", CultureInfo.InvariantCulture)};{t.OptimálishozSzükségesDb};{t.Beszállító}";
                                sw.WriteLine(sor);
                            }
                        }

                        MessageBox.Show("Sikeres exportálás!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hiba történt az exportálás során: " + ex.Message);
                    }
                }
            }
        }

        private void buttonOsszes_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = termekek;
        }
    }
}
    


