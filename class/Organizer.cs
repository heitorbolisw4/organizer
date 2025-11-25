using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Text;
using FileSystem = Microsoft.VisualBasic.FileIO.FileSystem;


namespace dyrec.Internal
{
    internal class Organizer
    {
        



        // organizar arquvios
        public static void Organizar(string FilePath)
        {
            DirectoryInfo diretorio = new DirectoryInfo(FilePath);

            FileInfo[] arquivos = diretorio.GetFiles();

            // criar uma estrutura de repeticao para iterar em arquivos
            foreach (FileInfo item in arquivos)
            {

                var dataCriacao = item.CreationTime;
                var idadeArquivo = DateTime.Now - dataCriacao;
                if (idadeArquivo.TotalDays > 14)
                {
                    string dataFormatada = dataCriacao.ToString("yyyy-MM-dd");
                    string novoNome = $"{dataFormatada}_{item.Name}";
                    string novoCaminho = Path.Combine(FilePath, novoNome);
                    item.MoveTo(novoCaminho);

                    if (!item.Name.StartsWith(dataFormatada))
                    {
                        item.MoveTo(novoCaminho);
                        Console.WriteLine($"[RENOMEADO] {item.Name} -> {novoNome}");
                    }
                }
            }
            Console.WriteLine(" ------ > Organizacao concluida! <------------");
        }
        // listar arquivos
        public static void Listar(string FilePath)
        {
            Console.WriteLine($"Listando arquivos em {FilePath}");
            DirectoryInfo diretorio = new DirectoryInfo(FilePath);
            FileInfo[] arquivos = diretorio.GetFiles();

            // criar uma estrutura de repeticao para iterar em arquivos
            foreach (FileInfo item in arquivos)
            {
                Console.WriteLine($"[ARQUIVO] {item.Name} - Criado em: {item.CreationTime}");
            }
            Console.WriteLine(" ------ > Listagem concluida! <------------");
        }

        // enviar aquivos para lixeira
        public static void Excluir(string FilePath)
        {
            Console.WriteLine($"\n Movendo arquivos com mais de 14 dias para lixeira");
            DirectoryInfo diretorio = new DirectoryInfo(FilePath);
            FileInfo[] arquivos = diretorio.GetFiles();

            // criar uma estrutura de repeticao para iterar em arquivos
            foreach (FileInfo item in arquivos)
            {
                var dataCriacao = item.CreationTime;
                var idadeArquivo = DateTime.Now - dataCriacao;
                if (idadeArquivo.TotalDays > 14)
                {
                    try
                    {
                        FileSystem.DeleteFile(item.FullName,
                            UIOption.OnlyErrorDialogs,
                            RecycleOption.SendToRecycleBin
                        );

                        Console.WriteLine($"[LIXEIRA] {item.Name}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Não foi possivel mover o arquivo {item.Name} para lixeira: {ex.Message}");
                    }
                    
                }
            }
            Console.WriteLine(" ------ > O envio para lixeira foi concluido! <------------");
        }
    }
}
