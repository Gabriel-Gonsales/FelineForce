# Sistema de Gerenciamento de Gatos - Projeto com .NET 8 e MySQL

Este projeto é um sistema completo de gerenciamento de gatos, oferecendo funcionalidades para agendamento, controle de estoque, vendas, pagamento, e muito mais. Foi desenvolvido utilizando **.NET Core 8**, **Windows Forms**, e **MySQL** como banco de dados.

---

## ⚙️ Funcionalidades Principais

### Área Comum:
- **Agendamento**: Controle de consultas e visitas.
- **Cadastro de Agendamento**: Registre novos horários e clientes.
- **Gestão de Gatos**: Cadastre e visualize informações dos gatos.
- **Vendas e Pagamentos**: Processamento de compras e pagamentos.
- **Controle de Estoque**: Gerencie produtos em estoque.

### Área Administrativa:
- **Cadastro de Usuários**: Gerencie usuários do sistema.
- **Compras**: Controle de pedidos e compras de produtos.
- **Relatórios**: Geração de relatórios detalhados, como lucratividade e vendas.

---

## 📂 Estrutura do Projeto

### Principais Tecnologias e Ferramentas:
- **.NET 8**: Plataforma para desenvolvimento do backend e interface Windows Forms.
- **Windows Forms**: Interface gráfica do sistema.
- **MySQL**: Banco de dados utilizado para armazenar informações de produtos, vendas e gatos.
- **Arquitetura com IServices e IRepositories**: Organização modular para maior facilidade de manutenção e escalabilidade.

---

## 🛠️ Instruções para Executar o Projeto

1. **Pré-requisitos:**
   - Instale o [SDK do .NET 8](https://dotnet.microsoft.com/download/dotnet/8.0).
   - Instale o [MySQL](https://dev.mysql.com/downloads/mysql/) e configure o servidor.

2. **Configuração do Banco de Dados:**
   - Crie um banco de dados no MySQL com o nome desejado.
   - Configure a string de conexão no arquivo `appsettings.json` (ou equivalente):
     ```json
     {
       "ConnectionStrings": {
         "DefaultConnection": "Server=localhost;Database=nome_do_banco;User Id=seu_usuario;Password=sua_senha;"
       }
     }
     ```

3. **Preparação do Ambiente:**
   - Clone este repositório:
     ```bash
     git clone https://github.com/seu-usuario/seu-repositorio.git
     cd seu-repositorio
     ```
   - Restaure as dependências do projeto:
     ```bash
     dotnet restore
     ```

4. **Aplicação de Migrations:**
   - Execute o comando abaixo para aplicar as tabelas ao banco de dados:
     ```bash
     dotnet ef database update
     ```

5. **Executando o Projeto:**
   - Inicie a aplicação:
     ```bash
     dotnet run
     ```

6. **Utilização:**
   - Acesse as funcionalidades do sistema através da interface gráfica (Windows Forms).

---

## 🚀 Observações Finais

- **Dificuldades Enfrentadas**: Apesar de .NET ser uma plataforma amigável, a lógica de Windows Forms era desconhecida inicialmente. Também houve desafios na criação do banco de dados e na implementação das migrations.
- **Lições Aprendidas**: Este projeto foi uma oportunidade para adquirir conhecimentos práticos em .NET, MySQL, e arquitetura de software bem estruturada.

---

### Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.

---

**Desenvolvido com 💻 e ☕ pela equipe.**
