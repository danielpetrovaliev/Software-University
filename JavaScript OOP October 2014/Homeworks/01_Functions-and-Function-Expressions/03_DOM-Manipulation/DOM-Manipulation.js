/**
 * Created by petrovaliev95 on 03-Nov-14.
 */

var domModule = (function domModule() {
    function appendChild(childElement, parentByClassName) {
        var target = document.querySelector(parentByClassName);
        target.appendChild(childElement);
    }

    function removeChild(parentTag, childTag) {
        var parent = document.querySelector(parentTag);
        var child = document.querySelector(childTag);
        parent.removeChild(child);
    }

    function addHandler(targetsSelector, eventType, callback) {
        var targets = document.querySelectorAll(targetsSelector);
        for (var i = 0; i < targets.length; i++) {
            var target = targets[i];
            target.addEventListener(eventType, callback);
        }
    }

    function retrieveElements(selector) {
        var elements = document.querySelectorAll(selector);
        return elements;
    }

    return {
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addHandler,
        retrieveElements: retrieveElements
    }

})();

var liElement = document.createElement("li");
// Appends a list item to ul.birds-list
domModule.appendChild(liElement,".birds-list");
// Removes the first li child from the bird list
domModule.removeChild("ul.birds-list","li:first-child");
// Adds a click event to all bird list items
domModule.addHandler("li.bird", 'click', function(){ alert("I'm a bird!") });
// Retrives all elements of class "bird"
var elements = domModule.retrieveElements(".bird");
console.log(elements);


