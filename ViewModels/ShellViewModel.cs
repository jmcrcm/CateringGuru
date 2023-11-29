using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using CateringGuru.Models;

namespace CateringGuru.ViewModels
{
    internal class ShellViewModel : Screen
    {
		private string _itemName;
        private BindableCollection<MenuModel> _menu = new BindableCollection<MenuModel>();
        private MenuModel _selectedItem;

        public ShellViewModel()
        {
			FoodMenu.Add(new MenuModel { ItemName = "Chicken & Shrimp", ItemPrice = 63.00 });
            FoodMenu.Add(new MenuModel { ItemName = "NY Steak & Chicken", ItemPrice = 66.00 });
            FoodMenu.Add(new MenuModel { ItemName = "NY Steak & Shrimp", ItemPrice = 68.00 });
            FoodMenu.Add(new MenuModel { ItemName = "NY Steak, Chicken & Shrimp", ItemPrice = 75.00 });
            FoodMenu.Add(new MenuModel { ItemName = "NY Steak & Lobster", ItemPrice = 80.00 });
            FoodMenu.Add(new MenuModel { ItemName = "Fillet Mignon 6 oz", ItemPrice = 67.00 });
            FoodMenu.Add(new MenuModel { ItemName = "Fillet Mignon & Shrimp", ItemPrice = 74.00 });
            FoodMenu.Add(new MenuModel { ItemName = "Fillet Mignon & Scallops", ItemPrice = 77.00 });
            FoodMenu.Add(new MenuModel { ItemName = "Fillet Mignon & Lobster", ItemPrice = 84.00 });
            FoodMenu.Add(new MenuModel { ItemName = "Fillet Mignon & Salmon", ItemPrice = 76.00 });
        }

        public string ItemName
		{
			get 
			{ 
				return _itemName; 
			}
			set 
			{ 
				_itemName = value; 
			}
		}
		
		public BindableCollection<MenuModel> FoodMenu
		{
			get { return _menu; }
			set { _menu = value; }
		}

		public MenuModel SelectedItem
		{
			get { return _selectedItem; }
			set 
			{ 
				_selectedItem = value;
				NotifyOfPropertyChange(() => SelectedItem);
			}
		}

	}
}
