Blazor component for S.E.O, SEO, Schema, schema.org

Blazor Version: 3.0.0-preview6.19307.2

# NuGet Package
https://nuget.org/packages/Blazor-SEO-Schema

# Configuration

### `Product` schema

Firstly, inherit `ProductSchemaComponent` component to the page you want to add schema
```
@inherits Blazor.SEO.Schema.Components.ProductSchemaComponent
@page "/counter"
```
Then, write some code to set value into the `Product` property
```
@code {
    protected override Task OnInitAsync()
    {
        this.Product = new Blazor.SEO.Schema.Product();
        this.Product.Name = "The first Hieu's product";
        
        return base.OnInitAsync();
    }
}
```
### Blazor Server Side Rendering Project
At least for `3.0.0-preview6.19307.2`, We need to manually add scrips to `head` tag:
```
<environment include="Development">
    <link rel="stylesheet" href="css/bootstrap/bootstrap.min.css" />
    <script src="_content/Blazor-SEO-Schema/interop.js"></script>
</environment>
```
https://devblogs.microsoft.com/aspnet/asp-net-core-and-blazor-updates-in-net-core-3-0-preview-6/