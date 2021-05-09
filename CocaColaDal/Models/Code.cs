using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocaColaDal.Models
{
    public class Code
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Used{ get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
