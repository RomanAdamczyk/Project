
using Project.App.Common;
using Project.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.App.Concrete
{
    public class MenuActionService : BaseService<MenuAction>
    {
        public MenuActionService()
        {
            Initialize();
        }
        public List<MenuAction> GetMenuActionsByMenuName(string menuName) 
        {
            List<MenuAction> result = new List<MenuAction>();
            foreach (var menuAction in Items)
            {
                if (menuAction.MenuName == menuName)
                {
                    result.Add(menuAction);
                }
                
            }
            return result;
        }
        private void Initialize()
        {
            AddItem(new MenuAction(1, "Nowa gra", "Menu"));
            AddItem(new MenuAction(2, "Wczytaj zapisaną grę", "Menu"));
            AddItem(new MenuAction(3, "Ustawienia sterowania", "Menu"));
            AddItem(new MenuAction(4, "Instrukcja", "Menu"));

            AddItem(new MenuAction(1, "Początkujący", "NewPlayMenu"));
            AddItem(new MenuAction(2, "Zaawansowany", "NewPlayMenu"));
            AddItem(new MenuAction(3, "Ekspert", "NewPlayMenu"));

        }

    }
}
