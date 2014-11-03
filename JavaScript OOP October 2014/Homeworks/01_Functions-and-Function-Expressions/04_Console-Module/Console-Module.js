/**
 * Created by petrovaliev95 on 03-Nov-14.
 */

var specialConsole = (function specialConsole() {

    function replacer() {
        var result = arguments[0][0];
        if (arguments != null) {
            for (var i = 1; i < arguments[0].length; i++) {
                var item = arguments[0][i];
                var regex = new RegExp("\\{" + (i-1) +"\\}");
                result = result.replace(regex, item);
            }
        }
        return result;
    }

    function writeLine() {
        console.log(replacer(arguments))
    }

    function writeWarning() {
        console.warn(replacer(arguments));
    }

    function writeError() {
        console.error(replacer(arguments));
    }

    return{
        writeError: writeError,
        writeWarning: writeWarning,
        writeLine: writeLine
    }

})();

specialConsole.writeLine("Message: hello");
specialConsole.writeLine("Message: {0} {1}", "hello", "secondHello");
specialConsole.writeError("Error: {0}", "A fatal error has occurred.");
specialConsole.writeWarning("Warning: {0}", "You are not allowed to do that!");
