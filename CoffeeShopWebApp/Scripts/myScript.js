var matching = false;
var check_match = function () {
    if (document.getElementById("email").value === document.getElementById("cfem").value) {
        document.getElementById("message").innerHTML = "matching!";
        document.getElementById("message").style.color = "green";
        matching = true;
    }
    else {
        document.getElementById("message").innerHTML = "not matching!";
        document.getElementById("message").style.color = "red";
        matching = false;
    }
}
var fnRegex = /^[A-Z]+[A-z]{1,30}$/
var lnRegex = /^[A-Z]+[A-z]{1,30}$/
var emRegex = /^([A-z0-9\.]{5,30})@([A-z]{5,10})\.([a-z]{2,3})$/
var fnIsValid = false;
var validFN = function () {
    if (fnRegex.test(document.getElementById("fn").value)) {
        document.getElementById("fnMessage").innerHTML = "Valid!";
        document.getElementById("fnMessage").style.color = "green";
        fnIsValid = true;
    }
    else {
        document.getElementById("fnMessage").innerHTML = "Invalid!";
        document.getElementById("fnMessage").style.color = "red";
        fnIsValid = false;
    }
}
var lnIsValid = false;
var validLN = function () {
    if (lnRegex.test(document.getElementById("ln").value)) {
        document.getElementById("lnMessage").innerHTML = "Valid!";
        document.getElementById("lnMessage").style.color = "green";
        lnIsValid = true;
    }
    else {
        document.getElementById("lnMessage").innerHTML = "Invalid!";
        document.getElementById("lnMessage").style.color = "red";
        lnIsValid = false;
    }
}
var bdIsValid = false;
var validBD = function () {
    if (document.getElementById("bd").value !== null) {
        document.getElementById("bdMessage").innerHTML = "Valid!";
        document.getElementById("bdMessage").style.color = "green";
        bdIsValid = true;
    }
    else {
        document.getElementById("bdMessage").innerHTML = "Invalid!";
        document.getElementById("bdMessage").style.color = "red";
        bdIsValid = false;
    }
}
var emIsValid = false;
var validEM = function () {
    check_match();
    if (emRegex.test(document.getElementById("email").value)) {
        document.getElementById("emMessage").innerHTML = "Valid!";
        document.getElementById("emMessage").style.color = "green";
        emIsValid = true;
    }
    else {
        document.getElementById("emMessage").innerHTML = "Invalid!";
        document.getElementById("emMessage").style.color = "red";
        emIsValid = false;
    }
}
function Validate() {
    if (fnIsValid && lnIsValid && emIsValid && matching && bdIsValid) {
        return true;
    }
    alert("Please make sure all fields are valid")
    return false;

}
