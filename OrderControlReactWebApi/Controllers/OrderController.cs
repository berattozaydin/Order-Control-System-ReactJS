using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderControlReact.BLL.Managers;
using OrderControlReact.Core.Src;
using OrderControlReact.Dal;

namespace OrderControlReactWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    
    public class OrderController : ControllerBase
    {
        OrderManager orderManager;
        public OrderController(OrderManager orderManager)
        {
            this.orderManager=orderManager;
        }
        [HttpGet]
        public ResponseList<ORDERS> GetAll()
        {
            return orderManager.GetAll();
        }
    }
}
