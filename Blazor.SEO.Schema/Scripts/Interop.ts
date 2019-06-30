
namespace SEOSchemaInterop {
    export function configure(id: string, schema: string): void {
        const code = document.createTextNode(schema);

        const script = document.createElement("script");
        script.setAttribute("type", "application/ld+json");
        script.setAttribute("id", "schema_" + id);
        script.appendChild(code);
        document.head.appendChild(script);

    }

    export function dispose(id: string): void {
        var scriptTag = document.getElementById("schema_" + id);

        scriptTag.remove();
    }

}