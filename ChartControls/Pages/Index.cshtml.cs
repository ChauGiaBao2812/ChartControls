using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChartControls.Pages;
public class LayoutData
{
    public string? Period { get; set; }
    public double? OnlineSale { get; set; }
    public double? RetailSale { get; set; }
}
public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
