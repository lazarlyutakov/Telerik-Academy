var hbTemplate = `
{{#if student.length}}
 <p>First student is {{student.[0].name}}</p>
<ul> 
  {{#student}}
  <li>{{name}} is {{age}} years old</li>
  {{/student}}
 </ul> 
   {{else}}
   <p>nothing</p>
   {{/if}}
`;

var template = Handlebars.compile(hbTemplate);

var data = {
    student2: [],
    student:[
        {name: 'Cuki', age: 21},
        {name: 'Doncho', age: 55},
        {name: 'Pesho', age: 64},
        {name: 'Gosho', age: 41}
    ]
};

var container = document.getElementById('hb-container');
container.innerHTML = template(data);
