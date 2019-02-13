  function register() {
  
    let userName = document.getElementById('username');
    let userNameVal = userName.value;
    let email = document.getElementById('email');
    let emailVal = email.value;
    let pass = document.getElementById('password');
    let passVal = pass.value;
    let pattern = /(.+)@(.+).(com|bg)/gm;
  
    function resetInput() {
      userName.value = '';
      email.value = '';
      pass.value = '';
    }
  
    function message() {
      if (userNameVal.length > 0 && pattern.test(emailVal) && passVal.length > 0) {
        let result = document.getElementById('result');
  
        let heading = document.createElement('h1');
        heading.textContent = 'Successful Registration!';
        result.appendChild(heading);
  
        let regexInput = new RegExp(passVal, 'g');
        let passInAsterix = passVal.replace(regexInput, '*'.repeat(passVal.length));
  
        result.textContent += `Username: ${userNameVal}` + '<br>' + `Email: ${emailVal}` + '<br>' + `Password: ${passInAsterix}`;
  
      }
    
    }
  
    function messageTimeOut() {
      setTimeout(() => {
        message(), 5000
      });
    };
  
    resetInput();
  
    messageTimeOut();
  }