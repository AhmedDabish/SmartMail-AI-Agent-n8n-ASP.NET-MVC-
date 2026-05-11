using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(string email)
    {
        using var client = new HttpClient();

        var data = new { email };
        var json = JsonSerializer.Serialize(data);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await client.PostAsync(
            "https://ahmeddabish.app.n8n.cloud/webhook/summarize-email",
            content
        );

        var result = await response.Content.ReadAsStringAsync();

        string summaryText = "";

        try
        {
            using JsonDocument doc = JsonDocument.Parse(result);
            summaryText = doc.RootElement[0]
                .GetProperty("content")[0]
                .GetProperty("text")
                .GetString();
        }
        catch
        {
            summaryText = result;
        }

        // تنظيف النص
        summaryText = summaryText
            .Replace("\\n", "\n")
            .Replace("\r", "")
            .Trim();

        // إذا كان الطلب AJAX، نعيد JSON
        if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
        {
            return Ok(new { summary = summaryText });
        }

        // 아니면 عادي
        ViewBag.Result = summaryText;
        return View();
    }
}