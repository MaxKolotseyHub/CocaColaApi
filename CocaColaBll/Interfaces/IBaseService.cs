using CocaColaBll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocaColaBll.Interfaces
{
    public interface IBaseService
    {
        IEnumerable<UserBll>GetAll();
        IEnumerable<CodeBll> GetAllCodes();
        Task<IEnumerable<UserBll>> GetByEmail(string email);
        Task Add(UserBll model);
        CodeBll GetCodeByTitle(string title);
    }
}
