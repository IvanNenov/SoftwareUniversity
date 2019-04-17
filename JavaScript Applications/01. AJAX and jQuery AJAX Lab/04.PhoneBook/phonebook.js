const baseUrl = 'https://phonebook-591a6.firebaseio.com/.json';

function solve() {
    $('#btnLoad').on('click', function () {
        $.ajax({
            url: baseUrl,
            method: 'GET',
            success: onContactsLoad
        });
    });

    function onContactsLoad(data) {
        let phonebook = $('#phonebook');
        phonebook.empty();
        Object.entries(data).forEach(c => {
            if (c) {
                let $li = $('<li>');
                $li.text(`${c[1].Person}: ${c[1].Phone}`);
                phonebook.append($li);
            }
        });
      
    }

    $('#btnCreate').on('click', function () {
        let phone = $('#phone').val();
        let person = $('#person').val();

        $.ajax({
            url: baseUrl,
            method: "POST",
            data: JSON.stringify({
                Person: person,
                Phone: phone
            }),
            success: (res) => console.log(res)
        });

    })

}