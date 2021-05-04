using System;
using Microsoft.AspNetCore.Mvc;

[CacheResource]
public class CachedController : Controller
{
    public IActionResult Index()
    {
        return Content("This content was generated at " + DateTime.Now);
    }
}