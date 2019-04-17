function attachEvents() {

    let weatherSymbolsObj = {
        Sunny: "☀",
        'Partly sunny': "⛅",
        Overcast: "☁",
        Rain: "☂",
        Degrees: "°"
    };

    $('#submit').on('click', getLocation);

    function getLocation() {
        let baseurl = `https://judgetests.firebaseio.com/locations.json`;
        let currentCode = '';

        $.get(baseurl)
            .then(findCorespondingName)
            .catch(handleError);
    }

    function handleError() {
        $("#forecast").html("Error");
    }

    function findCorespondingName(data) {
        let location = $('#location').val();

        for (let i = 0; i < data.length; i++) {
            if (data[i].code === location) {
                currentCode = location;
            }
        }
      
        $.get(`https://judgetests.firebaseio.com/forecast/today/${currentCode}.json`)
            .then(renderCurrentCondition);

        $.get(`https://judgetests.firebaseio.com/forecast/upcoming/${currentCode}.json`)
            .then(renderNext3DaysWeather);
    }

    function renderCurrentCondition(data) {
        visibleForecast();

        let weather = (data.forecast.condition);

        let symbol = weatherSymbolsObj[weather];
        let name = data.name;
        let degreeLow = data.forecast.low;
        let degreeHigh = data.forecast.high;

        let appendSymbol = $(`<span class="condition symbol">${symbol}</span>`);

        let forecastName = $(`<span class="forecast-data">${name}</span>`);
        let forecastDegree = $(`<span class="forecast-data">${degreeLow}°/${degreeHigh}°</span>`);
        let forecastWeather = $(`<span class="forecast-data">${weather}</span>`);

        $('#current').append(appendSymbol);

        $('#current').append(forecastName);
        $('#current').append(forecastDegree);
        $('#current').append(forecastWeather);

    }

    function renderNext3DaysWeather(data) {
        visibleForecast();

        for (const element of Object.values(data.forecast)) {
            let low = element.low;
            let high = element.high;
            let condition = element.condition;
            let spanClass = $('<span class="upcoming">');
            let spanSymbol = $(`<span class="symbol">${weatherSymbolsObj[condition]}</span>`);
            let spanDegree = $(`<span class="forecast-data">${low}°/${high}°</span>`);
            let spanCondition = $(`<span class="forecast-data">${condition}</span>`);

            $('#upcoming').append(spanClass);
            $('#upcoming').append(spanSymbol);
            $('#upcoming').append(spanDegree);
            $('#upcoming').append(spanCondition);
        }

    }

    function visibleForecast() {
        $('#forecast').removeAttr('style');
    }

   
}