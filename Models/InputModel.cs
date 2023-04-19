namespace Homework.Models
{
    public class Calculation
    {
        // Properties - Thuộc tính
        public string value0{ get; set; }
        public decimal value01 { get; set; }
        public decimal value02 { get; set; }

        // Contructor - hàm khởi tạo
        public Calculation() { }

        // Overloading contructor
        public Calculation(string Value0, decimal Value01)
        {
            Value0 = value0;
            Value01 = value01;
        }
        public Calculation(string Value0, decimal Value01, decimal Value02)
        {
            Value0 = value0;
            Value01 = value01;
            Value02 = value02;
    }
    }
}
