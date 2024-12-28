namespace WebApi2.Model.Entities
{
    public class Product
    {   
        public Guid Id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public Boolean featured { get; set; }
        public decimal rating { get; set; } 
        public string company { get; set; }
    }
}
