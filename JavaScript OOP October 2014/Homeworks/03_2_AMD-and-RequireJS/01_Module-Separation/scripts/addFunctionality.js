/**
 * Created by petrovaliev95 on 06-Nov-14.
 */
define(['Container', 'Section', 'Item'], function (Container, Section, Item) {

    var factory = (function () {
        var addContainer = function addContainer(title) {
            var cont = new Container(title);
            cont.addToDOM();
        };

        var addNewSection = function addNewSection() {
            var title = document.getElementById("newSectionField").value;
            var newSection = new Section(title);
            newSection.addToDOM();
        };

        var addNewItem = function addNewItem(target, inputId) {
            var content = document.getElementById(inputId).value;
            var newItem = new Item(content);
            newItem.addToDOM(target);
        };

        var changeStatus = function changeStatus(target) {
            if (target.classList[1] == "checked") {
                target.className = "content";
            } else {
                target.className += " checked";
            }
        };
        return{
            addContainer: addContainer,
            addNewSection: addNewSection,
            addNewItem: addNewItem,
            changeStatus: changeStatus
        }
    }());

    return factory;
});