

let obj = {
    prop1 : 2,
    prop2 : [],
    prop3 : function(){
        return console.log('I am useless function');
    },
    prop4 : {
        subprop : 8,
        subprop2 : [1, 2, 3]
    }
};

obj.prop3();


console.log(obj);