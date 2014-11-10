/**
 * Created by petrovaliev95 on 08-Nov-14.
 */

define(['ListModuleElement'], function (ListModuleElement) {

    var Item = (function (parent) {
        var counter = 0;

        var Item = function Item(title) {
            parent.call(this, title);
            counter++;
        };
        Item.extends(parent);


        Item.prototype.addToDOM = function (target) {
            var target = document.getElementById(target);
            var newElement = document.createElement("DIV");
            newElement.innerHTML =
                '<div class="contentBox">' +
                '<input onclick="changeStatus(content' + counter + ')" type="checkbox"  />'+
                '<div class="content" id="content' + counter + '">' + this.getTitle() +'</div>' +
                '</div>';
            target.appendChild(newElement);
        };
        return Item;
    }(ListModuleElement));

    return Item;
});