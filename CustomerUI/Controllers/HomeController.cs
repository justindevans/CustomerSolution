using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using CustomerAPI.Models;
using System.Diagnostics;

namespace CustomerUI.Controllers
{
    public class HomeController : Controller
    {

        private readonly HttpClient _httpClient;
        private const string ApiUrl = "https://localhost:7292/api/Customers/";

        public HomeController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync(ApiUrl);

            if (response.IsSuccessStatusCode)
            {

                var content = await response.Content.ReadAsStringAsync();
                var customers = JsonSerializer.Deserialize<List<Customer>>(content);

                return View(customers);
            }
            else
            {
                return View("Error");
            }
        }

        public IActionResult CreateCustomer()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer(Customer customer)
        {
            if (ModelState.IsValid)
            {
                var response = await _httpClient.PostAsJsonAsync(ApiUrl, customer);

                if (response.IsSuccessStatusCode)
                {
                    //TempData["SuccessMessage"] = "Customer created successfully!";
                    return RedirectToAction("Index");
                }
                else
                {                    
                    ModelState.AddModelError("", "Error creating customer. Please try again.");
                }               
            }
           
            return View(customer);
        }

        public async Task<IActionResult> EditCustomer(int id)
        {
            var response = await _httpClient.GetAsync(ApiUrl + id);

            if (response.IsSuccessStatusCode)
            {
                var customer = await response.Content.ReadFromJsonAsync<Customer>();
                return View(customer); 
            }
           
            return NotFound();
        }
       
        [HttpPost]
        public async Task<IActionResult> EditCustomer(Customer customer)
        {
            if (ModelState.IsValid)
            {                
                var response = await _httpClient.PutAsJsonAsync($"{ApiUrl}{customer.customerId}", customer);               

                if (response.IsSuccessStatusCode)
                {
                    //TempData["SuccessMessage"] = "Customer updated successfully!";                    
                    return RedirectToAction("Index");  
                }
                else
                {
                    ModelState.AddModelError("", "Error updating customer. Please try again.");
                }
            }

            return View(customer);  
        }

        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var response = await _httpClient.DeleteAsync(ApiUrl + id); 

            if (response.IsSuccessStatusCode)
            {               
                return RedirectToAction("Index");
            }
            else
            {
                // Handle failure (optional, e.g., show error message)
                ModelState.AddModelError("", "Error deleting customer. Please try again.");
                return RedirectToAction("Index");
            }
        }
    }

}
