function attachEvents() {
    const loadBtn = $('#btnLoadPosts');
    const postDropDown = $('#posts');
    const kinveyAppId = "kid_S1htVfcmm";
    const serviceUrl = 'https://baas.kinvey.com/appdata/' + kinveyAppId + '/posts';
    const kinveyUsername = 'peter';
    const kinveyPass = 'p';
    const base64auth = btoa(kinveyUsername + ':' + kinveyPass);
    const authHeaders = {
        "Authorization": "Basic " + base64auth
    };

    function loadPost() {
        return fetch(serviceUrl, {
            method: 'GET',
            headers: new Headers(authHeaders),

        });
    }

    loadBtn.on('click', () => {
        console.log('xaxa')
        loadPost()
            .then(res => res.json())
            .then(posts => () => {
               posts.forEach(post => {
                   console.log(post)
                   postDropDown.append(`<option>${post.title}</option>`);
               });
            })
    });


}