let assert = require('chai').assert;
class SoftUniFy {
    constructor() {
        this.allSongs = {};
    }

    downloadSong(artist, song, lyrics) {
        if (!this.allSongs[artist]) {
            this.allSongs[artist] = {
                rate: 0,
                votes: 0,
                songs: []
            }
        }

        this.allSongs[artist]['songs'].push(`${song} - ${lyrics}`);

        return this;
    }

    playSong(song) {
        let songArtists = Object.keys(this.allSongs).reduce((acc, cur) => {

            let songs = this.allSongs[cur]['songs']
                .filter((songInfo) => songInfo
                    .split(/ - /)[0] === song);

            if (songs.length > 0) {
                acc[cur] = songs;
            }

            return acc;
        }, {});

        let arr = Object.keys(songArtists);
        let output = "";

        if (arr.length > 0) {

            arr.forEach((artist) => {
                output += `${artist}:\n`;
                output += `${songArtists[artist].join('\n')}\n`;
            });

        } else {
            output = `You have not downloaded a ${song} song yet. Use SoftUniFy's function downloadSong() to change that!`
        }

        return output;
    }

    get songsList() {
        let songs = Object.values(this.allSongs)
            .map((v) => v['songs'])
            .reduce((acc, cur) => {
                return acc.concat(cur);
            }, []);

        let output;

        if (songs.length > 0) {
            output = songs.join('\n');
        } else {
            output = 'Your song list is empty';
        }

        return output;

    }

    rateArtist() {
        let artistExist = this.allSongs[arguments[0]];
        let output;

        if (artistExist) {

            if (arguments.length === 2) {
                artistExist['rate'] += +arguments[1];
                artistExist['votes'] += 1;
            }

            let currentRate = (+(artistExist['rate'] / artistExist['votes']).toFixed(2));
            isNaN(currentRate) ? output = 0 : output = currentRate;

        } else {
            output = `The ${arguments[0]} is not on your artist list.`;
        }

        return output;
    }
}

describe("Softunify", function () {

    it("should contain property allSongs", function () {
        let s = new SoftUniFy();

        assert.equal(s.allSongs.toString(), {});
    });

    it("should add the given information to the allSongs ", function () {
        let s = new SoftUniFy();
        s.downloadSong('Ivan', 'Love', 'a');
        assert.equal(s.allSongs.toString(), { Ivan: { rate: 0, votes: 0, songs: [ 'Love - a' ] } });
    });    

    it("should searches all already downloaded songs and returns them", function () {
        let s = new SoftUniFy();
        s.downloadSong('Ivan', 'Love', 'a');
        s.downloadSong('p', 'pq', 'pw')
        assert.equal(s.playSong('pq').toString(), 'p:\npq - pw\n');
    });

    it("should return string if we don't have the song", function () {
        let s = new SoftUniFy();
        s.downloadSong('Ivan', 'Love', 'a');
        assert.equal(s.playSong('pq').toString(),
         `You have not downloaded a pq song yet. Use SoftUniFy's function downloadSong() to change that!`);
    });

    it("should return string if we don't have at least one song", function () {
        let s = new SoftUniFy();
       
        assert.equal(s.playSong('pq').toString(), 
        `You have not downloaded a pq song yet. Use SoftUniFy's function downloadSong() to change that!`);
    });

    it("should return string if we don't have song in constructor", function () {
        let s = new SoftUniFy();
       
        assert.equal(s.playSong().toString(), 
        `You have not downloaded a undefined song yet. Use SoftUniFy's function downloadSong() to change that!`);
    });

    it("should return songlist", function () {
        let s = new SoftUniFy();
        s.downloadSong('i', 'm', 'n');
        assert.equal(s.songsList.toString(), 
        `m - n`);
    });

    it("should return string if song list is empty", function () {
        let s = new SoftUniFy();
        
        assert.equal(s.songsList.toString(), 
        `Your song list is empty`);
    });

    it("should return 0", function () {
        let s = new SoftUniFy();
        s.downloadSong('a','b','c');
        assert.equal(s.rateArtist('a'), 
        0);
    });

    it("should return str", function () {
        let s = new SoftUniFy();
        assert.equal(s.rateArtist('a').toString(), 
        'The a is not on your artist list.');
    });
});