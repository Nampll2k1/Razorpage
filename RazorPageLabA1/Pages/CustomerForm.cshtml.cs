using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageLabA1.Models;

namespace RazorPageLabA1.Pages
{
    public class CustomerFormModel : PageModel
    {
        public string Mesage { get; set; }
        public Customer customerInfo { get; set; }
        public void OnPost()
        {
            if(ModelState.IsValid)
            {
                Mesage = "Information is OK";
                ModelState.Clear();
            }
            else
            {
                Mesage = "Err input data";
            }
        }
    }
}
