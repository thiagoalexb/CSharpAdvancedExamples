using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CSharpAdvancedExamples.Asynchronous
{
    public class Asynchronous
    {
        //Para nao travar aplicações com UI ou até mesmo outras requisicoes
        public async Task<string> DownloadHtml()
        {
            using(var http = new HttpClient())
            {
                return await http.GetStringAsync("http://msdn.microsoft.com");
            }
        }
    }
}
