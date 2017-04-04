function checkBrowserIsMozilla() {
    var myWindiw = window,
        browserToCheck = myWindiw.navigator.appCodeName,
        isBrowserMozilla = browserToCheck == "Mozilla";

    if (isBrowserMozilla) {
        alert("Yes");
    }
    else {
        alert("No");
    }
}

checkBrowserIsMozilla();