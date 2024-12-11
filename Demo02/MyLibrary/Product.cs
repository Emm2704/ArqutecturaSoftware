namespace MyLibrary
{
    public class Product
    {
        //Propiedades
        public int Id { get; }
        public string Name { get; }
        public decimal UnitPrice { get; }
        public int UnitsInStock { get; }

        //Contructor

        public Product(int Id, string name, decimal unitPrice, int unitsInStock) 
        {
            Id = Id;
            Name = name;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
        }
    }
}
