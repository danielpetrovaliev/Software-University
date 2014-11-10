/**
 * Created by petrovaliev95 on 08-Nov-14.
 */

define(function () {

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

    return ListModuleElement;
});