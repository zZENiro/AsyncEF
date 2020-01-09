using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using AsyncEF.DatabaseContext;

namespace AsyncEF
{
    public static class DatabaseAPI
    {
        public static async Task<Order> GetOrdersAsync()
        {
            List<Order> orders = null;
            Order order = null;

            using (OrdersContext c = new OrdersContext())
            {
                await Task.Factory.StartNew(new Action(() =>
                {
                    orders = c.Orders
                    .Include(client => client.Client)
                    .Include(item => item.Item)
                    .Include(customer => customer.Customer).ToList();

                    foreach (var _order in orders)
                    {
                        if (_order.OrderId == 11)
                        {
                            order = _order;
                        }
                    }
                }));
            }

            return order;
        }
    }
}
