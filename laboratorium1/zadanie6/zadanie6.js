const fs = require('fs');

const plikZrodlowy = 'plik_zrodlowy.txt';

const plikDocelowy = 'plik_docelowy.txt';

const strumienOdczytu = fs.createReadStream(plikZrodlowy);

const strumienZapisu = fs.createWriteStream(plikDocelowy);

strumienOdczytu.pipe(strumienZapisu);

strumienOdczytu.on('end', () => {
  console.log('Kopiowanie zakończone.');
});

strumienOdczytu.on('error', (err) => {
  console.error('Wystąpił błąd podczas odczytu pliku źródłowego:', err);
});

strumienZapisu.on('error', (err) => {
  console.error('Wystąpił błąd podczas zapisu do pliku docelowego:', err);
});
