using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAspNetMvcCore.ViewComponents
{
    [ViewComponent(Name = "Carrinho")]
    public class CarrinhoViewComponent : ViewComponent
    {
        public int quantidade;

        public CarrinhoViewComponent()
        {
            quantidade = 3;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(quantidade);
        }
    }
}
