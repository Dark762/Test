using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class StatusResponseViewModel<T> : StatusResponseViewModel
    {
        public T Data { get; set; }
    }

    public class StatusResponseViewModel
    {
        public StatusResponseViewModel()
        {
            Messages = new List<string>();
        }
        public string Message { get; set; }
        public List<string> Messages { get; set; }
        public bool Success { get; set; }
        public object Value { get; set; }
        public int TipoMensaje { get; set; }

    }
}
