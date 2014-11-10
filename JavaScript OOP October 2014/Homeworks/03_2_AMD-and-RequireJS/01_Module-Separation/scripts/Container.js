/**
 * Created by petrovaliev95 on 08-Nov-14.
 */

define(['ListModuleElement'], function (ListModuleElement) {
    var Container = (function (parent) {
        var Container = function Container(title, sections) {
            parent.call(this, title);
            this.setSections(sections);
        };
        Container.extends(parent);

        Container.prototype.getSections = function getContainerSections() {
            return this._sections;
        };
        Container.prototype.setSections = function setContainerSections(sections) {
            this._sections = sections;
            return this;
        };
        Container.prototype.addSection = function addSectionToContainer(section) {
            this._sections.push(section);
        };

        Container.prototype.addToDOM = function (target) {
            var target = document.getElementById("wrapper");
            var newElement = document.createElement("DIV");
            newElement.innerHTML =
                '<div id="container">' +
                '<h1>' + this.getTitle() + '</h1>' +
                '<div id="sectionContainer">' +
                '</div>' +
                '<input type="text" id="newSectionField" placeholder="Title..." />' +
                '<button class="addNewSection" onclick="addNewSection()">New Section</a>' +
                '</div>';
            target.appendChild(newElement);
        };

        return Container;
    }(ListModuleElement));

    return Container;
});