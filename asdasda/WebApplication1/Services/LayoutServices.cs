using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.DAL;
using WebApplication1.ViewModel;

namespace WebApplication1.Utilies
{
    public class LayoutServices
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _acces;
        public LayoutServices(AppDbContext context, IHttpContextAccessor acces)
        {
            _context = context;
            _acces = acces;
        }
        public Dictionary<string, string> GetSettings()
        {
            return _context.Settings.ToDictionary(p => p.Key, p => p.Value);
        }
        public int GetBasketCount()
        {
            if (_acces.HttpContext.Request.Cookies["Basket"] == null)
            {
                return 0;
            }
            List<BasketVm> basket = JsonConvert.DeserializeObject<List<BasketVm>>(_acces.HttpContext.Request.Cookies["Basket"]);
            if (basket == null)
            {
                return 0;
            }
            return basket.Sum(b => b.Count);
        }
    }
}
