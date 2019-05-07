using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PieShop.Models;

namespace PieShop.ViewModels
{
    public class HomeViewModels
    {
        public string Title { get; set; }
        public List<Pie> Pies { get; set; }
    }
}
