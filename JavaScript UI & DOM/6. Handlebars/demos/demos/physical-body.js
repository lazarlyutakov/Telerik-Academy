function createPhysicalBody(options){
    'use strict';

    function move(){
        //var lastCoordinates = JSON.parse(JSON.stringify(this.coordinates));
        var lastCoordinates = {x: this.coordinates.x, y:this.coordinates.y};

        this.coordinates.x += this.speed.x;
        this.coordinates.y += this.speed.y;

        return lastCoordinates;
    }

    function colideWith(otherPhysicalBody){

        var self = this,
            x1 = self.coordinates.x + self.width / 2, 
            y1 = self.coordinates.y + self.height / 2,
            x2 = otherPhysicalBody.coordinates.x + otherPhysicalBody.width / 2, 
            y2 = otherPhysicalBody.coordinates.y + otherPhysicalBody.height / 2;




      var distance = Math.sqrt((x1- x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

      return distance <= (self.radius + otherPhysicalBody.radius);
    }

    var physicalBody = {
        coordinates: options.coordinates,
        speed: options.speed,
        width: options.width,
        height: options.height,
        radius : (options.width + options.height) / 4,
        move: move,
        colideWith: colideWith
    };

    return physicalBody;
}