using System;
using System.Data;

namespace Store
{
    public partial class ProcessApplication : Form
    {
        public string[] dataForInv = new string[3];
        public List<string[]> allDataForPacks= new List<string[]>();
        int countOfPacks;
        
        DataTable products;
        DataForForms DATA = new DataForForms();

        public ProcessApplication()
        {
            InitializeComponent();
        }

        private void buttClear_Click(object sender, EventArgs e)
        {
            tbShopCode.Clear();
            tbIdClient.Clear();
            tbOperation.Clear();
            tbProdCount.Clear();
        }

        private void tbProdCount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                panel2.Controls.Clear();
                if (tbProdCount.Text == "") { countOfPacks = 0; }
                else { countOfPacks = int.Parse(tbProdCount.Text); }

                WorkWithDB DB = new WorkWithDB();
                products = DB.LoadDataFromDB("select product_code, product_name from products");

                for (int i = 0; i < countOfPacks; i++)
                {
                    ComboBox comboBox = new ComboBox();
                    TextBox textBox = new TextBox();
                    Label label = new Label();

                    textBox.KeyPress += (s, e) =>
                    {
                        char number = e.KeyChar;

                        if (!Char.IsDigit(number) && number != 8)
                        {
                            e.Handled = true;
                        }
                    };

                    label.Width = 30;
                    label.Height = comboBox.Height;
                    label.Text = (i + 1).ToString() + ")";
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    comboBox.Width = 250;
                    textBox.Width = 50;
                    textBox.Height = comboBox.Height;
                    comboBox.Location = new Point(40, (comboBox.Height + 10) * (i));
                    textBox.Location = new Point(comboBox.Location.X + comboBox.Width + 10, comboBox.Location.Y);
                    label.Location = new Point(0, comboBox.Location.Y);

                    for (int j = 0; j < products.Rows.Count; j++)
                    {
                        var product = products.Rows[j][1];
                        comboBox.Items.Add(product);
                    }

                    panel2.Controls.Add(label);
                    panel2.Controls.Add(comboBox);
                    panel2.Controls.Add(textBox);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttRun_Click(object sender, EventArgs e)
        {
            dataForInv[0] = tbOperation.Text;
            dataForInv[1] = tbShopCode.Text;
            dataForInv[2] = tbIdClient.Text;

            var prCounts = new string[countOfPacks];
            var prNames = new string[countOfPacks];
            var prCodes = new string[countOfPacks];
            int iCounter = 0, jCounter = 0;
            foreach(Control c in panel2.Controls)
            {
                if (c is TextBox)
                {
                    prCounts[jCounter] = ((TextBox)c).Text;
                    jCounter++;
                }
                if (c is ComboBox)
                {
                    prNames[iCounter] = ((ComboBox)c).Text;
                    iCounter++;
                }
            }

            for (int i = 0; i < products.Rows.Count; i++)
            {
                for (int j = 0;j < prNames.Length;j++)
                {
                    if (products.Rows[i][1].ToString() == prNames[j])
                    {
                        prCodes[j] = products.Rows[i][0].ToString();
                        break;
                    }
                }
            }

            for (int i = 0; i < countOfPacks; i++)
            {
                string[] str = { prCodes[i], prCounts[i] };
                allDataForPacks.Add(str);
            }

            DATA.AddOrder(dataForInv, allDataForPacks);
            this.Close();
        }
    }
}
