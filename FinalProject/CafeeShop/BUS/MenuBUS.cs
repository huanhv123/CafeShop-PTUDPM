using Cafee.DAO;
using Cafee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = Cafee.DTO.Menu;

namespace Cafee.BUS
{
    internal class MenuBUS
    {
        private static MenuBUS instance;

        public static MenuBUS Instance
        {
            get
            {
                if (instance == null)
                { instance = new MenuBUS(); }
                return MenuBUS.instance;
            }
            private set { MenuBUS.instance = value; }
        }
        private MenuBUS() { }
        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> menus = MenuDAO.Instance.GetListMenuByTable(id);
            return menus;
        }
        public bool UpdateBillInfo(int idBillInfo, int countFood)
        {
            return MenuDAO.Instance.UpdateBillInfo(idBillInfo,countFood);
        }
    }
}
