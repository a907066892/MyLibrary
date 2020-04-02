using Microsoft.AspNetCore.Mvc;
using NetCoreData;
using NetCoreData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNetCore.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private NetCoreDbContext _context;
        public MenuViewComponent(NetCoreDbContext content) => _context = content;


        public async Task<IViewComponentResult> InvokeAsync()
        { 
            Task<List<Menu>> task = Task<List<Menu>>.Factory.StartNew(() => { return _context.Menus.ToList(); });
            return View(await task);
        }
    }
}
