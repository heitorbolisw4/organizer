// escrever um codigo que possibilita a selecao de opcoes atraves do console
// 1 - listar arquivos; 2 - renomear arquivos; 3 - excluir arquivos; 4 - sair

using System;
using System.IO;
using dyrec.Internal;

string filePath = @"C:\Users\heito\Downloads";



if (!Directory.Exists(filePath))
{
    Console.WriteLine("O caminho não existe...");
    return;
}

Console.WriteLine($"Organizer iniciado em {filePath}");



Console.WriteLine("selecione uma opcao: ");



bool close = false;
do
{
    // exibir menu

    Console.WriteLine("1 - listar arquivos");
    Console.WriteLine("2 - renomear arquivos");
    Console.WriteLine("3 - excluir arquivos");
    Console.WriteLine("4 - sair");
    Console.Write("> ");

    // ler input do user
    string input = Console.ReadLine();
    if(!int.TryParse(input, out int option))
    {
        Console.WriteLine("opcao invalida, tente novamente");
        continue;
    }

    switch (option)
    {
        case 1:
            Organizer.Listar(filePath);
            break;
        case 2:
            Organizer.Organizar(filePath);
            break;
        case 3:
            Console.WriteLine("EXCLUIR arquivos?\n" +
                "y - sim\n" +
                "n - não\n");
            var confirm = Console.ReadLine();
            if (confirm?.ToLower() == "y")
            {
                Organizer.Excluir(filePath);

            }
            else
            {
                Console.WriteLine("encerrando operacao");
            }
            break;
        case 4:
            close = true;
            Console.WriteLine("encerrando organizer '-'...");
            break;
        default:
            Console.WriteLine("desconheco opcao =/...");
            break;
    }
}
while (close == false);