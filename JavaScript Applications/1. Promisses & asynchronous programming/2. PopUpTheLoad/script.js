const popupMsg = document.getElementById('popup-div');
const siteToBeRedirectedTo = 'https://9gag.com/';

(function(){

    function setInterval(interval, popupMsg) {
        return new Promise((resolve, reject) => {
            setTimeout(() => {
                resolve(popupMsg);
            }, interval);
        });
    }

    function loadAnotherSite(){
        window.location = siteToBeRedirectedTo;
    }

    let popupPromise = new Promise((resolve, reject) => {
        resolve(popupMsg);
    });

    popupPromise
       .then(popupMsg => setInterval(2000, popupMsg))
       .then(loadAnotherSite);
}());