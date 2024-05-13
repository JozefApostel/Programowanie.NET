const fs = require('fs');
const readline = require('readline');

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

function zapiszDoPliku() {
  rl.question('Podaj imię: ', (imie) => {
    rl.question('Podaj wiek: ', (wiek) => {
      rl.question('Podaj adres: ', (adres) => {
        const dane = { imie, wiek, adres };
        const plik = 'dane.bin';
        const strumien = fs.createWriteStream(plik);
        strumien.write(Buffer.from(JSON.stringify(dane)));
        strumien.end();
        console.log('Dane zostały zapisane do pliku: ' + plik);
        rl.close();
      });
    });
  });
}

function odczytajZPliku() {
  const plik = 'dane.bin';
  const strumien = fs.createReadStream(plik);
  let dane = '';

  strumien.on('data', (chunk) => {
    dane += chunk;
  });

  strumien.on('end', () => {
    const zdekodowaneDane = JSON.parse(Buffer.from(dane).toString());
    console.log('Imię:', zdekodowaneDane.imie);
    console.log('Wiek:', zdekodowaneDane.wiek);
    console.log('Adres:', zdekodowaneDane.adres);
    rl.close();
  });

  strumien.on('error', (err) => {
    console.error('Wystąpił błąd podczas odczytu pliku:', err);
    rl.close();
  });
}

rl.question('Co chcesz zrobić? (1 - Zapisz do pliku, 2 - Odczytaj z pliku): ', (opcja) => {
  if (opcja === '1') {
    zapiszDoPliku();
  } else if (opcja === '2') {
    odczytajZPliku();
  } else {
    console.log('Niepoprawna opcja.');
    rl.close();
  }
});
