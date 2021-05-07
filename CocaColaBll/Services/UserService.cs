using AutoMapper;
using CocaColaBll.Interfaces;
using CocaColaBll.Models;
using CocaColaDal.Context;
using CocaColaDal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace CocaColaBll.Services
{
    public class UserService : IBaseService
    {
        private readonly CocaColaContext _db;
        private readonly IMapper _mapper;

        public UserService(CocaColaContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task Add(UserBll model)
        {
            var user = _db.Users.FirstOrDefault(x => x.Email == model.Email);
            if (user == null)
                _db.Users.Add(_mapper.Map<User>(model));
            else
                user.Codes.Add(_mapper.Map<Code>(model.Codes[0]));
            await _db.SaveChangesAsync();
        }

        public IEnumerable<UserBll> GetAll()
        {
            return _mapper.Map<IEnumerable<UserBll>>(_db.Users.Include("Codes").ToList());
        }

        public async Task<IEnumerable<UserBll>> GetByEmail(string email)
        {
            return new List<UserBll> { _mapper.Map<UserBll>(await _db.Users.Include("Codes").FirstOrDefaultAsync(x => x.Email == email)) };
        }
    }
}
