const handlers = {}

$(() => {
  const app = Sammy('#root', function () {
    this.use('Handlebars', 'hbs');
    // home page routes
    this.get('/index.html', handlers.getHome);
    this.get('/', handlers.getHome);
    this.get('#/home', handlers.getHome);

    // user routes
    this.get('#/register', handlers.getRegister);
    this.get('#/login', handlers.getLogin);

    this.post('#/register', handlers.registerUser);
    this.post('#/login', handlers.loginUser);
    this.get('#/logout', handlers.logoutUser);
    // Movies
    this.get('#/cinema', handlers.getCinema);
    this.get('#/createMovie', handlers.getCreateMovie);
    this.get('#/myMovies', handlers.getMyMovies);

    this.post('#/createMovie', handlers.createMovie);
    // ADD YOUR ROUTES HERE
  });
  app.run('#/home');
});