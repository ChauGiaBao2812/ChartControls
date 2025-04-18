using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ChartControls.Models; // namespace chứa SharedData

namespace ChartControls.Pages;

public class IndexModel : PageModel
{
    public List<LayoutData> SalesData { get; set; } = SharedData.SalesData;
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
