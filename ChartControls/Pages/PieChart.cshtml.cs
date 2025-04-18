using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ChartControls.Models; // namespace chứa SharedData

namespace ChartControls.Pages
{
    public class PieChartModel : PageModel
    {
        public List<LayoutData> SalesData { get; set; } = SharedData.SalesData;
        public void OnGet()
        {
        }
    }
}
