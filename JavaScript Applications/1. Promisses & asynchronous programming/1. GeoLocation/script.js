(function(){
    let rootDiv = document.getElementById('root');

     let locationPromise = new Promise((resolve, reject) => {
        navigator.geolocation.getCurrentPosition((currentPsn) => {
            resolve(currentPsn);
        })
    });

    function parseData(currentPsn){
        return{
            lat: currentPsn.coords.latitude,
            long: currentPsn.coords.longitude
        }
    }

    function showMap(currentPsn){
        let mapImg = new Image();

       let mapImgSrc = `https://maps.googleapis.com/maps/api/staticmap?center=${currentPsn.lat},${currentPsn.long}
                       //&markers=color:red%7Clabel:You%7C${currentPsn.lat},${currentPsn.long}&zoom=15&size=500x500&scale=2`;

       //let mapImgSrc = `http://maps.googleapis.com/maps/api/staticmap?center=${currentPsn.lat},
                                              //${currentPsn.long}&zoom=18&size=500x500&sensor=true`;                                   
        mapImg.setAttribute('src', mapImgSrc);
        rootDiv.appendChild(mapImg);
    }

    locationPromise
       .then(parseData)
       .then(showMap)
}());

