function solve() {
	let Course = {
		init: function(title, presentations) {

      validateTitle(title);
      validatePresentations(presentations);

      this.title = title;
      this.presentations = presentations;
      this.students = [];

      return this;
    
		},

		addStudent: function(name) {
      if(!name){
        throw new Error('Invalid input!');
      }

      let fullname = name.split(' ');
      let id = this.students.length + 1;

      validateName(fullname[0]);
      validateName(fullname[1]);

      let len = fullname.length;

      if(len < 2 || len > 2){
        throw new Error('You must enter first and last name !');
      }
      
      let student = {
        firstName : fullname[0],
        lastName : fullname[1],
        id : id,
        homeworks : [],
        examScore : 0,
        finalScore : 0
      };

      this.students.push(student);

      return id;     
		},

		getAllStudents: function() {
      return this.students.map(x =>{
        return{
          firstname : x.firstName,
          lastname : x.lastName,
          id : x.id
        };
      });            
		},

		submitHomework: function(studentID, homeworkID) {
      validateID(studentID);
      validateID(homeworkID);
      
      let lenSt = this.students.length;
      let lenPres = this.presentations.length;

      if(+studentID < 1 || +studentID > lenSt){
        throw new Error('Invalid input');
      }

      if(+homeworkID < 1 || +homeworkID > lenPres ){
        throw new Error('Invalid input');
        
      }

      let studentToSubmit = this.students[studentID - 1];

      if(studentToSubmit.homeworks.indexOf(homeworkID) === -1){
        studentToSubmit.homeworks.push(homeworkID);
      }

      return this;
  
		},

		pushExamResults: function(results) {
      validateResults(results);

      let len = results.length;

      for(let i = 0; i < len ; i += 1) {
        let currentStID = +results[i].studentID,
            currentStResult = +results[i].score;

        validateID(currentStID);

        if(!Number(currentStResult) && !isFinite(currentStResult)){
          throw new Error('You must enter a valid number!');
        }

        let lenSt = this.students.length;

        if(currentStID < 1 || currentStID > lenSt){
          throw new Error('Enter a valid ID');
        }

        if(this.students[currentStID - 1].examScore !== 0){
          throw new Error('Student is in the database');
        }

        this.students[currentStID-1].examScore = currentStResult;
      }
      return this;
		},

		getTopStudents: function() {

      this.students.forEach(student => {
        let homeworkScore = student.homeworks.length / this.presentations.length;
        student.finalScore = (0.75 * student.examScore) + (0.25 * homeworkScore);
      });

      //sort array(best to worst)
      this.students.sort((x, y) => {
        return y.finalScore - x.finalScore;
      });

      let bestStudents = 10,
          best10Students = [];

      if(this.students.length < 10){
        bestStudents = this.students.length;
      }

      for(let i = 0; i < bestStudents ; i += 1) {

        let bestSt = {
          firstName : this.students[i].firstName,
          lastName : this.students[i].lastName,
          id : this.students[i].id
        };

        best10Students.push(bestSt);
        
      }    
      return best10Students;
		}
	};

  function validateTitle(title) {

        if (!title || typeof title !== 'string') {
            throw new Error('Title must be a non-empty string!');
        }

        if (title[0] === ' ' || title[title.length - 1] === ' ') {
            throw new Error('Title cannot start or end with whitespace!');
        }

        let whitespacesCount = title.trim().split(' ').filter(el => {
            return !el;
        }).length;

        if (whitespacesCount > 0) {
            throw new Error('There cannot be consecutive whitespaces int title!');
        }
    }



function validatePresentations(presentations){
  if(presentations.length === 0){
    throw new Error('Presentations array is empty!');
  }

}

function validateName(name){
  let len = name.length;

  if(!name[0].match((/[A-Z]/))){
    throw new Error('First character must be capital!');
  }

  for(let i = 1; i < len-1  ; i += 1) {
    if(!name[i].match(/[a-z]/)){
      throw new Error('All leter, except the first ones, must be lowercase!');
    }
  }
}


  function validateID(id){
    if(!id){
      throw new Error('Enter a valid ID!');
    }
    if(id <= 0 || id % 1 !== 0){
      throw new Error('ID must be greater than zero, integer number !');
    }
    if(typeof id !== 'number'){
      throw new Error('ID is number !');
    }
  }

  function validateResults(results){
    if(!results || !Array.isArray(results)){
      throw new Error('The results must be stored in an arrray!');
    }
  }

	return Course;
}




module.exports = solve;