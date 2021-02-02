using System.Collections.Generic;
using EShopApp.Models;

namespace EShopApp.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<CartItem> CartItems { get; set; }
        public double CartTotal { get; set; }
    }
}