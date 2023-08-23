//FUNCTIONS
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

function tryParseJson(input) {
    try {
        return JSON.parse(input.replace(/\\n/g, "\n"));
    } catch (e) {
        return input;
    }
}

function disableSaveButton() {
    $("#btnAddEditRecord").prop('disabled', true);
    $("#btnAddEditRecord").html("Invalid Key");
}

function enableSaveButton() {
    $("#btnAddEditRecord").prop('disabled', false);
    $("#btnAddEditRecord").html("Save");
}

function clearSubjectKeysDisplay() {
    $("VMM_formattedDataText").html("");
}

function parseVmmKeys() {
    var keyPublicJsonWebKey = $("#txtAddEditRecordDataVMM_keyPublicJsonWebKey").val();
    var keyPublicJsonWebKeyString = $("#txtAddEditRecordDataVMM_keyPublicJsonWebKeyString").val();
    var publicKeyMultibase = $("#txtAddEditRecordDataVMM_publicKeyMultibase").val();
    var publicKeyJwk = $("#txtAddEditRecordDataVMM_publicKeyJwk").val();

    disableSaveButton();

    if (!isValidJson(keyPublicJsonWebKey) && keyPublicJsonWebKey !== "") {
        $("#VMM_formattedDataText").html(`Invalid JSON: keyPublicJsonWebKey`);
        return;
    }

    if (!isValidJson(keyPublicJsonWebKeyString) && keyPublicJsonWebKeyString !== "") {
        $("#VMM_formattedDataText").html(`Invalid JSON: keyPublicJsonWebKeyString`);
        return;
    }

    if (!isValidJson(publicKeyMultibase) && publicKeyMultibase !== "") {
        $("#VMM_formattedDataText").html(`Invalid JSON: publicKeyMultibase`);
        return;
    }

    if (!isValidJson(publicKeyJwk) && publicKeyJwk !== "") {
        $("#VMM_formattedDataText").html(`Invalid JSON: publicKeyJwk`);
        return;
    }

    enableSaveButton();

    keyPublicJsonWebKey = tryParseJson(keyPublicJsonWebKey);
    keyPublicJsonWebKeyString = tryParseJson(keyPublicJsonWebKeyString);
    publicKeyMultibase = tryParseJson(publicKeyMultibase);
    publicKeyJwk = tryParseJson(publicKeyJwk);

    var jsonObj = {
        keyPublicJsonWebKey, 
        keyPublicJsonWebKeyString,
        publicKeyMultibase,
        publicKeyJwk
    }
    
    if (keyPublicJsonWebKey === "") delete jsonObj.keyPublicJsonWebKey;
    if (keyPublicJsonWebKeyString === "") delete jsonObj.keyPublicJsonWebKeyString;
    if (publicKeyMultibase === "") delete jsonObj.publicKeyMultibase;
    if (publicKeyJwk === "") delete jsonObj.publicKeyJwk;

    var json = JSON.stringify(jsonObj);

    $("#VMM_formattedDataText").html(toPrettyJson(json));
}


// EVENTS

// input on change
$(document).on("input", "#txtAddEditRecordDataVMM_keyPublicJsonWebKey", function () {
    parseVmmKeys();
});

$(document).on("input", "#txtAddEditRecordDataVMM_keyPublicJsonWebKeyString", function () {
    parseVmmKeys();
});

$(document).on("input", "#txtAddEditRecordDataVMM_publicKeyMultibase", function () {
    parseVmmKeys();
});

$(document).on("input", "#txtAddEditRecordDataVMM_publicKeyJwk", function () {
    parseVmmKeys();
});



