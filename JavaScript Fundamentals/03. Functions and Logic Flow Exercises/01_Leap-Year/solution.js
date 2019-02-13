function leapYear() {
    let input = document.querySelector("input");
    let h2 = document.querySelector("#year h2");
    let div = document.querySelector("#year div");
    let btn = document.querySelector("button");

    btn.addEventListener("click", function () {
        let year = (Number)(input.value);
        function isLeapYear(year) {
            if (year % 4 === 0 && year % 100 !== 0){
                return true;
            }

            if (year % 400 === 0) {
                return true
            }
            else false
        }
        if (isLeapYear(year)) {
            h2.textContent = "Leap Year";
            div.textContent = year;
        }
        else {
            h2.textContent = "Not Leap Year";
            div.textContent = year;
        }

        input.value = "";
    })
}