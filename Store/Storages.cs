using System.Data;

namespace Store
{
    public partial class Storages : Form
    {
        private bool newRowAdding = false;
        DataForForms DATA = new DataForForms();

        public Storages()
        {
            InitializeComponent();
        }

        private void Storages_Load(object sender, EventArgs e)
        {
            var queryString = "Select *, 'Удалить' as Command from storages";
            DATA.LoadData(queryString, dataGridView1);
        }

        private void buttReload_Click(object sender, EventArgs e)
        {
            DATA.ReloadData(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DATA.CellContentClick(e, dataGridView1, ref newRowAdding);
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DATA.UserAddedRow(dataGridView1, ref newRowAdding);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DATA.CellValueChanged(dataGridView1, newRowAdding);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("CONVERT(storage_code, System.String) LIKE '%{0}%' OR Convert(storage_max_capacity, System.String) LIKE '%{0}%'", tbSearch.Text);
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DATA.EditingControlShowing(e, dataGridView1);
        }
    }
}
