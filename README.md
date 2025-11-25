# ?? File Organizer CLI

Uma ferramenta de linha de comando (CLI) desenvolvida em C# .NET para automatizar a organização e limpeza de diretórios (como a pasta Downloads), focada em produtividade e manutenção de arquivos baseada em datas.

## ?? Funcionalidades

O script analisa arquivos em um diretório alvo e oferece um menu interativo com as seguintes opções:

- **Listar Arquivos:** Exibe todos os arquivos do diretório com data de criação e nome.
- **Renomear Arquivos Antigos:** Identifica arquivos com mais de **14 dias**, adicionando a data de criação ao início do nome (ex: `2023-11-25_Relatorio.pdf`).
- **Limpeza Inteligente (Lixeira):** Move arquivos com mais de **14 dias** para a Lixeira do Windows (via `Microsoft.VisualBasic`), garantindo uma camada de segurança antes da exclusão permanente.

## ??? Tecnologias Utilizadas

- **C# / .NET** (Console Application)
- **System.IO**: Manipulação de diretórios e arquivos (`FileInfo`, `DirectoryInfo`).
- **Microsoft.VisualBasic**: Integração com o shell do Windows para envio seguro à Lixeira.

## ?? Como Configurar e Rodar

### Pré-requisitos
- SDK do .NET instalado (versão 6.0 ou superior recomendada).

### Passo a Passo

1. **Clone o repositório:**
   ```bash
   git clone [https://github.com/SEU-USUARIO/FileOrganizerCLI.git](https://github.com/SEU-USUARIO/FileOrganizerCLI.git)
   cd FileOrganizerCLI
Defina o Diretório Alvo: Abra o arquivo Program.cs e localize a variável filePath. Altere o caminho para a pasta que deseja organizar:

C#

// Exemplo:
string filePath = @"C:\Users\SEU_USUARIO\Downloads";
Adicione a Referência (se necessário): Como o projeto usa recursos do Visual Basic para a Lixeira, certifique-se de que o .csproj contém a referência ou execute:

Bash

dotnet add reference Microsoft.VisualBasic
(Nota: Em projetos .NET Core/5+, isso geralmente é nativo ou requer ajuste no csproj para UseWindowsForms ou referência direta, dependendo do SDK).

Execute o projeto:

Bash

dotnet run
?? Aviso de Segurança
Embora a função de exclusão envie os arquivos para a Lixeira (permitindo recuperação), recomenda-se sempre revisar a lista de arquivos (Opção 1) antes de executar operações em lote.

?? Licença
Este projeto está sob a licença MIT. Sinta-se livre para usar e modificar.