using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.Models
{
    public class PlastCard
    {
        public Guid Id { get; set; }
        public string PlastCardName { get; set; }
        public string PlastCardCode { get; set; } = "0000";
        public decimal PlastCardBalance { get; set; } = 1000;
    }
}
