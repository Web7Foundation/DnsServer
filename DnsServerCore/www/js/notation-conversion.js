/* RK - ADDED MAY 4 2023 */

function convertDidNotationToDnsNotation(input) {

    let output = "";
    if (input.substring(0, 4) === "did:") {
        let didLabels = input.split(":");

        for (let i = didLabels.length - 1; i >= 0; i--) {
            output += didLabels[i];
            if (i > 0) output += ".";
        }
    }
    return output;

}

function convertDnsNotationToDidNotation(input) {

    let output = "";
    if (input.substring(0, 4) !== "did:") {
        let dnsLabels = input.split(".");

        for (let i = dnsLabels.length - 1; i >= 0; i--) {
            output += dnsLabels[i];
            if (i > 0) output += ":";
        }
    }
    return output;
}
