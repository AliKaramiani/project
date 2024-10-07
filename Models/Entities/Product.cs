using System.ComponentModel.DataAnnotations;

public class Product
{
    [Key]
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Barcode { get; set; }
    public int Price { get; set; }
    public int QuantityExist { get; set; }
    public int QuantitySold { get; set; }
    public int SaleDate { get; set; }
}