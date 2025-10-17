public class ProductInput
{
    [Required]
    public int ProductID { get; set; }

    [Required]
    public string ProductName { get; set; }

    public string Description { get; set; }

    [Required, Range(1, int.MaxValue)]
    public int Quantity { get; set; }

    [Required, Range(0.01, double.MaxValue)]
    public decimal UnitPrice { get; set; }

    [Required, Range(1, int.MaxValue)]
    public int ReOrderLevel { get; set; }
}
