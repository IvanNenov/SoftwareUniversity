function timer() {
   let isTriggered = false;

   let hours = $('#hours');
   let mins = $('#minutes');
   let secounds = $('#seconds');

   let btnStart = $('#start-timer');
   let btnStop = $('#stop-timer');

   let hoursCounter = 0;
   let minutesCounter = 0;
   let secondsCounter = 0;

   function increment() {
      isTriggered = true;
      secondsCounter++;

      if (secondsCounter > 59) {
         secondsCounter = 0;
         minutesCounter++;
      } else if (minutesCounter > 59) {
         minutesCounter=0;
         hoursCounter++;
      }

      if (hoursCounter < 10) {
         hours.text('0' + hoursCounter.toString());
      }
      else{
         hours.text(hoursCounter.toString());
      }

      if (minutesCounter < 10) {
         mins.text('0' + minutesCounter.toString());
      }
      else{
         mins.text(minutesCounter.toString());
      }

      if (secondsCounter < 10) {
         secounds.text('0' + secondsCounter.toString());
      }
      else{
         secounds.text(secondsCounter.toString());
      }
   }
   let intervalFunction;

   btnStart.on('click', function() {
      if (!isTriggered) {
         intervalFunction = setInterval(increment,1000);
      }
   });

   btnStop.on('click', function() {
      isTriggered = false;
      clearInterval(intervalFunction);
   });
}