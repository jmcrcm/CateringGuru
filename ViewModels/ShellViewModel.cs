using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace CateringGuru.ViewModels
{
    internal class ShellViewModel : Screen
    {
		private string _itemName;

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

	}
}
