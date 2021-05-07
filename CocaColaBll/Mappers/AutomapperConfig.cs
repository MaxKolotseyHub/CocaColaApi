using AutoMapper;
using CocaColaBll.Models;
using CocaColaDal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocaColaBll.Mappers
{
    internal class AutomapperConfig
    {
        private static Mapper _mapper;
        public static Mapper GetMapper()
        {
            if (_mapper == null)
            {
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<UserBll, User>().ReverseMap();
                    cfg.CreateMap<CodeBll, Code>().ReverseMap();
                });

                _mapper = new Mapper(config);
            }
            return _mapper;
        }
    }
}
