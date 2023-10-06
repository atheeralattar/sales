public class Shop
{
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Seller> Sellers { get; set; }
    public List<Buyer> Buyers { get; set; }
    public List<Bill> Bills { get; set; }
}

public class Seller
{
    public string Name { get; set; }
    public string ContactInformation { get; set; }
}

public class Buyer
{
    public string Name { get; set; }
    public string ContactInformation { get; set; }
}

public class Bill
{
    public int Id { get; set; }
    public Buyer Buyer { get; set; }
    public Seller Seller { get; set; }
    public DateTime Date { get; set; }
    public List<BillItem> BillItems { get; set; }
}

public class BillItem
{
    public Commodity Commodity { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal Discount { get; set; }
}

public class Discount
{
    public string Name { get; set; }
    public decimal Percentage { get; set; }
}