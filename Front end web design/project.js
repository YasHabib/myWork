//*****Yasin**********

//on click dropdown main page Partner Airlines tab
function flights() {
    document.getElementById("content").classList.toggle("show");
}
// changing language using google translation
function googleTranslateElementInit() {
    new google.translate.TranslateElement({ pageLanguage: 'en', layout: google.translate.TranslateElement.InlineLayout.SIMPLE }, 'google_translate_element');
}
//*********Linda Ngo *************
//Validation for registration

function validatePass() {
    let mark = document.getElementById("x10")
    if (pwd.value == repwd.value) {
        mark.style.visibility = "hidden";
    }
    else {
        mark.style.visibility = "visible";
    }
}

function validA(fieldToCheck, errorID) {

    if (isNaN(fieldToCheck.value)) {
        errorID.style.visibility = "hidden";
    }
    else {
        errorID.style.visibility = "visible";
    }
}