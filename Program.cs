using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BadgeItem;

namespace BadgeManager
{
    class Program
    {
        static MenuType _currentMenu = MenuType.AddBadge;
        static Dictionary<int, Badge> _listOfBadges = new Dictionary<int, Badge>();
        static void Main(string[] args)
        {
            

            RenderMainMenu();

            ConsoleKeyInfo keypressed;
            char cKeyPressed;
            bool bRun = true;

            while (bRun)
            {
                keypressed = Console.ReadKey();
                cKeyPressed = keypressed.KeyChar;
                int iPressed = 0;

                if (int.TryParse(cKeyPressed.ToString(), out iPressed))
                {
                    switch ((ExitAction)iPressed)
                    {
                        case ExitAction.Back:
                            RenderMainMenu();
                            break;
                        case ExitAction.Quit:
                            bRun = false;
                            break;
                        default:
                            MenuSelection(iPressed);
                            break;
                    }

                }
            }
        }
        public static void HandleMenuSelection(int iKeyPressed)
        {
            switch (_currentMenu)
            {
                case MenuType.AddBadge:
                {
                        Console.WriteLine("Please enter the BadgeID, Doors to be added, User for badge and then press enter.");
                        string sInput = Console.ReadLine();
                        string[] aInput = sInput.Split(',');
                        if(aInput.Length == 3)
                        {
                            Badge badge = new Badge(aInput{0},)
                        }
                    }
            }
        }
    }
}
