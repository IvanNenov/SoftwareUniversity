function loadCommits() {
    $("#commits").empty();
    let username = $('#username').val();
    let repo = $('#repo').val();
    let commitsList = $("#commits");
    const baseUrl = `https://api.github.com/repos/${username}/${repo}/commits`;

    $.get(baseUrl)
        .then((data) => {
            Array.from(data).forEach(e => {
                let authorName = e.commit.author.name;
                let commitMsh = e.commit.message;
                let result = `${authorName}: ${commitMsh}`;
                commitsList.append($(`<li>${result.toString()}</li>`))
            });
        })
        .catch((error) => {
            commitsList.html('');
            let result = `Error: ${error.status} (${error.statusText})`;
            commitsList.append(`<li>${result.toString()}</li>`);
        });
}

