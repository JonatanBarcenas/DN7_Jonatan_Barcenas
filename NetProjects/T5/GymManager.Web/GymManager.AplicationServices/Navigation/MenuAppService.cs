using GymManager.Core.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.AplicationServices.Navigation
{
    public class MenuAppService : IMenuAppService
    {
        public List<UserMenuItem> GetMenu()
        {
           List<UserMenuItem> menu = new List<UserMenuItem>();
            menu.Add(new UserMenuItem
            {
                Name = "Home",
                DisplayName= "Home",
                Order= 0,
                Url = "/"
            });

            menu.Add(new UserMenuItem
            {
                Name = "Administration",
                DisplayName= "Administration",
                Order = 1,
                Url = "#",
                Items= new List<UserMenuItem>()
                {
                    new UserMenuItem
                    {
                        Name= "MembershipTypes",
                        DisplayName = "Membership types",
                        Order= 0,
                        Url= "/MembershipTypes"
                    },
                    new UserMenuItem
                    {
                        Name = "InventoryUnits",
                        DisplayName = "Inventory Units",
                        Order= 1,
                        Url= "/InventoryUnits/",
                    },

                    new UserMenuItem
                    {
                        Name = "EquipmentTypes",
                        DisplayName = "Equipment Types",
                        Order= 2,
                        Url= "/EquipmentTypes/",
                    },

                    new UserMenuItem
                    {
                        Name = "EquipmentInventory",
                        DisplayName = "Equipment Inventory",
                        Order= 3,
                        Url= "/EquipmentInventory/",
                    }

                }
            });

            menu.Add(new UserMenuItem
            {
                Name = "Store",
                DisplayName= "Store",
                Order = 2,
                Url= "#",
                Items= new List<UserMenuItem>() 
                { 
                new UserMenuItem
                {
                    Name = "Shopping",
                    DisplayName = "Shopping",
                    Order= 0,
                    Url= "/Shopping/",
                }
                }
            });
        }
    }
}
