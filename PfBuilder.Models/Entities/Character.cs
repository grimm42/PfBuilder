using PfBuilder.Infrastructure.Entity;
using static PfBuilder.Infrastructure.Enums.EnumUtil;

namespace PfBuilder.Models.Entities
{
    public class Character : EntityBase
    {
        public int Id { get; set; }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _player;

        public string Player
        {
            get { return _player; }
            set { SetProperty(ref _player, value); }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { SetProperty(ref _age, value); }
        }

        private GenderType _gender;

        public GenderType Gender
        {
            get { return _gender; }
            set { SetProperty(ref _gender, value); }
        }

        private AlignmentType _alignment;

        public AlignmentType Alignment
        {
            get { return _alignment; }
            set { SetProperty(ref _alignment, value); }
        }
    }
}
