const Samochod = require('./samochod');

// Przykładowe użycie klasy Samochod
const s1 = new Samochod();
s1.wypiszInfo();

s1.marka = "Fiat";
s1.model = "126p";
s1.iloscDrzwi = 2;
s1.pojemnoscSilnika = 650;
s1.srednieSpalanie = 6.0;
s1.wypiszInfo();

const s2 = new Samochod("Syrena", "105", 2, 800, 7.6);
s2.wypiszInfo();

const kosztPrzejazdu = s2.obliczKosztPrzejazdu(30.5, 4.85);
console.log("Koszt przejazdu: " + kosztPrzejazdu);

Samochod.wypiszIloscSamochodow();
