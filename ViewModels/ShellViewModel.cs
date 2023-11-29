using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using CateringGuru.Models;

namespace CateringGuru.ViewModels
{
    internal class ShellViewModel : Conductor<Object>
    {
		private string _itemName;
        private BindableCollection<MenuModel> _menu = new BindableCollection<MenuModel>();
        private MenuModel _selectedItem;

        public ShellViewModel()
        {
			FoodMenu.Add(new MenuModel { ItemName = "Chicken & Shrimp", ItemPrice = 63.00m });
            FoodMenu.Add(new MenuModel { ItemName = "NY Steak & Chicken", ItemPrice = 66.00m });
            FoodMenu.Add(new MenuModel { ItemName = "NY Steak & Shrimp", ItemPrice = 68.00m });
            FoodMenu.Add(new MenuModel { ItemName = "NY Steak, Chicken & Shrimp", ItemPrice = 75.00m });
            FoodMenu.Add(new MenuModel { ItemName = "NY Steak & Lobster", ItemPrice = 80.00m });
            FoodMenu.Add(new MenuModel { ItemName = "Fillet Mignon 6 oz", ItemPrice = 67.00m });
            FoodMenu.Add(new MenuModel { ItemName = "Fillet Mignon & Shrimp", ItemPrice = 74.00m });
            FoodMenu.Add(new MenuModel { ItemName = "Fillet Mignon & Scallops", ItemPrice = 77.00m });
            FoodMenu.Add(new MenuModel { ItemName = "Fillet Mignon & Lobster", ItemPrice = 84.00m });
            FoodMenu.Add(new MenuModel { ItemName = "Fillet Mignon & Salmon", ItemPrice = 76.00m });
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

		public void LoadQuoteForm()
		{
			ActivateItemAsync(new QuoteFormViewModel());
		}

		public void LoadInvoiceForm()
		{
			ActivateItemAsync(new InvoiceFormViewModel());
		}
	}
}
