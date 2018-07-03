$(window).scroll(function callOnceOnScroll() {
    var $window = $(window),
        $document = $(document);
    if ($window.scrollTop() >= $document.height() - $window.height() - 300 &&
        $window.scrollTop() <= $document.height() - $window.height() - 200) {
        $("#skillsInfo > div:nth-child(2) > div > div > div").css({ "transition": "1s", "height": "10px", "width": "90%" });
        $("#skillsInfo > div:nth-child(3) > div > div > div").css({ "transition": "1s", "height": "10px", "width": "90%" });
        $("#skillsInfo > div:nth-child(4) > div > div > div").css({ "transition": "1s", "height": "10px", "width": "70%" });
        $("#skillsInfo > div:nth-child(5) > div > div > div").css({ "transition": "1s", "height": "10px", "width": "40%" });
        $("#skillsInfo > div:nth-child(6) > div > div > div").css({ "transition": "1s", "height": "10px", "width": "40%" });
        $("#skillsInfo > div:nth-child(7) > div > div > div").css({ "transition": "1s", "height": "10px", "width": "50%" });
    }
});


var modal = document.getElementById('myModal');

// Get the button that opens the modal
var btn = document.getElementById("adjPfSt");

// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

// When the user clicks the button, open the modal 
btn.onclick = function () {
    modal.style.display = "block";
}

// When the user clicks on <span> (x), close the modal
span.onclick = function () {
    modal.style.display = "none";
}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}
