function toPrettyJson(input) {
    return JSON.stringify(JSON.parse(input), null, 2);
}

function isValidJson(str) {
    try {
        return JSON.parse(str) && !!str;
    } catch (e) {
        return false;
    }
}

function parseVmmKeys() {

}


// Copy to clipboard button event handler
$(document).on("click", "#VMM_formattedDataCopyBtn", function () {
    // TODO
    // https://www.freecodecamp.org/news/copy-text-to-clipboard-javascript/
});



