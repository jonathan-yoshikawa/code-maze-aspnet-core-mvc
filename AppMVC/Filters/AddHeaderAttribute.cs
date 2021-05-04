using Microsoft.AspNetCore.Mvc;

public class AddHeaderAttribute : TypeFilterAttribute
{
    public AddHeaderAttribute() : base(typeof(AddHeaderFilter))
    {
    }
}