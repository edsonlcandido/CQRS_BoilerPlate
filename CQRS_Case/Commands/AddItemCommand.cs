using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Case.Commands
{
    public class AddItemCommand
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }   
}
