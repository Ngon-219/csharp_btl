using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_Quan_ly_kho.Model
{
    internal class FunctResult<T>
    {
        public EnumErrCode ErrCode { get; set; }
        public string ErrDesc { get; set; }
        public T Data { get; set; }
    }
}
