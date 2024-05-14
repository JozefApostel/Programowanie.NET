const fs = require('fs');

const nazwaPliku = 'tekstowy_plik.txt';

fs.readFile(nazwaPliku, 'utf8', (err, data) => {
  if (err) {
    console.error('Wystąpił błąd podczas odczytu pliku:', err);
    return;
  }

  const lines = data.split('\n');


  lines.forEach(line => {
    const reversedLine = reverseString(line.trim()); 
    console.log(reversedLine);
  });
});

function reverseString(str) {
  return str.split('').reverse().join('');
}
