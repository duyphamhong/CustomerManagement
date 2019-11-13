using CustomerManagement.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.ViewModels
{
    public class TeaOrderViewModel : BaseViewModel
    {
        public TeaOrderViewModel() : base()
        {
            CustomerSelections = new List<SelectListItem>();
        }

        public string Name { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }

        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<SelectListItem> CustomerSelections { get; set; }

        public Guid[] TeaIds { get; set; }
        public List<SelectListItem> Teas { get; set; }

        public IList<TeaOrderTea> TeaOrderTeas { get; set; }
    }
}
