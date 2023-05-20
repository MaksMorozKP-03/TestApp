using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.ViewModels
{
    class SelectedCurrencyViewModel
    {
        private Currency currency;
        public SelectedCurrencyViewModel(Currency currency)
        {
            this.currency = currency;
        }
    }
}
