using System.Data;

namespace Store
{
    public partial class Staff : Form
    {
        private bool newRowAdding = false;
        DataForForms DATA = new DataForForms();

        public Staff()
        {
            InitializeComponent();
        }

        private void Drivers_Load(object sender, EventArgs e)
        {
            var queryString = @"select *, 'Удалить' as Command from staff";
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
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("CONVERT(staff_inn, System.String) LIKE '%{0}%' OR Convert(staff_post_code, System.String) LIKE '%{0}%' OR Convert(staff_shop_code, System.String) LIKE '%{0}%' OR full_name LIKE '%{0}%'", tbSearch.Text);
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DATA.EditingControlShowing(e, dataGridView1);
        }
    }
}
