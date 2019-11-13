using AutoMapper;
using CustomerManagement.Models;
using CustomerManagement.Repositories;
using CustomerManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Services
{
    public class TeaOrderService : ITeaOrderService
    {
        private readonly IMapper _mapper;
        private readonly ITeaOrderRepository _repo;
        public TeaOrderService(ITeaOrderRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public bool AddOrder(TeaOrderViewModel order)
        {
            TeaOrder orderModel = new TeaOrder();
            orderModel = _mapper.Map<TeaOrder>(order);
            orderModel.TeaOrderTeas = order.TeaIds.ToList().Select(x => new TeaOrderTea { TeaOrderId = orderModel.Id, TeaId = x }).ToList();
            return _repo.AddOrder(orderModel);
        }

        public bool DeleteOrder(string id)
        {
            throw new NotImplementedException();
        }

        public bool EditOrder(TeaOrder customer)
        {
            throw new NotImplementedException();
        }

        public TeaOrder GetOrderById(string Id)
        {
            throw new NotImplementedException();
        }

        public List<TeaOrderViewModel> GetOrders()
        {
            var viewModels = _repo.GetOrders().Select(t => new TeaOrderViewModel
            {
                Id = t.Id,
                Name = t.Name,
                Customer = t.Customer,
                TotalPrice = t.TotalPrice,
                TeaOrderTeas = t.TeaOrderTeas
            }).ToList();

            return viewModels;
        }

        public List<Tea> GetTeas()
        {
            return _repo.GetTeas();
        }
    }
}
