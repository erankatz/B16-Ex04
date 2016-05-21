using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interface
{
    public class SubMenu : MenuItem
    {
        protected MenuItemList m_menu;
        public SubMenu(string i_name, MenuItemList i_menu) : base(i_name) { m_menu = i_menu; }
        public override void DoAction() { m_menu.Run(); }
    }
}