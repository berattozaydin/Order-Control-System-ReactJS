using OrderControlReact.Core.Src;
using OrderControlReact.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderControlReact.BLL.Managers
{
    public class OrderManager
    {
        Manager mgr;
        public OrderManager(Manager mgr)
        {
            this.mgr = mgr;
        }
        public ResponseList<ORDERS> GetAll()
        {
            var res = mgr.Db.Fetch<ORDERS>();
            if (res==null)
                return new ResponseList<ORDERS> 
                {
                    Msg="Sipariş listesi bulunamadı.",
                    Result=Response.Error
                };
            return new ResponseList<ORDERS>
            {
                List=res,
                Msg="Sipariş listesi getirildi.",
                Result=Response.Success
            };
        }
    }
}
