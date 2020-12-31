using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDotLiquid
{
    public class ReportFactoryJsInterop
    {
        public static async void GenerateReport(IJSRuntime JS, string id = "divId")
        {
            await JS.InvokeAsync<string>("pdffromhtml", id);
        }
    }
}
