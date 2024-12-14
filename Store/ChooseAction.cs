using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Store
{
    public partial class ChooseAction : Form
    {
        DataForForms DATA = new DataForForms();
        public ChooseAction()
        {
            InitializeComponent();
        }

        private void buttApplication_Click(object sender, EventArgs e)
        {
            DATA.ShowFormIfNotExists<ProcessApplication>();
        }

        private void buttProducts_Click(object sender, EventArgs e)
        {
            DATA.ShowFormIfNotExists<Products>();
        }

        private void buttStaff_Click(object sender, EventArgs e)
        {
            DATA.ShowFormIfNotExists<Staff>();
        }

        private void buttPosts_Click(object sender, EventArgs e)
        {
            DATA.ShowFormIfNotExists<Posts>();
        }

        private void buttClients_Click(object sender, EventArgs e)
        {
            DATA.ShowFormIfNotExists<Clients>();
        }

        private void buttStorages_Click(object sender, EventArgs e)
        {
            DATA.ShowFormIfNotExists<Storages>();
        }

        private void buttShops_Click(object sender, EventArgs e)
        {
            DATA.ShowFormIfNotExists<Shops>();
        }
    }
}