function attachEvents() {
    const baseUrl = 'https://messenger-4f911.firebaseio.com/messages.json';
    $('#submit').on('click', submitMessage);
    $('#refresh').on('click', reloadPage);

    function reloadPage() {
        $.ajax({
            url: baseUrl,
            method: 'GET',
            success: loadMsg
        });
    }
    function loadMsg(data) {
        let allMsg = "";
        for(let msg of Object.values(data)){
           allMsg +=  `${msg.author}: ${msg.content}\n`;
           $('#messages').text(allMsg);
        }    
    }
    function submitMessage() {
        let author = $('#author').val();
        let content = $('#content').val();
        let timestamp = Date.now();

        let message = {
            author,
            content,
            timestamp
        };

        $.ajax({
            url: baseUrl,
            method: 'POST',
            data: JSON.stringify(message),
            success: logRes
        });

        function logRes(msg) {
            console.log(msg);
        }

    }
}