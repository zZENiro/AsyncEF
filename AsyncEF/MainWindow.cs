using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using AsyncEF.DatabaseContext;

namespace AsyncEF
{
    public partial class MainWindow : Form
    {
        Thread t_db;
        int _lockState = 0;
        DataSet _dataSet;

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void InitializeListCallback(object context)
        {
            if (Interlocked.Exchange(ref _lockState, 1) == 0)
            {
                var cont = context as SynchronizationContext;

                Order order = await DatabaseAPI.GetOrdersAsync();

                cont.Send(InitializeList, order);
                Interlocked.Exchange(ref _lockState, 0);
            }
        }

        private void InitializeList(object obj)
        {
            MessageBox.Show("Got Order", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Запускаю поток инициализиоования объектов
        private void btn_init_Click(object sender, EventArgs e)
        {
            var _context = SynchronizationContext.Current;

            t_db = new Thread(new ParameterizedThreadStart(InitializeListCallback));
            t_db.Start();
        }
    }
}
