
function onButtonClick(evt) {
    var b = evt.currentTarget;

    var classes = b.classList;

    var isGreen = false;

    for (var i = 0; i < classes.length; i++) {
        var c = classes[i];
        if (c == "greenButton") {
            isGreen = true;
            break;
        }
    }
       

        if (isGreen) {

            b.className = "btn redButton";

        }
        else {

            b.className = "btn greenButton";
        }

    var t = document.getElementById("sampleTable");

    var currentHtml = t.innerHTML;
    t.innerHTML += "<tr><td>" + b.getAttribute("name") + "</td><td>" + moment(new Date().format("DD-MM-YYYY HH:mm:ss")) + "</td></tr>" ;
}


var buttons = document.getElementsByTagName("button");

for (var i = 0; i < buttons.length; i++) {
    buttons[i].addEventListener("click", onButtonClick);
}



(function () {

    document.getElementById("button1").addEventListener("click", function () {
        var options = {
            style: {
                main: {
                    background: "#364685",
                    color: "#fff"
                },
            },
        };
        iqwerty.toast.toast("hello world!", options);
    });

    var bv = new Bideo();
    bv.init({
       
        videoEl: document.querySelector('#background_video'),

       
        container: document.querySelector('body'),

       
        resize: true,

       

       

        src: [
            {
                src: '/lib/bideo/night.mp4',
                type: 'video/mp4'
            }
        ],

        
        onLoad: function () {
            document.querySelector('#video_cover').style.display = 'none';
        }
    });
}());

