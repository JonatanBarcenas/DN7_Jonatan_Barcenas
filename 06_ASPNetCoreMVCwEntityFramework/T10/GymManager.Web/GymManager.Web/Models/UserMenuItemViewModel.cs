﻿using GymManager.Core.Navigation;

namespace GymManager.Web.Models
{
    public class UserMenuItemViewModel
    {
        public UserMenuItem MenuItem { get; set; }
        public string CurrentPageName { get; set; }
        public int ItemDeph { get; set; }
        public bool RootLevel { get; set; }
    }
}