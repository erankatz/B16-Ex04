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
        protected IAction m_action;
        public MenuItem(string i_name, string i_desc) { m_name = i_name; m_desc = i_desc; }
        public MenuItem(string i_name) { m_name = i_name; m_desc = i_name; }
        public MenuItem(string i_name, IAction i_action) { m_name = i_name; m_desc = i_name; m_action = i_action; }
        public string Name { get { return m_name; } }
        public string Description { get { return m_desc; } }
        public virtual void DoAction()
        {
            bool actionFailed = false;
            do
            {
                try
                {
                    m_action.DoAction();
                }
                catch
                {
                    actionFailed = true;
                }
            } while (actionFailed != false);
        }
    }
}