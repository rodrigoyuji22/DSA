# Alphabet Array Pattern
### Utilizado para armazenar a frequencia de aparições de cada caractere em uma string, utilizando o índice como chave e o valor como contagem.
### Dentro de um loop foreach(char c in word), percorrer todas os caracteres da string e incrementar por posição, sendo A = [0] e Z = [25] em uma array de tamanho 26. Assim arr[c - 'a']++ .  Pois irá utilizar o ASCII 97 para transformar o caractere em um valor numerico. Se a = 97, count['a' - 'a']++ significa incrementar o valor na posição 0 do array, pois 97 - 97 == 0 ;
