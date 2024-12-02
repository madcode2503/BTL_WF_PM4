using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlNhanSu.Models
{
    internal class FunctionResult<T>
    {
        public EnumErrCode ErrCode { get; set; }
        public string ErrDesc { get; set; }
        public T Data { get; set; }
    }
}
