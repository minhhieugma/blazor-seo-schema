using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Blazor.SEO.Schema
{
    //[Route("/{Slug}")]
    //[Route("/{LanguageCode}/{Slug}")]
    public class SchemaComponent<ISchema> : ComponentBase, IDisposable where ISchema : class
    {

        public string Slug { get; set; }

        public string LanguageCode { get; set; }

        [Parameter]
        public ISchema Schema { get; set; }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        protected override Task OnAfterRenderAsync(bool firstRender)
        {
            return base.OnAfterRenderAsync(firstRender);
        }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);


            builder.AddMarkupContent(0, $@"<script type=""application/ld+json"">{JsonConvert.SerializeObject(this.Schema)}</script>");
        }
        public void Dispose()
        {
            
        }
    }
}
