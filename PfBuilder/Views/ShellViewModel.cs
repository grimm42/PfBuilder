using Microsoft.Practices.Unity;
using PfBuilder.Infrastructure.Enums;
using PfBuilder.Infrastructure.ViewModel;
using PfBuilder.Models.Entities;
using PfBuilder.Repository.Repositories;
using Prism.Commands;

namespace PfBuilder.Views
{
    public class ShellViewModel : ViewModelBase
    {
        private readonly IUnityContainer _unityContainer;

        public DelegateCommand CreateCharacterCommand { get; set; }

        public ShellViewModel(IUnityContainer unityContainer)
        {
            _unityContainer = unityContainer;
            CreateCharacterCommand = new DelegateCommand(CreateCharacter);
            Title = "Wait For it....";
        }

        private void CreateCharacter()
        {
            var charRepository = new CharacterRepository();
            //var testChar = charRepository.LoadEntity(2);
            //charRepository.Delete(testChar);
            //Title = testChar.Name;
            //var testChar = new Character
            //{
            //    Name = "Grimm Test",
            //    Player = "Nick",
            //    Age = 25,
            //    Gender = EnumUtil.GenderType.Male,
            //    Alignment = EnumUtil.AlignmentType.ChaoticNeutral
            //};
            //charRepository.Insert(testChar);
            //var testChar2 = charRepository.LoadEntity(5);
            //Title = testChar2.Name;
            //Title = "success";
        }
    }
}
