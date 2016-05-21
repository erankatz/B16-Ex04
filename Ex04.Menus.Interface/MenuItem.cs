using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interface
{
    public class MenuItem
    {
        protected string m_name, m_desc;
        public MenuItem(string i_name, string i_desc) { m_name = i_name; m_desc = i_desc; }
        public MenuItem(string i_name) { m_name = i_name; m_desc = i_name; }
        public string Name { get { return m_name; } }
        public string Description { get { return m_desc; } }
        public virtual void DoAction() { Console.WriteLine("\n" + Description); }
    }
}