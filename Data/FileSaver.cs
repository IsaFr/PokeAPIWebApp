using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeAPIWebApp.Data
{
    public class FileSaver : IFileSaver
    {
        private IJSRuntime _oIJSRuntime { get;  }

        public FileSaver(IJSRuntime oIJSRuntime)
        {
            _oIJSRuntime = oIJSRuntime;
        }
        public async Task SaveAs(string fileName, List<string> Data, string type = "text.plain;charset=utf-8")
        {
            await _oIJSRuntime.InvokeVoidAsync("FileSaveBlazor.saveAs", fileName, Data, type);
        }
    }
}
