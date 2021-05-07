using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocaColaDal.Models
{
    public class User
    {
        public User()
        {
            Codes = new List<Code>();
        }
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual List<Code> Codes { get; set; }
    }
}
