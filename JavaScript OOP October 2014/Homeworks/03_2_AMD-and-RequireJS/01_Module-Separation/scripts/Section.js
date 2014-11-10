/**
 * Created by petrovaliev95 on 08-Nov-14.
 */

define(['ListModuleElement'], function (ListModuleElement) {

    var Section = (function (parent) {
        var counter = 0;
        var Section = function Section(title, items) {
            parent.call(this, title);
            this.setItems(items);
            counter++;
        };
        Section.extends(parent);

        Section.prototype.getItems = function () {
            return this._items;
        };
        Section.prototype.setItems = function (items) {
            this._items = items;
            return this;
        };

        Section.prototype.addToDOM = function () {
            var target = document.getElementById("sectionContainer");
            var newElement = document.createElement("DIV");
            newElement.innerHTML =
                '<section class="clearfix" id="section' + counter +'">' +
                '<h2>' + this.getTitle() + '</h2>' +
                '</section>' +
                '<div class="addItem clearfix">' +
                '<input type="text" id="newitemfield' + counter +'" placeholder="Add item..." />' +
                '<button href="#" class="addNewItem" onclick="addNewItem(\'section' + counter +'\', \'newitemfield' + counter +'\')" >+</button>' +
                '</div>';
            target.appendChild(newElement);
        };

        Section.prototype.addItem = function (item) {
            this._items.push(item);
        };

        return Section;
    }(ListModuleElement));

    return Section;
});