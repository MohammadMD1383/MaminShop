class IncludeHtml extends HTMLElement {
    static get observedAttributes() {
        return ["url"];
    }
    constructor() {
        super();
    }
    connectedCallback() {
        const url = this.getAttribute("url");
        if (url) {
            IncludeHtml.fetchHtml(url, (html) => {
                this.parentNode.insertBefore(html, this);
                this.remove();
            });
        }
        else {
            throw new Error("url not specified");
        }
    }
    static fetchHtml(url, callback) {
        const xhr = new XMLHttpRequest();
        xhr.onreadystatechange = () => {
            if (xhr.readyState === 4 && xhr.status === 200) {
                const template = document.createElement("template");
                template.innerHTML = xhr.responseText.trim();
                callback(template.content.firstChild);
            }
        };
        xhr.open("GET", url);
        xhr.send();
    }
}
customElements.define("include-html", IncludeHtml);
//# sourceMappingURL=include-html.js.map