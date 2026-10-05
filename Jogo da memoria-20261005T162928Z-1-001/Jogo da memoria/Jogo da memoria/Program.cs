// ===========================
// Tabuleiro Jogo da memoria 
// ===========================

using System.ComponentModel;

Char[,] tabuleiro = {
    {'A','B','C' },
    {'D','E','F'},
    {'G','H','I' },
    {'A','B','C' },
    {'D','E','F' },
    { 'G','H','I' },
};

// Controle quais cartas já foram encontradas 
bool[,] encontrada = new bool[6, 6];

// Controla quais cartas estão temporiamente visíveis 
bool[,] visível = new bool[6, 6];

int paresEncontrados = 0;
int tentativas  = 0;

// INÍCIO DO JOGO
Console.WriteLine("=====================");
Console.WriteLine("JOGO DA MEMÓRIA");
Console.WriteLine("=====================");
Console.WriteLine("Memorize as posições das cartas!");
Console.WriteLine(tabuleiro);
Console.WriteLine("Pressione ENTER para começar...");
Console.WriteLine();

// LOOP PRINCIPAL
while (paresEncontrados < 9){
    Console.WriteLine("==============");
    Console.WriteLine();
    Console.WriteLine("==============");
    Console.WriteLine($"Pares encontrados: {paresEncontrados} /9");
    Console.WriteLine($"Tentativas: {tentativas}");

}