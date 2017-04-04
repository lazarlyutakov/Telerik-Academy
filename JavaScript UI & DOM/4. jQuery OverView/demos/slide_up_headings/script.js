
let headings = [];

function selectHeadings(n){
    for(let i = 1; i <= n ; i += 1) {
        let $heading = $(`h${i}`);
        headings.push($heading);     
    }
    return headings;
}

function hideHeadings(numbOfHeadings){
    let arr = selectHeadings(numbOfHeadings);

    arr.forEach(el => {
        el.on('click', function(){
            el.slideUp();
        });
    });
}

hideHeadings(3);