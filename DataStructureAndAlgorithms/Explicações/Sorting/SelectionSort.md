# Selection Sort

### Algoritmo de ordenação por meio da seleção do menor ou maior elemento da array. Utilizando um loop dentro de um loop para comparar os elementos (i aponta para um elemento e j vai percorrendo a array comparando).
### Para implementar, criar uma variável para armazenar o valor do index do menor valor, que começará em 0. Após a comparação se arr[ j ] < arr [ i ] , a var do minIndex irá receber o valor de j e trocará o elemento que está em j para a posição de i.
### Complexidade temporal = O(n²), pois a cada iteração o algoritmo precisa percorrer o restante da array para encontrar o menor elemento. E a complexidade espacial = O(1) , pois não aloca memoria extra, faz tudo dentro do array.


### Obs: Não é necessário iterar o último elemento pois ele será comparado com o penúltimo e estará em ordem após isso.