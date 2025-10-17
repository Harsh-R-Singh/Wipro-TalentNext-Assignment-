public IActionResult Search(string query)
{
    var results = _context.Employees
        .Where(e => e.EmpName.Contains(query) || e.Designation.Contains(query))
        .ToList();
    return View(results);
}
