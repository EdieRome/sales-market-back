namespace SalesMarket.Common.Models
{
    public class User : BaseModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}
