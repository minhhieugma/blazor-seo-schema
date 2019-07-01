using System;
using System.Threading.Tasks;
using Blazor.SEO.Schema.Schema;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Newtonsoft.Json;

namespace Blazor.SEO.Schema.Components
{
    public class SchemaComponent<ISchema> : ComponentBase, IDisposable where ISchema : BaseModel
    {
        public const string ConfigureMethod = "SEOSchemaInterop.configure";
        public const string DisposeMethod = "SEOSchemaInterop.dispose";

        protected ISchema Schema { get; set; }

        protected Guid Id { get; set; }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        protected override async Task OnAfterRenderAsync()
        {
            if (this.Schema != null)
            {
                this.Id = Guid.NewGuid();
                await JSRuntime.InvokeAsync<string>(ConfigureMethod, Id, JsonConvert.SerializeObject(this.Schema));
            }

            await base.OnAfterRenderAsync();
        }

        public async void Dispose()
        {
            if (this.Id != Guid.Empty)
            {
                await JSRuntime.InvokeAsync<string>(DisposeMethod, Id);
            }
        }
    }
}
