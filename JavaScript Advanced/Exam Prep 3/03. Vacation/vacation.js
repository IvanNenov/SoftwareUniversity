class Vacation {
    constructor(organizer, destination, budget) {
        this.organizer = organizer;
        this.destination = destination;
        this.budget = budget;
        this.kids = {};
    }

    registerChild(name, grade, budget) {
        if (this.kids[grade] === undefined) {
            this.kids[grade] = [];
        }

        if (budget >= this.budget) {
            let result = (`${name} - ${budget}`);
            let existKid = Array.from(this.kids[grade]).some((kid) => {
                let splitKidInfo = kid.split('-');
                let kidName = splitKidInfo[0];
                if (kidName === name) {
                    return true;
                } else {
                    return false;
                }
            });

            if (existKid) {
                return `${name} is already in the list for this ${this.destination} vacation.`;
            } else {
                this.kids[grade].push(result);
            }
        } else {
            return `${name}'s money is not enough to go on vacation to ${this.destination}.`;
        }
    }

    removeChild(name, grade) {
        let kidInfo = "";
        if (this.kids[grade] === undefined) {
            return "We couldn't find " + name.toString() + " in " + grade.toString() + " grade.";
        } else if (this.kids[grade].length === 0) {
            return "We couldn't find " + name.toString() + " in " + grade.toString() + " grade.";
        }

        let doesKidExist = Array.from(this.kids[grade]).some((k) => {
            let splitElement = k.split("-");
            let kidName = splitElement[0];

            if (kidName === name) {
                kidInfo = k;
                return true;
            }
            return false;
        });

        if (doesKidExist === true) {
            let kidIndex = Array.from(this.kids[grade]).indexOf(kidInfo);

            (this.kids[grade]).splice(kidIndex, 1);

            return this.kids[grade];
        } else {
            return "We couldn't find " + name.toString() + " in " + grade.toString() + " grade.";
        }
    }

    toString() {
        if (this.numberOfChildren === 0) {
            return "No children are enrolled for the trip and the organization of " + this.organizer.toString() + " falls out...";
        } else {
            let result = "";
            result += this.organizer.toString() + " will take " + this.numberOfChildren.toString() + " children on trip to " + this.destination.toString() + "\n";

            Object.keys(this.kids).sort((a, b) => parseInt(a) - parseInt(b)).forEach((grd) => {
                if (Array.from(this.kids[grd]).length !== 0) {
                    result += "Grade: " + grd.toString() + "\n";
                    Array.from(this.kids[grd]).forEach((kid, kidIndex) => {
                        let currentIndex = parseInt(kidIndex) + 1;

                        result += currentIndex.toString() + ". " + kid.toString() + "\n";
                    });
                }
            });

            return result;
        }
    }

    get numberOfChildren() {
        let totalKidsCount = 0;

        Object.keys(this.kids).forEach((gr) => {
            totalKidsCount += Array.from(this.kids[gr]).length;
        });

        return totalKidsCount;
    }
}
