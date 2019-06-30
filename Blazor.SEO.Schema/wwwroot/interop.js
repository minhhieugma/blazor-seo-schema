var SEOSchemaInterop;
(function (SEOSchemaInterop) {
    function configure(id, schema) {
        var code = document.createTextNode(schema);
        var script = document.createElement("script");
        script.setAttribute("type", "application/ld+json");
        script.setAttribute("id", "schema_" + id);
        script.appendChild(code);
        document.head.appendChild(script);
    }
    SEOSchemaInterop.configure = configure;
    function dispose(id) {
        var scriptTag = document.getElementById("schema_" + id);
        scriptTag.remove();
    }
    SEOSchemaInterop.dispose = dispose;
})(SEOSchemaInterop || (SEOSchemaInterop = {}));
