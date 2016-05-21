using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interface
{
    public class SubMenu : MenuItem
    {
        protected MenuItemList menu;
        public SubMenu(string name, MenuItemList menu) : base(name) { this.menu = menu; }
        public override void DoAction() { menu.Run(); }
    }
}