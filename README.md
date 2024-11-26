---

# FelineForce - Sistema de Gestão para Clínica Veterinária

Este é um sistema de gestão desenvolvido em **.NET 8** com **Windows Forms** e **MySQL**. O sistema é dividido em duas áreas principais: **Área Comum** e **Área Administrativa**, cada uma com funcionalidades específicas para o gerenciamento de agendamentos, cadastro de animais, vendas, pagamentos, estoque, usuários, compras e relatórios.

---

## Tecnologias Utilizadas

- **.NET 8**: Plataforma de desenvolvimento para aplicações Windows Forms.
- **MySQL**: Banco de dados relacional utilizado para armazenar as informações do sistema.
- **Windows Forms**: Tecnologia para a construção da interface gráfica do sistema.
- **Entity Framework Core**: Biblioteca ORM para interagir com o banco de dados MySQL de forma eficiente.
- **IServices e IRepository**: Estrutura para organização do código, separando as lógicas de negócio (Services) e o acesso aos dados (Repositories).

---

## Funcionalidades Principais

### **Área Comum**
- **Agendamento**: Permite o agendamento de consultas para os gatos.
- **Cadastrar Agendamento**: Cadastro de novos agendamentos de consultas para os gatos.
- **Cadastro de Gatos**: Cadastro de novos gatos na clínica.
- **Venda**: Registro de vendas realizadas.
- **Pagamento**: Registro de pagamentos feitos pelos clientes.
- **Estoque**: Controle do estoque de produtos veterinários.
- **Cadastrar Estoque**: Cadastro de novos itens no estoque.

### **Área Administrativa**
- **Cadastro de Usuários**: Cadastro e gerenciamento de usuários do sistema.
- **Compra**: Registro de compras realizadas para reposição de estoque.
- **Relatórios**: Geração de relatórios de lucratividade, vendas, estoque, entre outros.

---

## Como Rodar o Projeto

### Pré-requisitos
1. **Instalar o .NET 8 SDK**: 
   - Faça o download e instalação do SDK do .NET 8 em [https://dotnet.microsoft.com/download/dotnet/8.0](https://dotnet.microsoft.com/download/dotnet/8.0).
   
2. **Instalar o MySQL**:
   - Faça o download e instale o MySQL em [https://dev.mysql.com/downloads/](https://dev.mysql.com/downloads/).
   
3. **Ferramenta para execução do banco de dados**:
   - Você pode usar o **MySQL Workbench** ou outro cliente de banco de dados para gerenciar o banco.

### Passos para Executar o Projeto

1. **Clone o Repositório**:
   Clone este repositório em sua máquina local:
   ```bash
   git clone https://github.com/seu-usuario/feline-force.git
   ```

2. **Configuração do Banco de Dados**:
   - Abra o MySQL Workbench ou outro cliente de banco de dados e crie um banco de dados chamado `feline_force`.
   - No diretório do projeto, abra o arquivo de configuração `appsettings.json` e edite a string de conexão para refletir os dados do seu banco MySQL local:
     ```json
     "ConnectionStrings": {
         "DefaultConnection": "Server=localhost;Database=feline_force;User=root;Password=suasenha;"
     }
     ```
   
3. **Rodar Migrations (Primeira execução)**:
   Caso o banco de dados ainda não tenha as tabelas criadas, abra o terminal e execute os seguintes comandos para rodar as migrações:
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

4. **Executar o Projeto**:
   No terminal, dentro do diretório do projeto, execute o seguinte comando para rodar a aplicação:
   ```bash
   dotnet run
   ```

   O aplicativo será iniciado como um aplicativo **Windows Forms**. Se for a primeira vez que está rodando, ele pode pedir para compilar o código antes de abrir a interface.

---

## Estrutura de Diretórios

- **FelineForce**: Projeto principal que contém toda a lógica do sistema.
  - **Areas/Comum**: Funcionalidades da área comum do sistema.
  - **Areas/Admin**: Funcionalidades da área administrativa do sistema.
  - **Models**: Definição das entidades do banco de dados.
  - **Services**: Contém a lógica de negócio do sistema.
  - **Repositories**: Camada responsável pela interação com o banco de dados.

---

## Como Contribuir

1. **Fork este repositório**.
2. **Crie uma nova branch** para adicionar suas alterações:
   ```bash
   git checkout -b nome-da-sua-branch
   ```
3. **Faça suas alterações**.
4. **Commit e push** suas alterações:
   ```bash
   git commit -m "Descrição das alterações"
   git push origin nome-da-sua-branch
   ```
5. **Abra um pull request** no GitHub.

---

Este é um guia básico para rodar e contribuir com o projeto **FelineForce**. Com ele, a equipe pode gerenciar de forma eficiente os agendamentos, vendas, pagamentos, estoque, e relatórios da clínica veterinária.
