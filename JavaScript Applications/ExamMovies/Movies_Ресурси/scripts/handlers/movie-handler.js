handlers.getCinema =async function (ctx) {
    ctx.isAuth = userService.isAuth();
    ctx.username = sessionStorage.getItem('username');

    ctx.movies = await movieService.getAllMovies();

    ctx.loadPartials({
      header: '../templates/common/header.hbs',
      footer: '../templates/common/footer.hbs',
      movie: '../templates/movie/movie.hbs'
    }).then(function () {
      this.partial('../templates/movie/cinemaPage.hbs');
    }).catch(function (err) {
      console.log(err);
    });
  }

  handlers.getCreateMovie =  function (ctx) {
    ctx.isAuth = userService.isAuth();
    ctx.username = sessionStorage.getItem('username');

    ctx.loadPartials({
      header: '../templates/common/header.hbs',
      footer: '../templates/common/footer.hbs'
    }).then(function () {
      this.partial('../templates/movie/addMoviePage.hbs');
    }).catch(function (err) {
      console.log(err);
    });
  }

  
  handlers.getMyMovies = async function (ctx) {
    ctx.isAuth = userService.isAuth();
    ctx.username = sessionStorage.getItem('username');

    try {
        let movies = await movieService.getMyMovies();
        let userId = sessionStorage.getItem('id');
        
        let myMovies = movies.filter((movie) => movie._acl.creator === userId);

        ctx.movies = myMovies;

        ctx.loadPartials({
            header: '../templates/common/header.hbs',
            footer: '../templates/common/footer.hbs',
            movie: '../templates/movie/myM.hbs'
        }).then(function () {
        this.partial('../templates/movie/myM.hbs');
        }).catch(function (err) {
            console.log(err);
        });
    } catch (e) {
        console.log(e);
    }
  }

  handlers.createMovie = function (ctx) {
     let data = {...ctx.params};
     if (data.title.length < 6 || data.description.length < 10) {
         notifications.showError('Invalid title or description');
         return;
     }
     movieService.createMovie(data).then(function(res) {
         notifications.showSuccess('Movie created successfully.');
         ctx.redirect('#/home');
     }).catch(function() {
         
     })
  }
  
  