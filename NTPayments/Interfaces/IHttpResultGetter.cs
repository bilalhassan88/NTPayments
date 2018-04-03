using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTPayments.Interfaces
{
    public interface IHttpResultGetter
    {
        string GetResult(string uri);
    }
}
