using Microsoft.Practices.Unity;
using PfBuilder.Infrastructure.ViewModel;
using PfBuilder.Repository.Repositories;
using Prism.Commands;

namespace PfBuilder.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        private IUnityContainer _unityContainer;

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
            var testChar = charRepository.LoadEntity(1);
            Title = testChar.Name;
        }
    }
}
