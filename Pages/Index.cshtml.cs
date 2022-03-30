using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cautious_octo_enigma.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly BloggingContext context;

    public IndexModel(ILogger<IndexModel> logger, BloggingContext context)
    {
        _logger = logger;
        this.context = context;
    }

    public void OnGet()
    {
        // context.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
        // context.SaveChanges();
        var blog = context.Blogs.First();
    }
}
