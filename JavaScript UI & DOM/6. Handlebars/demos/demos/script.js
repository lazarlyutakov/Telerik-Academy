window.addEventListener('load', function () {

    function applyGravityVertical(physicalBody, gravity){
        if(physicalBody.coordinates.y === (HEIGHT - physicalBody.height)){
            return;
        }

        if(physicalBody.coordinates.y > (HEIGHT - physicalBody.height)){
            physicalBody.coordinates.y = (HEIGHT - physicalBody.height);
            physicalBody.speed.y = 0;
            return;
        }

        physicalBody.speed.y += gravity;
    }

    var WIDTH = 768;
    var HEIGHT = WIDTH / 2;

    var playerCanvas = document.getElementById('player-canvas');
    var playerContext = playerCanvas.getContext('2d');
    var playerImage = document.getElementById('pikachu-running');
    

    playerCanvas.width = WIDTH;
    playerCanvas.height = HEIGHT;
    

    var pikachuSprite = createSprite({
        spritesheet: playerImage,
        width: playerImage.width / 4,
        height: playerImage.height,
        context: playerContext,
        numberOfFrames: 4,
        loopTicksPerFrame: 5
    });

    var pikachuBody = createPhysicalBody({
        coordinates:{x : 10, y : HEIGHT - pikachuSprite.height},
        speed : {x : 0, y : 0},
        width : pikachuSprite.width,
        height : pikachuSprite.height
    });

    

    window.addEventListener('keydown', function(event){
        // if((event.keyCode) < 37 || (40 < event.keyCode)){
        //     return;
        // }
        var speed = 3;

        switch(event.keyCode){
            case 37:
              pikachuBody.speed.x = -speed;
              break;
            case 38:
              if(pikachuBody.coordinates.y < (HEIGHT - pikachuBody.height)){
                  return;
              }

              pikachuBody.speed.y = -speed;
              break;
            case 39:
              pikachuBody.speed.x = speed;
              break;
            case 40:
              pikachuBody.speed.y = speed;
              break;      
            default:
                 break;  
        }
    });

    window.addEventListener('keyup', function(event){
        if((event.keyCode !== 37) && (event.keyCode !== 39)){
            return;
        }
        pikachuBody.speed.x = 0;
    })

    // function removeAccelerationHorizontal(physicalBody, gravity){
    //     if(physicalBody.speed.x > 0){
    //         physicalBody.speed.x -= gravity;

    //         if(physicalBody.speed.x < 0){
    //             physicalBody.speed.x = 0;
    //         }
    //     }
    // }

    var pokeballCanvas = document.getElementById('pokeball-canvas'),
        pokeballContext = pokeballCanvas.getContext('2d');
    var pokemonImg = document.getElementById('pokeball-rolling');

    pokeballCanvas.width = WIDTH;
    pokeballCanvas.height = HEIGHT;

    var pokemonSprite = createSprite({
        spritesheet: pokemonImg,
        width: pokemonImg.width / 5,
        height: pokemonImg.height,
        context: pokeballContext,
        numberOfFrames: 5,
        loopTicksPerFrame: 5

    });

    var pokeballBody = createPhysicalBody({
        coordinates:{x : WIDTH, y : HEIGHT - pokemonSprite.height},
        speed: {x : -5, y : 0},
        width: pokemonSprite.width,
        height: pokemonSprite.height
    })

    function gameLoop() {

        applyGravityVertical(pikachuBody, 0.1);
        var lastPikachuCoordinates = pikachuBody.move();


        pikachuSprite.render(pikachuBody.coordinates, lastPikachuCoordinates)        
                     .update();

        //var lastPokeballCoordinates = pokeballBody.move();             

        pokemonSprite.render(pokeballBody.coordinates, lastPokeballCoordinates)
                      .update();

                      if(pikachuBody.colideWith(pokeballBody)){
                          //alert('dcvdv')
                          pikachuBody.style('display', 'none');
                      }


        

        window.requestAnimationFrame(gameLoop);
    }

    gameLoop();
});

