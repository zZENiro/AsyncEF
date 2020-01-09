using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsyncEF.DatabaseContext;

namespace AsyncEF
{
    public static class DatabaseAPI
    {
        public static async Task<Order> GetOrdersAsync()
        {
            Order orders = null;

            using (OrdersContext c = new OrdersContext())
            {
                await Task.Factory.StartNew(new Action(() =>
                {
                    orders = c.Orders.Find(11);
                }), TaskCreationOptions.None);

            }

            //MessageBox.Show("GetOrderAsync Done!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return orders;
        }
    }
}
