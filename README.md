
# 📂 File Organizer CLI

Uma ferramenta de linha de comando (CLI) em C# (.NET 10) para organizar e limpar diretórios (ex.: pasta `Downloads`). Automatiza renomeação de arquivos antigos e envio seguro para a Lixeira do Windows, com foco em produtividade e manutenção baseada em datas.

---

## 🚀 Funcionalidades

- Listar arquivos do diretório com data de criação e nome.
- Renomear arquivos com mais de 14 dias, prefixando a data (ex.: `2023-11-25_Relatorio.pdf`).
- Limpeza inteligente: mover arquivos com mais de 14 dias para a Lixeira do Windows (via `Microsoft.VisualBasic`) para evitar exclusões permanentes imediatas.

---

## 🛠 Tecnologias

- C# / .NET (Console Application)
- `System.IO` (`FileInfo`, `DirectoryInfo`)
- `Microsoft.VisualBasic` (integração com a Lixeira do Windows)

---

## ⚙️ Requisitos

- SDK do .NET 10 instalado.

---

## 🚀 Instalação e execução

**1. Clone o repositório:**
   ```bash
   git clone [https://github.com/SEU-USUARIO/FileOrganizerCLI.git](https://github.com/SEU-USUARIO/FileOrganizerCLI.git)
   ```

**2. Defina o diretório alvo:** 
Abra `Program.cs` e ajuste a variável `filePath` para a pasta que deseja organizar.

C# — Exemplo (copiar para `Program.cs`):
// Copiar este bloco e colar em Program.cs string 

```bash
filePath = @"C:\Users\SEU_USUARIO\Downloads";
```

**3. (Opcional) Adicionar o pacote `Microsoft.VisualBasic` caso o build reclame da referência:**
   ```bash
   dotnet add package Microsoft.VisualBasic
   ```
**4. Compile e execute:**
   ```bash
   dotnet run
   ```
### ⚠️ Aviso de Segurança
Embora a função de exclusão envie os arquivos para a Lixeira (permitindo recuperação), recomenda-se sempre revisar a lista de arquivos (Opção 1) antes de executar operações em lote.

### 📝 Licença
Este projeto está sob a licença MIT. Sinta-se livre para usar e modificar.