namespace MyMVCApp.Models
{
    public class AnimalViewModel
    {
        public AnimalViewModel(DogViewModel dog, CatViewModel cat)
        {
            this.dog = dog;
            this.cat = cat;
        }

        public DogViewModel dog { get; set; }
        public CatViewModel cat { get; set; }
    }
}
