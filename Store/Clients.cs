using System.Data;

namespace Store
{
    public partial class Clients : Form
    {
        private bool newRowAdding = false;
        DataForForms DATA = new DataForForms();

        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            var queryString = "Select *, 'Удалить' as Command from clients";
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
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("CONVERT(client_id, System.String) LIKE '%{0}%' OR surname LIKE '%{0}%' OR firstname LIKE '%{0}%' OR lastname LIKE '%{0}%' OR client_phone_number LIKE '%{0}%' OR client_adress LIKE '%{0}%'", tbSearch.Text);
        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DATA.EditingControlShowing(e, dataGridView1);
        }
    }
}
