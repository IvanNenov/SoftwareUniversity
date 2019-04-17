const movieService = (() => {
    function createMovie(data) {
       return kinvey.post('appdata', 'movies', 'kinvey', data);
    }

    function getAllMovies() {
        return kinvey.get('appdata', 'movies', 'kinvey', '?query={}&sort={"tickets": -1}');
    }
    function getMyMovies() {
        return kinvey.get('appdata', 'movies', 'kinvey');
    }
    return{
        createMovie,
        getAllMovies,
        getMyMovies
    }
})();