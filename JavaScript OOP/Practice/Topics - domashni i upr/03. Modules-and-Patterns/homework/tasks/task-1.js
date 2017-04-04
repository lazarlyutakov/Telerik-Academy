/* Task Description */
/* 
* Create a module for a Telerik Academy course
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  * There is a set of students listed for the course
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  * Create method init
    * Accepts a string - course title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
  * Create method addStudent which lists a student for the course
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
  * Create method submitHomework
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/
'use strict';

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

        if(currentStID < 1 || currentStID > this.students.length){
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
  if(!presentations || !Array.isArray(presentations) || presentations.length === 0){
    throw new Error('Presentations array is empty!');
  }

  for (let i = 0, len = presentations.length; i < len; i += 1) {
            validateTitle(presentations[i]);
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
    if(id % 1 !== 0){
      throw new Error('ID must be greater than zero, integer number !');
    }
    if(!Number(id)){
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














// function solve() {

//     let Course = {
//         init: function(title, presentations) {
//             validateTitle(title);
//             validatePresentations(presentations);

//             this.title = title;
//             this.presentations = presentations;
//             this.students = [];

//             return this;
//         },
//         addStudent: function(name) {

//             if (!name) {
//                 throw new Error('Invalid parameter for student name passed!');
//             }

//             let bothNames = name.split(' ').filter(name => {
//                 return name;
//             });

//             if (bothNames.length !== 2) {
//                 throw new Error('Parameter must consist of both first and last name!');
//             }

//             validateName(bothNames[0]);
//             validateName(bothNames[1]);

//             let id = this.students.length + 1;
//             let student = {
//                 firstName: bothNames[0],
//                 lastName: bothNames[1],
//                 id: id,
//                 homeworks: [],
//                 examScore: 0,
//                 finalScore: 0
//             };

//             this.students.push(student);

//             return id;
//         },
//         getAllStudents: function() {
//             //deep copy
//             return this.students.map(st => {
//                 return {
//                     firstname: st.firstName,
//                     lastname: st.lastName,
//                     id: st.id
//                 };
//             });
//         },
//         submitHomework: function(studentID, homeworkID) {

//             validateID(studentID);
//             validateID(homeworkID);

//             studentID = +studentID;
//             homeworkID = +homeworkID;

//             if (studentID < 1 || studentID > this.students.length) {
//                 throw new Error('Invalid student ID!');
//             }

//             if (homeworkID < 1 || homeworkID > this.presentations.length) {
//                 throw new Error('Invalid homework ID!');
//             }

//             let currStudent = this.students[studentID - 1];

//             if (currStudent.homeworks.indexOf(homeworkID) === -1) {
//                 currStudent.homeworks.push(homeworkID);
//             }

//             return this;
//         },
//         pushExamResults: function(results) {

//             validateExamResults(results);

//             for (let i = 0, len = results.length; i < len; i += 1) {
//                 let currStudentID = results[i].StudentID,
//                     currStudentScore = results[i].score;

//                 validateID(currStudentID);

//                 if (!Number(currStudentScore) && !isFinite(currStudentScore)) {
//                     throw new Error('Student score must be a valid number!');
//                 }

//                 currStudentID = +currStudentID;
//                 currStudentScore = +currStudentScore;

//                 if (currStudentID < 1 || currStudentID > this.students.length) {
//                     throw new Error('Invalid student ID!');
//                 }

//                 if (this.students[currStudentID - 1].examScore !== 0) {
//                     throw new Error('This student already has a score!');
//                 }

//                 this.students[currStudentID - 1].examScore = currStudentScore;
//             }

//             return this;
//         },
//         getTopStudents: function() {

//               this.students.forEach(student => {
//                     let hwScore = student.homeworks.length / this.presentations.length;
//                     student.finalScore = (0.75 * student.examScore) + (0.25 * hwScore);
//               });

//               this.students.sort((st1, st2) => {
//                   return st2.finalScore - st1.finalScore;
//               });

//               let topStudentsCount = 10,
//                   topTenStudents = [];

//               if (this.students.length < 10) {
//                   topStudentsCount = this.students.length;
//               }

//               for (let i = 0; i < topStudentsCount; i += 1) {
//                   let topStudent = {
//                       firstName: this.students[i].firstName,
//                       lastName: this.students[i].lastName,
//                       id: this.students[i].id
//                   };

//                   topTenStudents.push(topStudent);
//               }

//               return topTenStudents;
//         }
//     };

//     //Validation functions
//     function validateTitle(title) {

//         if (!title || typeof title !== 'string') {
//             throw new Error('Title must be a non-empty string!');
//         }

//         if (title[0] === ' ' || title[title.length - 1] === ' ') {
//             throw new Error('Title cannot start or end with whitespace!');
//         }

//         let whitespacesCount = title.trim().split(' ').filter(el => {
//             return !el;
//         }).length;

//         if (whitespacesCount > 0) {
//             throw new Error('There cannot be consecutive whitespaces int title!');
//         }
//     }

//     function validatePresentations(presentations) {

//         if (!presentations || !Array.isArray(presentations) || presentations.length === 0) {
//             throw new Error('Invalid presentations parameter!');
//         }

//         for (let i = 0, len = presentations.length; i < len; i += 1) {
//             validateTitle(presentations[i]);
//         }
//     }

//     function validateName(name) {

//         let firstChar = name.charCodeAt(0);

//         if (firstChar < 65 || firstChar > 90) {
//             throw new Error('Name must start with a capital letter!');
//         }

//         for (let i = 1, len = name.length; i < len; i += 1) {
//             if (name.charCodeAt(i) < 97 || name.charCodeAt(i) > 122) {
//                 throw new Error('Except first letter, all symbols in name must be lowercase letters!');
//             }
//         }
//     }

//     function validateID(id) {

//         if (!id) {
//             throw new Error('Invalid input for id!');
//         }

//         if (id % 1 !== 0) {
//             throw new Error('Id must be an integer number!');
//         }

//         if (!Number(id)) {
//             throw new Error('Id must be a number!');
//         }
//     }

//     function validateExamResults(results) {
        
//         if (!results || !Array.isArray(results)) {
//             throw new Error('Exam results must be passed as an array!');
//         }
//     }

//     return Course;
// }

// module.exports = solve;







  