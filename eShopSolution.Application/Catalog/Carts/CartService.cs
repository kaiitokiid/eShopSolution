using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Carts
{
    public class CartService : ICartService
    {
        private readonly EShopDbContext _context;



        public CartService(EShopDbContext context)
        {
            _context = context;
        }
        public async Task<int> CreateOrder(CheckoutRequest request)
        {
            
            var order = new Order()
            { 
                ShipName = request.Name,
                ShipAddress = request.Address,
                ShipEmail = request.Email,
                ShipPhoneNumber = request.PhoneNumber,
                OrderDate = DateTime.Now
            };




            //var orderDetails = new List<OrderDetail>(
            //{ 
                
            //});
           

            

            _context.Orders.Add(order);
            //_context.OrderDetails.Add(orderDetail);
            
            var result = await _context.SaveChangesAsync();
            return result;
        }
    }
}
