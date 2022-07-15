using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class OrderDal : EfEntityRepositoryBase<Order, KontaktDbContext>, IOrderDal
    {
        public List<Order> GetOrder(int userId)
        {
            using KontaktDbContext context = new();

            var order = context.Order.Include(x=>x.Product).Include(x=>x.OrderTracking).Where(x=>x.UserId == userId).ToList();
            List<Order> orderList = new();

            for(int i =0; i< order.Count; i++)
            {
                Order orderuser = new()
                {
                    Id = order[i].Id,
                    ProductId = order[i].ProductId,
                    UserId = order[i].UserId,
                    TotalPrice = order[i].TotalPrice,
                    TotalQuantity = order[i].TotalQuantity, 
                    OrderTrackingId = order[i].OrderTrackingId,
                };
                orderList.Add(orderuser);
            }
            return orderList;
        }

        public List<OrderDTO> GetUserOrders(int userId)
        {
            using var context = new KontaktDbContext();
            
            var orderList = context.Order.Include(x => x.Product).Include(x => x.OrderTracking).Where(x => x.UserId == userId).ToList();


            List<OrderDTO> list = new();

            foreach(var orders in orderList)
            {
                OrderDTO orderDTO = new()
                {
                    UserId = orders.UserId,
                    Id = orders.Id,
                    IsDelivered = orders.IsDelivered,
                    ProductName = orders.Product.Name,
                    SKU = orders.OrderTracking.Name,
                    Status = orders.OrderTracking.Name,
                    TotalPrice = orders.TotalPrice,
                    TotalQuantity = orders.TotalQuantity,
                    OrderTrackingId=orders.OrderTrackingId,
                };
                list.Add(orderDTO);
            }

            return list;



        }
    }
}
