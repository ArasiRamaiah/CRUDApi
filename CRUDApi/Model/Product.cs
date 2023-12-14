namespace CRUDApi.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Product_Name{ get; set; }
        public int Price{ get; set; }
        public int Quantity { get; set; }
        public bool IsEdible { get; set; }
    }
}
