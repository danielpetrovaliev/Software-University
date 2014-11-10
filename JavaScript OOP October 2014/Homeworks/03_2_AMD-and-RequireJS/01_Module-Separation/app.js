/**
 * Created by petrovaliev95 on 08-Nov-14.
 */

(function () {
    "use strict";

    (function () {
        require.config({
            paths: {
                "factory": "scripts/addFunctionality",
                "ListModuleElement": "scripts/ListModuleElement",
                "Section": "scripts/Section",
                "Container": "scripts/Container",
                "Item": "scripts/Item"
            }
        });
    }());

    require(["factory"], function (factory) {
        factory.addContainer("Thursday TODO List");
    });
}());