// Models/SharedData.cs
namespace ChartControls.Models;

public static class SharedData
{
    public static List<LayoutData> SalesData =>
    [
        new LayoutData{ Period = "Jan", OnlineSale = 45, RetailSale = 55 },
        new LayoutData{ Period = "Feb", OnlineSale = 50, RetailSale = 60 },
        new LayoutData{ Period = "Mar", OnlineSale = 80, RetailSale = 45 },
        new LayoutData{ Period = "Apr", OnlineSale = 40, RetailSale = 70 },
        new LayoutData{ Period = "May", OnlineSale = 75, RetailSale = 30 },
        new LayoutData{ Period = "Jun", OnlineSale = 85, RetailSale = 25 },
        new LayoutData{ Period = "Jul", OnlineSale = 60, RetailSale = 40 },
        new LayoutData{ Period = "Aug", OnlineSale = 55, RetailSale = 65 },
        new LayoutData{ Period = "Sep", OnlineSale = 70, RetailSale = 50 },
        new LayoutData{ Period = "Oct", OnlineSale = 60, RetailSale = 50 },
        new LayoutData{ Period = "Nov", OnlineSale = 65, RetailSale = 55 },
        new LayoutData{ Period = "Dec", OnlineSale = 90, RetailSale = 35 }

    ];
}

public class LayoutData
{
    public string Period { get; set; }
    public int OnlineSale { get; set; }
    public int RetailSale { get; set; }
}
