function fitnessRates(dayOfWeek, service, hours) {

    let money = 0;
    if (service === 'Fitness') {
        if (hours >= 8.00 & hours <= 15.00) {
        
        switch (dayOfWeek) {
            case 'Monday':
            case 'Tuesday':
            case 'Wednesday':
            case 'Thursday':
            case 'Friday':
            money = 5.00;    
                break;

                case 'Saturday':
                case 'Sunday':
                money = 8;
                break;
        
            default:
            çonsole.log('Invalid day of week!')
                break;
        }

    }

    else if(hours >= 15.00 & hours <= 22.00){

        switch (dayOfWeek) {
            case 'Monday':
            case 'Tuesday':
            case 'Wednesday':
            case 'Thursday':
            case 'Friday':
            money = 7.50;    
                break;

                case 'Saturday':
                case 'Sunday':
                money = 8;
                break;
        
            default:
            çonsole.log('Invalid day of week!')
                break;
        }

    }
  }

  else if (service === 'Sauna'){

    if (hours >= 8.00 & hours <= 15.00) {
        
        switch (dayOfWeek) {
            case 'Monday':
            case 'Tuesday':
            case 'Wednesday':
            case 'Thursday':
            case 'Friday':
            money = 4.00;    
                break;

                case 'Saturday':
                case 'Sunday':
                money = 7;
                break;
        
            default:
            çonsole.log('Invalid day of week!')
                break;
        }

    }

    else if(hours >= 15.00 & hours <= 22.00){

        switch (dayOfWeek) {
            case 'Monday':
            case 'Tuesday':
            case 'Wednesday':
            case 'Thursday':
            case 'Friday':
            money = 6.50;    
                break;

                case 'Saturday':
                case 'Sunday':
                money = 7;
                break;
        
            default:
            çonsole.log('Invalid day of week!')
                break;
        }
    }
   }

   else if( service === 'Instructor'){
    if (hours >= 8.00 & hours <= 15.00) {
        
        switch (dayOfWeek) {
            case 'Monday':
            case 'Tuesday':
            case 'Wednesday':
            case 'Thursday':
            case 'Friday':
            money = 10.00;    
                break;

                case 'Saturday':
                case 'Sunday':
                money = 15.00;
                break;
        
            default:
            çonsole.log('Invalid day of week!')
                break;
        }

    }

    else if(hours >= 15.00 & hours <= 22.00){

        switch (dayOfWeek) {
            case 'Monday':
            case 'Tuesday':
            case 'Wednesday':
            case 'Thursday':
            case 'Friday':
            money = 12.50;    
                break;

                case 'Saturday':
                case 'Sunday':
                money = 15;
                break;
        
            default:
            çonsole.log('Invalid day of week!')
                break;
        }
   }
 }

 return money;
}
