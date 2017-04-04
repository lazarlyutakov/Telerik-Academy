(function () {
  // We keep these variables private inside this closure scope
  
  var myGrades = [93, 95, 88, 0, 55, 91];
  
  var average = function() {
    var total = myGrades.reduce((x, y) => x + y, 0);
    
      return 'Your average grade is ' + total / myGrades.length + '.';
  }

  var failing = function(){
    var failingGrades = myGrades.filter(x => x < 80);
      
    return 'You failed ' + failingGrades.length + ' times.';
  }
console.log(total);
  console.log(failing());
  console.log(average());

}());