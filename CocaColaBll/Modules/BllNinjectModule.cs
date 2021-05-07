using AutoMapper;
using CocaColaBll.Interfaces;
using CocaColaBll.Mappers;
using CocaColaBll.Models;
using CocaColaBll.Services;
using CocaColaDal.Context;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocaColaBll.Modules
{
    public class BllNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<CocaColaContext>().ToSelf();
            Kernel.Bind<IMapper>().ToMethod(x => AutomapperConfig.GetMapper());
            Kernel.Bind<IBaseService>().To<UserService>();
        }
    }
}
