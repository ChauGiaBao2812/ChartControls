// Models/SharedData.cs
namespace ChartControls.Models;

public static class SharedData
{
    public static List<LayoutData> SalesData =>
    [
        new LayoutData{ Period = "Jan", OnlineSale = 36, RetailSale = 64 },
        new LayoutData{ Period = "Feb", OnlineSale = 62, RetailSale = 38 },
        new LayoutData{ Period = "Mar", OnlineSale = 81, RetailSale = 19 },
        new LayoutData{ Period = "Apr", OnlineSale = 59, RetailSale = 41 },
        new LayoutData{ Period = "May", OnlineSale = 89, RetailSale = 11 },
        new LayoutData{ Period = "Jun", OnlineSale = 72, RetailSale = 28 },
        new LayoutData{ Period = "Jul", OnlineSale = 43, RetailSale = 57 },
        new LayoutData{ Period = "Aug", OnlineSale = 46, RetailSale = 54 },
        new LayoutData{ Period = "Sep", OnlineSale = 55, RetailSale = 45 },
        new LayoutData{ Period = "Oct", OnlineSale = 63, RetailSale = 37 },
        new LayoutData{ Period = "Nov", OnlineSale = 57, RetailSale = 43 },
        new LayoutData{ Period = "Dec", OnlineSale = 80, RetailSale = 20 }
    ];
}

public class LayoutData
{
    public string Period { get; set; }
    public int OnlineSale { get; set; }
    public int RetailSale { get; set; }
}
