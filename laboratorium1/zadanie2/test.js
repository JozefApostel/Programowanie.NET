const Samochod = require('./samochod');
const Garaz = require('./garaz');

const s1 = new Samochod("Fiat", "126p", 2, 650, 6.0);
const s2 = new Samochod("Syrena", "105", 2, 800, 7.6);

const g1 = new Garaz();
g1.adres = "ul. Garażowa 1";
g1.pojemnosc = 1;

const g2 = new Garaz("ul. Garażowa 2", 2);

g1.wprowadzSamochod(s1);
g1.wypiszInfo();
g1.wprowadzSamochod(s2);

g2.wprowadzSamochod(s2);
g2.wprowadzSamochod(s1);

g2.wypiszInfo();
g2.wyprowadzSamochod();
g2.wypiszInfo();
g2.wyprowadzSamochod();
g2.wyprowadzSamochod();
