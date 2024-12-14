using System.Data;

namespace Store
{
    internal class DataForForms
    {
        WorkWithDB DB = new WorkWithDB();
        DataTable data = null;
        int colNum;
        

        public DataGridView LoadData(string queryString, DataGridView dataGridView)
        {
            try
            {
                data = DB.LoadDataFromDB(queryString);
                dataGridView.DataSource = data;
                colNum = dataGridView.ColumnCount - 1;
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView[colNum, i] = linkCell;
                }
                return dataGridView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataGridView ReloadData(DataGridView dataGridView)
        {
            try
            {
                data = DB.ReloadDataFromDB();
                dataGridView.DataSource = data;
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView[colNum, i] = linkCell;
                }
                return dataGridView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataGridView UserAddedRow(DataGridView dataGridView, ref bool newRowAdding)
        {
            try
            {
                if (newRowAdding == false)
                {
                    newRowAdding = true;
                    int lastRow = dataGridView.Rows.Count - 2;
                    DataGridViewRow row = dataGridView.Rows[lastRow];
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView[colNum, lastRow] = linkCell;
                    row.Cells["Command"].Value = "Добавить";
                }
                return dataGridView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataGridView CellValueChanged(DataGridView dataGridView, bool newRowAdding)
        {
            try
            {
                if (newRowAdding == false)
                {
                    int rowIndex = dataGridView.SelectedCells[0].RowIndex;
                    DataGridViewRow editingRow = dataGridView.Rows[rowIndex];
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView[colNum, rowIndex] = linkCell;
                    editingRow.Cells["Command"].Value = "Изменить";
                }
                return dataGridView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataGridView CellContentClick(DataGridViewCellEventArgs e, DataGridView dataGridView, ref bool newRowAdding)
        {
            try
            {
                if (e.ColumnIndex == colNum)
                {
                    string task = dataGridView.Rows[e.RowIndex].Cells[colNum].Value.ToString();

                    if (task == "Удалить")
                    {
                        if (MessageBox.Show("Вы уверены, что хотите удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;
                            dataGridView.Rows.RemoveAt(rowIndex);

                            data.Rows[rowIndex].Delete();

                            DB.UpdateDatainDB();
                        }
                    }
                    else if (task == "Добавить")
                    {
                        int rowIndex = dataGridView.Rows.Count - 2;

                        DataRow row = data.NewRow();

                        for (int i = 1; i < data.Columns.Count - 1; i++) 
                        {
                            string cellName = dataGridView.Columns[i].HeaderText.ToString();
                            row[$"{cellName}"] = dataGridView.Rows[rowIndex].Cells[$"{cellName}"].Value;
                        }

                        data.Rows.Add(row);
                        data.Rows.RemoveAt(data.Rows.Count - 1);

                        dataGridView.Rows.RemoveAt(dataGridView.Rows.Count - 2);
                        dataGridView.Rows[e.RowIndex].Cells[colNum].Value = "Удалить";

                        DB.UpdateDatainDB();
                        newRowAdding = false;
                    }
                    else if (task == "Изменить")
                    {
                        int rI = e.RowIndex;

                        for (int i = 1; i < data.Columns.Count - 1; i++)
                        {
                            string cellName = dataGridView.Columns[i].HeaderText.ToString();
                            data.Rows[rI][$"{cellName}"] = dataGridView.Rows[rI].Cells[$"{cellName}"].Value;
                        }

                        DB.UpdateDatainDB();

                        dataGridView.Rows[e.RowIndex].Cells[colNum].Value = "Удалить";
                    }
                    else if (task == "Отчёт")
                    {
                        MakeReport report = new MakeReport();
                        report.MakeRoportOrder(data, e);
                    }
                    DB.ReloadDataFromDB();
                }
                return dataGridView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void AddOrder(string[] dataForInv, List<string[]> allDataForPacks)
        {

            try
            {
                var DBI= new WorkWithDB();
                var dataInv = DBI.LoadDataFromDB("select * from invoices");

                DataRow row = dataInv.NewRow();

                for (int i = 2; i < dataInv.Columns.Count; i++)
                {
                    row[i] = dataForInv[i - 2];
                }

                dataInv.Rows.Add(row);

                DBI.UpdateDatainDB();

                DBI = new WorkWithDB();
                var idInvDT = DBI.LoadDataFromDB(@"select invoice_number from invoices
                    order by invoice_number desc 
                    limit 1");
                string idInv = idInvDT.Rows[0][0].ToString();

                for (int i = 0; i < allDataForPacks.Count; i++)
                {
                    var DBP = new WorkWithDB();
                    var dataPack = DBP.LoadDataFromDB("select * from product_packs");

                    DataRow rowPack = dataPack.NewRow();

                    rowPack[0] = idInv;
                    for (int j = 1; j <= allDataForPacks[i].Length; j++)
                    {
                        rowPack[j] = allDataForPacks[i][j - 1];
                    }

                    dataPack.Rows.Add(rowPack);

                    DBP.UpdateDatainDB();
                }

                MessageBox.Show("Заказ успешно добавлен", "Новый заказ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EditingControlShowing(DataGridViewEditingControlShowingEventArgs e, DataGridView dataGridView)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(ColumnKeyPress);

            var inds = new List<int>();

            var clmnInd = dataGridView.CurrentCell.ColumnIndex;

            var str = dataGridView.Columns[clmnInd].ValueType.ToString();

            if (str == "System.Int64")
            {
                var ind = dataGridView.CurrentCell.ColumnIndex;
                inds.Add(ind);
            }

            foreach (var i in inds)
            {
                var tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(ColumnKeyPress);
                }
            }
        }

        private void ColumnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void ShowFormIfNotExists<T>(T form = null) where T : Form, new()
        {
            if (form == null)
            {
                form = new T();
            }

            if (Application.OpenForms.OfType<T>().Count() == 0)
            {
                form.Show();
            }
            else
            {
                Application.OpenForms.OfType<T>().First().Activate();
            }
        }
    }
}
