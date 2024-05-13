const Samochod = require('./samochod');

class Garaz {
    constructor(adres = "nieznany", pojemnosc = 0) {
        this.adres = adres;
        this.pojemnosc = pojemnosc;
        this.liczbaSamochodow = 0;
        this.samochody = new Array(pojemnosc).fill(null);
    }

    set pojemnosc(value) {
        this._pojemnosc = value;
        this.samochody = new Array(value).fill(null);
    }

    get pojemnosc() {
        return this._pojemnosc;
    }

    wprowadzSamochod(samochod) {
        if (this.liczbaSamochodow < this.pojemnosc) {
            this.samochody[this.liczbaSamochodow++] = samochod;
        } else {
            console.log("Garaz jest pelny.");
        }
    }

    wyprowadzSamochod() {
        if (this.liczbaSamochodow > 0) {
            const ostatniSamochod = this.samochody[--this.liczbaSamochodow];
            this.samochody[this.liczbaSamochodow] = null;
            return ostatniSamochod;
        } else {
            console.log("Garaz jest pusty.");
            return null;
        }
    }

    wypiszInfo() {
        console.log("Adres: " + this.adres);
        console.log("Pojemność: " + this.pojemnosc);
        console.log("Liczba samochodów: " + this.liczbaSamochodow);
        console.log("Informacje o samochodach:");
        this.samochody.forEach((samochod, index) => {
            if (samochod !== null) {
                console.log("Samochod " + (index + 1) + ":");
                samochod.wypiszInfo();
            }
        });
    }
}

module.exports = Garaz;
