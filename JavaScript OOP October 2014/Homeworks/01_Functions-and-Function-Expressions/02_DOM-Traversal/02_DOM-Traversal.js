function traverse(nameOfClass) {
	nameOfClass = nameOfClass.substring(1);
	var node = document.getElementsByClassName(nameOfClass);
	node = node[0];
	var isForTraverse = false;
	traverseNode(node, '');

	function traverseNode(node, spacing) {
		var nodeType = node.localName;

		if (nodeType != null && isForTraverse) {
			spacing = spacing || '  ';
			var nodeClass = node.className;
			var nodeId = node.id;
			var result = spacing + " " + nodeType + ": ";

			if (nodeId != null && nodeId != "") {
				result += "id=\"" + nodeId + "\" ";
			}
			if (nodeClass != null && nodeClass != "") {
				result += "class=\"" + nodeClass + "\"";
			}
			console.log(result);
		}

		// skip the first parent element
		isForTraverse = true;

		for (var i = 0, len = node.childNodes.length; i < len; i += 1) {
			var child = node.childNodes[i];

			if (child.nodeType === document.ELEMENT_NODE) {
				isForTraverse = true;
				traverseNode(child, spacing + '  ');
			}
		}

	}
}
var selector = ".birds";
traverse(selector);
