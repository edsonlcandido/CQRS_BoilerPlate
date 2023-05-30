using CQRS_Case.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Case.Commands
{
    public class CreateUserCommand
    {
        public UserModel User { get; set; }
    }
}
