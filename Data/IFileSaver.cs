using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeAPIWebApp.Data
{
    public interface IFileSaver
    {
        Task SaveAs(string fileName, List<string> Data, string type = "text.plain;charset=utf-8");
    }
}
