using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Cart
{
    public class AddToCart
    {
        private ISession _sesstion;

        public AddToCart(ISession session)
        {
            _sesstion = session;
        }

        public class Request
        {
            public int StockId { get; set; }
            public int Qty { get; set; }
        }

        public void Do(Request request)
        {
            var cartProduct = new CartProduct
            {
                StockId = request.StockId,
                Qty = request.Qty
            };
            var stringObject = JsonConvert.SerializeObject(cartProduct);

            //TODO: appending the cart

            _sesstion.SetString("cart", stringObject);
        }
    }
}