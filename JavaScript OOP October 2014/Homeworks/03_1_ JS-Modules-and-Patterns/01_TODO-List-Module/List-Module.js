/**
 * Created by petrovaliev95 on 06-Nov-14.
 */
"use strict";


var ListModule = (function () {

    Object.prototype.extends = function (parent) {
        this.prototype = Object.create(parent.prototype);
        this.prototype.constructor = this;
    };

    Object.prototype.validateNullOrEmpty = function (string, nameOfVariable) {
        if (string === null || string === undefined || string == "") {
            throw new TypeError(nameOfVariable + " cannot be null, undefined or empty.")
        }
    };

    var ListModuleElement = (function () {
        var ListModuleElement = function ListModuleElement(title) {
            this.setTitle(title);
        };

        ListModuleElement.prototype.getTitle = function () {
            return this._title;
        };
        ListModuleElement.prototype.setTitle = function (title) {
            this.validateNullOrEmpty(title, "title");
            this._title = title;
            return this;
        };

        return ListModuleElement;
    }());

    var Container = (function () {
        var Container = function Container(title, sections) {
            ListModuleElement.call(this, title);
            this.setSections(sections);
        };
        Container.extends(ListModuleElement);

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

        Container.prototype.addToDOM = function () {
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
    }());


    var Section = (function () {
        var counter = 0;
        var Section = function Section(title, items) {
            ListModuleElement.call(this, title);
            this.setItems(items);
            counter++;
        };
        Section.extends(ListModuleElement);

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
    }());


    var Item = (function () {
        var counter = 0;

        var Item = function Item(title) {
            ListModuleElement.call(this, title);
            counter++;
        };
        Item.extends(ListModuleElement);


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
    }());

    return{
        ListModuleElement: ListModuleElement,
        Item: Item,
        Container: Container,
        Section: Section
    };

}());