using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Navigation
{
    public static class UserMenuItemExtensions
    {
        public static bool IsMenuActive(this UserMenuItem menuItem, string CurrentPageName)
        {
            if(menuItem.Name == CurrentPageName)
            {
                return true;

            }
            if(menuItem.Items != null)
            {
                foreach (var subMenuItem in menuItem.Items)
                {
                    if(subMenuItem.IsMenuActive(CurrentPageName))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
