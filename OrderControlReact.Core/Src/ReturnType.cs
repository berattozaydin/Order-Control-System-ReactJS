using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderControlReact.Core.Src
{
    public class ResponseSingle : ResponseSingle<object>
    {

    }

    public class ResponseList : ResponseList<object>
    {

    }


    public class ResponseSingle<T>
    {
        public Response Result { get; set; }
        public T Single { get; set; }
        public string Msg { get; set; }
    }

    public class ResponseList<T>
    {
        public Response Result { get; set; }
        public ICollection<T> List { get; set; }
        public string Msg { get; set; }
    }
    public enum Response
    {
        Success = 0,
        Warning = 1,
        Error = 2
    }
}
