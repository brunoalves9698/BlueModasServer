using BlueModas.Domain.Entities.Core;

namespace BlueModas.Domain.Entities
{
    public class Product : Entity
    {
        public Product(
            string title, 
            string description, 
            decimal price, 
            string image)
        {
            Title = title;
            Description = description;
            Price = price;
            Image = image;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public string Image { get; private set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
