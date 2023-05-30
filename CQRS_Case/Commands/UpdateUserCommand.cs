using CQRS_Case.Models;

namespace CQRS_Case.Commands
{
    public class UpdateUserCommand
    {
        public int Id { get; set; }
        public UserModel User { get; set; }
    }
}
