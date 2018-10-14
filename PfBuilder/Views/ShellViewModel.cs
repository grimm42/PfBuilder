using Microsoft.Practices.Unity;
using PfBuilder.Infrastructure.Enums;
using PfBuilder.Infrastructure.ViewModel;
using PfBuilder.Models.Entities;
using PfBuilder.Repository.Repositories;
using Prism.Commands;
using Prism.Regions;

namespace PfBuilder.Views
{
    public class ShellViewModel : ViewModelBase
    {
        private readonly IUnityContainer _unityContainer;
        private readonly IRegionManager _regionManager;

        //public DelegateCommand<string> ShellLoadedCommand { get; set; }

        public ShellViewModel(IUnityContainer unityContainer, IRegionManager regionManager)
        {
            _unityContainer = unityContainer;
            _regionManager = regionManager;

            //ShellLoadedCommand = new DelegateCommand<string>(ShellLoaded);
            //Title = "Wait For it....";
        }

        //private void CreateCharacter(string path)
        //{
            
        //    //var charRepository = new CharacterRepository();
        //    //var testChar = charRepository.LoadEntity(2);
        //    //charRepository.Delete(testChar);
        //    //Title = testChar.Name;
        //    //var testChar = new Character
        //    //{
        //    //    Name = "Grimm Test",
        //    //    Player = "Nick",
        //    //    Age = 25,
        //    //    Gender = EnumUtil.GenderType.Male,
        //    //    Alignment = EnumUtil.AlignmentType.ChaoticNeutral
        //    //};
        //    //charRepository.Insert(testChar);
        //    //var testChar2 = charRepository.LoadEntity(5);
        //    //Title = testChar2.Name;
        //    //Title = "success";
        //}
    }
}
