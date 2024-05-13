const fs = require('fs');

// Nazwa pliku tekstowego do odczytu
const nazwaPliku = 'tekstowy_plik.txt';

// Otwarcie pliku i wczytanie linii po linii
fs.readFile(nazwaPliku, 'utf8', (err, data) => {
  if (err) {
    console.error('Wystąpił błąd podczas odczytu pliku:', err);
    return;
  }

  // Podziel wczytane dane na linie
  const lines = data.split('\n');

  // Iteruj przez każdą linię i wyświetl ją odwróconą
  lines.forEach(line => {
    const reversedLine = reverseString(line.trim()); // Odwrócenie linii
    console.log(reversedLine);
  });
});

// Funkcja do odwracania stringa
function reverseString(str) {
  return str.split('').reverse().join('');
}
