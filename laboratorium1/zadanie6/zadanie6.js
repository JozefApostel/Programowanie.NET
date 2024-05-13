const fs = require('fs');

// Nazwa pliku źródłowego
const plikZrodlowy = 'plik_zrodlowy.txt';

// Nazwa pliku docelowego
const plikDocelowy = 'plik_docelowy.txt';

// Utwórz strumień do odczytu danych z pliku źródłowego
const strumienOdczytu = fs.createReadStream(plikZrodlowy);

// Utwórz strumień do zapisu danych do pliku docelowego
const strumienZapisu = fs.createWriteStream(plikDocelowy);

// Kopiowanie danych z pliku źródłowego do pliku docelowego
strumienOdczytu.pipe(strumienZapisu);

// Obsługa zdarzenia zakończenia kopiowania
strumienOdczytu.on('end', () => {
  console.log('Kopiowanie zakończone.');
});

// Obsługa zdarzenia błędu
strumienOdczytu.on('error', (err) => {
  console.error('Wystąpił błąd podczas odczytu pliku źródłowego:', err);
});

strumienZapisu.on('error', (err) => {
  console.error('Wystąpił błąd podczas zapisu do pliku docelowego:', err);
});
