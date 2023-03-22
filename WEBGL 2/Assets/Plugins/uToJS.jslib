mergeInto(LibraryManager.library, {

  HelloString: function (str) {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
    var myDiv = document.getElementById("UnityToJavascript");
    myDiv.innerHTML = UTF8ToString(str);
    };
    xhttp.open("GET", "../../Build/index.html", true);
    xhttp.send();
  },

});