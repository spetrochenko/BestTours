﻿using BT.BusinessLogic.Interface;
using BT.BusinessLogic.Services;
using Ninject.Modules;

namespace BT.BusinessLogic.Dependency
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ITourService>().To<TourService>();
        }
    }
}