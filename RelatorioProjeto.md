# Royal Game of UR - Projeto LP1

## Autoria
- António Vieira - a22204411
- Todo o projeto foi feito somente por mim (António Vieira)
- Repositório Git - https://github.com/AntonioLVieira/ProjetoFinalLP1.git

## Arquitetura da Solução

*Class Board*:

- Representa o estado do tabuleiro e as informações dos jogadores.
- Contém também variáveis que guardam o estado do tabuleiro, as posições dos jogadores e o número de peças de cada jogador.
- Construtor para inicializar o tabuleiro e as informações dos jogadores.

Métodos existentes:
- GetPiece(): Coloca a peça na posição correta.
- MovePiece(): Move a peça do jogador tendo em conta o número de passos.
- CheckWin(): Verifica se um jogador venceu (número de peças = 0).
- DestroyPiece(): Remove a peça do jogador da posição onde se encontra.

*Class Program*:

- método Main(), que é a primeira função a ser chamada, quando o programa é executado
- Cria uma instância da classe Board
- Define o jogador atual como o Jogador 1 (É o primeiro jogador a jogar).
- Usa um loop infinito para alternar entre os jogadores até que um deles vença.
- Gera um número aleatório de passos para cada jogador (Com a função Random()).
- Chama todos os métodos da class Board para pôr o jogo a funcionar (movimento das pessas + vencedor)
- Chama o método GameBoard para mostrar o estado atual do tabuleiro.

### *Referências*

*ChatGPT* - foi usado para criar alguns símbolos para o tabuleiro (ex.: ║, ╬, ═)

### *Bibliotecas* 
- System
