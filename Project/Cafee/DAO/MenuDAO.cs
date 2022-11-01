using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafee.DTO;

namespace Cafee.DAO
{
    internal class MenuDAO
    {
        private static MenuDAO instance;
        public static MenuDAO Instance
        {
            get
            {
                if (instance == null)
                { instance = new MenuDAO(); }
                return MenuDAO.instance;
            }
            private set { MenuDAO.instance = value; }
        }
        private MenuDAO() { }
        private Menu newMenu(DataRow row)
        {
            Menu menu = new Menu()
            {
                foodName = row["name"].ToString(),
                count = (int)row["count"],
                price = (float)Convert.ToDouble(row["price"]),
                //float.Parse("41.00027357629127", CultureInfo.InvariantCulture.NumberFormat);
            totalPrice = (float)Convert.ToDouble(row["totalPrice"]),
            };
            return menu;
        }
        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> menus = new List<Menu>();
            DataTable data = DataProvider.Instance.ExecuteQuery(
                " select f.name, bi.count, f.price, f.price*bi.count as totalPrice " +
                "from BillInfo as bi, Bill as b, Food AS f " +
                "where bi.idBill = b.id and bi.idFood = f.id and b.status = 0  and b.idTable = " + id
                );
            foreach (DataRow row in data.Rows)
            {
                Menu item = newMenu(row);
                menus.Add(item);
            }
            return menus;
        }
    }
}
