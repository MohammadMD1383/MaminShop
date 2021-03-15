class IncludeHtml extends HTMLElement {
	static get observedAttributes(): Array<string> {
		return ["url"];
	}
	
	constructor() {
		super();
	}
	
	connectedCallback(): void {
		const url: string = this.getAttribute("url");
		if (url) {
			IncludeHtml.fetchHtml(url, (html: Node) => {
				this.parentNode.insertBefore(html, this);
				this.remove();
			});
		} else {
			throw new Error("url not specified");
		}
	}
	
	private static fetchHtml(url: string, callback: Function): void {
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
