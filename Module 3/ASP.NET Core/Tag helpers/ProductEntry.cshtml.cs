public class ProductEntryModel : PageModel
{
    [BindProperty]
    public ProductInput Product { get; set; }

    public void OnGet() { }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
            return Page();

        // Save logic here
        return RedirectToPage("Success");
    }
}
