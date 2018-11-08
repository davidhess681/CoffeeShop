function Validate() {
    var isValid = true;
    var fnReg = "^[a-zA-Z]{2,}$";
    var lnReg = "^[a-zA-Z]{2,}$";
    var emReg = "^ ([a - zA - Z0 - 9_\-\.] +)@([a - zA - Z0 - 9_\-\.] +)\.([a - zA - Z]{2, 5})$";
    var fn = document.forms["signup"]["FirstName"].value;
    var ln = document.forms["signup"]["LastName"].value;
    var em = document.forms["signup"]["Email"].value;

    if (!fnReg.test(fn)) {
        alert("First Name is invalid");
        isValid = false;
    }
    if (!lnReg.test(ln)) {
        alert("Last Name is invalid");
        isValid = false;
    }
    if (!emReg.test(em)) {
        alert("Email is invalid");
        isValid = false;
    }
    return isValid;

}