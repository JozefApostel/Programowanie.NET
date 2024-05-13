class Samochod {
    constructor(marka = "nieznana", model = "nieznany", iloscDrzwi = 0, pojemnoscSilnika = 0.0, srednieSpalanie = 0.0) {
        this.marka = marka;
        this.model = model;
        this.iloscDrzwi = iloscDrzwi;
        this.pojemnoscSilnika = pojemnoscSilnika;
        this.srednieSpalanie = srednieSpalanie;
        Samochod.iloscSamochodow++;
    }

    static iloscSamochodow = 0;

    // Metoda obliczająca średnie spalanie na danej trasie
    obliczSpalanie(dlugoscTrasy) {
        return (this.srednieSpalanie * dlugoscTrasy) / 100.0;
    }

    // Metoda obliczająca koszt przejazdu na podstawie długości trasy i ceny paliwa
    obliczKosztPrzejazdu(dlugoscTrasy, cenaPaliwa) {
        const spalanie = this.obliczSpalanie(dlugoscTrasy);
        return spalanie * cenaPaliwa;
    }

    // Metoda wypisująca informacje o samochodzie
    wypiszInfo() {
        console.log("Marka: " + this.marka);
        console.log("Model: " + this.model);
        console.log("Ilość drzwi: " + this.iloscDrzwi);
        console.log("Pojemność silnika: " + this.pojemnoscSilnika + " cm^3");
        console.log("Średnie spalanie: " + this.srednieSpalanie + " l/100km");
    }

    // Metoda wypisująca liczbę utworzonych samochodów
    static wypiszIloscSamochodow() {
        console.log("Liczba utworzonych samochodów: " + Samochod.iloscSamochodow);
    }
}

module.exports = Samochod;
