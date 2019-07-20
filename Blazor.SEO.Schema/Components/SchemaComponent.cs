using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blazor.SEO.Schema.Schema;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.JSInterop;
using Newtonsoft.Json;

namespace Blazor.SEO.Schema.Components
{
    public class SchemaComponent<ISchema> : ComponentBase, IDisposable where ISchema : BaseModel
    {
        public const string ConfigureMethod = "SEOSchemaInterop.configure";
        public const string DisposeMethod = "SEOSchemaInterop.dispose";

        [Parameter]
        public ISchema Schema { get; set; }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        protected override async Task OnAfterRenderAsync()
        {
            await base.OnAfterRenderAsync();
        }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {

            base.BuildRenderTree(builder);


            builder.AddMarkupContent(0, @$"<script type=""application/ld+json"">{JsonConvert.SerializeObject(this.Schema)}</script>");


        }

        public void Dispose()
        {

        }
    }
}
