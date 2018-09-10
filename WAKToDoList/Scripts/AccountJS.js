$(document).ready(function () {
    load();
});


function load() {
    $("#dob").blur(function () {
        var today = new Date();
        var birthDate = new Date($('#dob').val());
        var age = today.getFullYear() - birthDate.getFullYear();
        var m = today.getMonth() - birthDate.getMonth();
        if (m < 0 || (m === 0 && today.getDate() < birthDate.getDate())) {
            age--;
        }
        $('#age2').val(age);
    });
}