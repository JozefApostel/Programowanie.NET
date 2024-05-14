const fs = require('fs');

const nazwaPliku = 'tekstowy_plik.txt';

const fileStream = fs.createReadStream(nazwaPliku);

fileStream.on('data', (chunk) => {
  console.log(chunk.toString());
});

fileStream.on('error', (err) => {
  console.error('Wystąpił błąd podczas odczytu pliku:', err);
});

fileStream.on('end', () => {
  console.log('Odczyt pliku zakończony.');
});
