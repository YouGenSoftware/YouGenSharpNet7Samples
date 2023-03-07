// DO NOT UNDER ANY CIRCUMSTANCES PUBLISH THIS FILE TO A PUBLIC WEB SERVER
// THIS FILE IS MEANT ENTIRELY FOR TEST AUTOMATION AND TEST-DRIVEN-DEVELOPMENT WORKFLOWS
// this file requires loading of CryptoJS.js file into the test document object model
//  use the same key specified in the BackEndCommon Http/SignalRWebsocket configuration
const encryptDecryptKey = '037100051d22421ca13eb25bd6c0fdd5';
function encrypt(input) {
    return CryptoJS.AES.encrypt(input.toString(), encryptDecryptKey).toString();
}
function decrypt(input) {
    var bytes = CryptoJS.AES.decrypt(input, encryptDecryptKey);
    return bytes.toString(CryptoJS.enc.Utf8);
}
