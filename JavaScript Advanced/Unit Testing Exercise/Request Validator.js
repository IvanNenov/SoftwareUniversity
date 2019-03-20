function RequestValidatator(obj) {
    const errorMessagee = "Invalid request header: Invalid ";
    let objMethod = obj['method'];

    if (objMethod === undefined) {
        throw new Error(errorMessagee + 'Method');

    }
    let uriPattern = /^[A-Za-z0-9\.]+$/;
    let uriObj = obj['uri'];
    if (uriObj === undefined) {
        throw new Error(errorMessagee + 'URI');

    }
    let version = obj['version'];

    if (version === undefined) {
        throw new Error(errorMessagee + 'Version');

    }
    let msg = obj['message'];

    if (msg === undefined) {
        throw new Error(errorMessagee + 'Message');

    }
    let msgPattern = /^[^\<\>\&\'\"\\]*$/;

    if (objMethod !== 'GET' && objMethod !== 'POST' && objMethod !== 'DELETE' && objMethod !== 'CONNECT') {
        throw new Error(errorMessagee + 'Method');

    } else if (!uriPattern.test(uriObj) || uriObj === '') {
        throw new Error(errorMessagee + 'URI');
    }
    //HTTP/0.9, HTTP/1.0, HTTP/1.1 or HTTP/2.0 
    else if (version !== 'HTTP/0.9' && version !== 'HTTP/1.0' && version !== 'HTTP/1.1' && version !== 'HTTP/2.0') {
        throw new Error(errorMessagee + 'Version');
    } else if (!msgPattern.test(msg)) {
        throw new Error(errorMessagee + 'Message');
    } else {
        return obj;
    }
}