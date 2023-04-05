var element = document.getElementById("example");
var textExample = "This is a text";
var aNumber = 10.333;



var complexObject = {
    name: "Israel",
    lastName: "Perez",
    age: 35
};

var text1 = "text";
var u1 = "<u1>";

for (var i = 0; i < textExample.length; i++) {
    u1 += ("<li>"+textExample[i]+"</li>");
}

u1 += "</u1>";

var data = "133333";


element.innerHTML = typeof(parseInt(data));