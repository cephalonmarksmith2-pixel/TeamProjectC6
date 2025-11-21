using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProjectC6.Menu_s
{
    /// <summary>
    /// Main menu class that allows navigation to different sub-menus.
    /// </summary>
    public class MainMenu : Menu
    {

        public MainMenu()
        {
            AddItem("Exanple Menu", () =>
            {
                ExanpleMenu studentMenu = new ExanpleMenu();
                studentMenu.Run();

                // need to acturaly fix this 
            });

        }
    }
}
