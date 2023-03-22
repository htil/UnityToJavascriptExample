mergeInto(LibraryManager.library, {
  HelloString: function (str) {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
        console.log("readyState: " + xhttp.readyState + " status: " + xhttp.status);
      if (xhttp.readyState === 4) {
        var myDiv = document.getElementById("UnityToJavascript");
        myDiv.innerHTML = UTF8ToString(str);
      }
    };
    xhttp.open("GET", "../../Build/index.html", true);
    xhttp.send(str); // Pass the str parameter as part of the request
  },
});
