using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Models
{
    internal class FunctionResult<T>
    {
        public EnumErrcode ErrCode { get; set; }//success/fail
        public string ErrDesc { get; set; }
        public T Data { get; set; }
    }
}
