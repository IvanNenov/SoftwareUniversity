// •	add <string> - adds the following string in an inner collection.
// •	remove <string> - removes all occurrences of the supplied <string> from the inner collection.
// •	print - prints all elements of the inner collection joined by ",".

function list(arr) {

    let command = '';
    let word = '';
    let list = [];

    for (let i = 0; i < arr.length; i++) {

        let currentRow = arr[i].split(' ');
        command = currentRow[0];
        word = currentRow[1];

        if (command === 'add') {

            list.push(word);
        } else if (command === 'remove') {
          for (let i = 0; i < list.length; i++) {
             if (list[i] === word) {
                 list[i] = '';
             }
              
          }

          list = list.filter(x=>x);
        } else if (command === 'print') {
            console.log((list.join(",")));
        }
    }
}

