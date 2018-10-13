﻿using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using System;

namespace PfBuilder.CharacterCreator
{
    public class CharacterCreatorModule : IModule
    {
        private readonly IUnityContainer _container;
        private readonly IRegionManager _regionManager;

        public CharacterCreatorModule(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }

        public void Initialize()
        {
        }
    }
}
