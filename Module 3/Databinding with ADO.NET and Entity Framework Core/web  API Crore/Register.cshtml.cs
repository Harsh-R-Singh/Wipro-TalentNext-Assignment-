public class RegisterModel : PageModel
{
    [BindProperty]
    public UserInput User { get; set; }

    public async Task<IActionResult> OnPostAsync()
    {
        var client = new HttpClient();
        var response = await client.PostAsJsonAsync("https://yourapi/api/auth/register", User);

        if (response.IsSuccessStatusCode)
            ViewData["Message"] = "Registration successful";
        else
            ViewData["Message"] = "Registration failed";

        return Page();
    }

    public class UserInput
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
