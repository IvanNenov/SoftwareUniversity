handlers.getRegister = function (ctx) {
  ctx.loadPartials({
    header: '../templates/common/header.hbs',
    footer: '../templates/common/footer.hbs'
  }).then(function () {
    this.partial('../../templates/user/registerPage.hbs');
  }).catch(function (err) {
    console.log(err);
  });
}

handlers.getLogin = function (ctx) {
  ctx.loadPartials({
    header: '../templates/common/header.hbs',
    footer: '../templates/common/footer.hbs'
  }).then(function () {
    this.partial('../../templates/user/loginPage.hbs');
  }).catch(function (err) {
    console.log(err);
  });
}

handlers.registerUser = function (ctx) {
  let username = ctx.params.username;
  let password = ctx.params.password;
  
  if (username !== '' && username.length >= 3 && password.length >= 6) {
    notifications.showSuccess('User registration successful.');
    
    userService.register(username, password).then((res) => {

      userService.saveSession(res);
      notifications.showSuccess('User registered successfully');
      ctx.redirect('#/home');
    }).catch(function (err) {
      notifications.showError(err.responseJSON.description);
    });
  }

  else if (username.length < 3 || username == '') {
    notifications.showError('Username must be at least 3 symbols');
    return;
  }
  
  else if (password.length < 6) {
    notifications.showError('Password must be at least 6 symbols');
    return;
  }
}

handlers.logoutUser = function (ctx) {
  userService.logout().then(() => {
    sessionStorage.clear();
    notifications.showSuccess('User logged out successfully');
    ctx.redirect('#/home');
  })
}

handlers.loginUser = function (ctx) {
  let username = ctx.params.username;
  let password = ctx.params.password;
  userService.login(username, password).then((res) => {
    userService.saveSession(res);
    notifications.showSuccess('User logged in successfully');
    ctx.redirect('#/home');
  }).catch(function (err) {
    notifications.showError(err.responseJSON.description);
  });
}