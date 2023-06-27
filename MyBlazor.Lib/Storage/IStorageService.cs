using MyBlazor.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazor.Lib.Storage
{
    public interface IStorageService
    {
        IList<Product> Products { get; }
    }
}
