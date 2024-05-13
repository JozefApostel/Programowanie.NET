const fs = require('fs');

// Nazwa pliku tekstowego do odczytu
const nazwaPliku = 'tekstowy_plik.txt';

// Otwarcie pliku za pomocą FileStream
const fileStream = fs.createReadStream(nazwaPliku);

// Obsługa zdarzenia odczytu
fileStream.on('data', (chunk) => {
  console.log(chunk.toString());
});

// Obsługa zdarzenia błędu
fileStream.on('error', (err) => {
  console.error('Wystąpił błąd podczas odczytu pliku:', err);
});

// Obsługa zdarzenia zakończenia odczytu
fileStream.on('end', () => {
  console.log('Odczyt pliku zakończony.');
});
