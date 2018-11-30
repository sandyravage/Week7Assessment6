var hide1 = document.getElementById('hidden1');
var hide2 = document.getElementById('hidden2');
var form1 = document.getElementById('form1');
var button1 = document.getElementById('yes1');
var button2 = document.getElementById('no1');
var button3 = document.getElementById('yes2');
var button4 = document.getElementById('no2');



button1.addEventListener("click", toggleHidden1);
button2.addEventListener("click", toggleHidden1);
button3.addEventListener("click", toggleHidden2);
button4.addEventListener("click", toggleHidden2);

function toggleHidden1() {
    if (hide1.style.display == "") {
        hide1.style.display = "block";
        form1.action = "@Url.Action("RSVPConfirmation","Home")";
    }
    else {
        hide1.style.display = "";
        form1.action = "@Url.Action("RSVPNotAttending","Home")";
    }
}
function toggleHidden2() {
    if (hide2.style.display == "") {
        hide2.style.display = "block";

    }
    else {
        hide2.style.display = "";
    }
}