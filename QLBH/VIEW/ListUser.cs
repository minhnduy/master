using System.Data.Entity;

namespace QLBH.VIEW
{
    public partial class ListUser : DevExpress.XtraEditors.XtraForm
    {
        public ListUser()
        {
            InitializeComponent();
            QLBH.MODEL.QLBHDbContext dbContext = new QLBH.MODEL.QLBHDbContext();
            dbContext.Users.LoadAsync().ContinueWith(loadTask =>
            {
                usersBindingSource.DataSource = dbContext.Users.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}