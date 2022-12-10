# Roteiro para criação do projeto

## Sistema de Barbearia
### Gestão dos Serviços e Produtos
### Controle de acesso por login e senha

## 1. Criar o Projeto
Dentro do Visual Studio ou VS Code
Abrir o Terminal do VS

Instalar o Entity Framework tools no VS
```
dotnet tool install --global dotnet-ef
```

Criar o projeto
```
dotnet new mvc --auth Individual -o CodeBarberShop -f net6.0
```
![image](https://user-images.githubusercontent.com/20090580/206591453-ea5d7cdc-af58-4c40-bfc2-32a5b4cb30c4.png)

Testar o sistema.
No Terminal digitar
```
dotnet run watch
```
Aparecerá uma url para acessarmos o sistema
Basta clicar nela segurando o Control
![image](https://user-images.githubusercontent.com/20090580/206604239-6613a967-1c6e-479c-919d-a5ad31fb3dae.png)

Aparecerá a página Home

![image](https://user-images.githubusercontent.com/20090580/206604389-8096e641-89d1-4a7d-876a-55fe6cee2bc9.png)

Clique no link [Register] e se cadastre. Irá aparecer um link para confirmar o registro. Clique no link para confirmar.

![image](https://user-images.githubusercontent.com/20090580/206605603-eb553f20-0ed1-45b4-91c6-433c0af83db1.png)

![image](https://user-images.githubusercontent.com/20090580/206605729-a7c55c8c-7484-4f26-ac6d-e40b175a99f9.png)

Cique no link [Login] e faça o login com seu usuário e senha

![image](https://user-images.githubusercontent.com/20090580/206605796-cbff1916-b215-4948-b392-33508e876bbb.png)

Para encerrar, volte no VSCode, clique no terminal e pressione Ctrl+C


## 2. Preparar o ambiente
2.1 Adicionar o recurso CodeGeneration para auxiliar na montagem das páginas
```
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design -v 6.0
```
2.2 Adicionar as ferramentas 
```
dotnet tool install -g dotnet-aspnet-codegenerator --version="6.0"
```

## 3. Criando o Cadastro de Categoria
3.1 Criar a classe Categoria em Models

![image](https://user-images.githubusercontent.com/20090580/206594044-75e5029b-adb6-43b9-bfd8-d53040e88819.png)

3.2 Configurar a classe com as anotações

![image](https://user-images.githubusercontent.com/20090580/206594386-e44365cc-8c90-402c-84df-e7dd9f6d4047.png)

3.3 Adicionar a classe Categoria ao /Data/ApplicationDbContext (responsável pela comunicação com o BD)

![image](https://user-images.githubusercontent.com/20090580/206594632-85e82e87-59c7-48fc-9bc8-81b5b1088d9b.png)

3.4. Usar o Migration para atualizar o Banco de Dados
No terminal executar os comandos
```
dotnet ef migrations add AddCategorias;
```
```
dotnet ef database update
```
3.5 Criar o Contoller de Categoria
```
dotnet-aspnet-codegenerator controller -name CategoriasController -outDir Controllers -dc ApplicationDbContext -m Categoria --useDefaultLayout --useSqlite --referenceScriptLibraries
```

3.6 Ajustar o link da página
Abrir o arquivo Views/Shared/_Layout.cshtml e adicionar um link para o Index do Controller Categorias

![image](https://user-images.githubusercontent.com/20090580/206606896-76f82249-edfa-413d-958d-a9f6856f07d2.png)

3.7 Fazer com que o Controller Categorias só possa ser acessível por um usuário logado
Abrir /Controller/CategoriasController
Modificar o arquivo adicionado o [Authorize]

![image](https://user-images.githubusercontent.com/20090580/206599774-d0ae5615-3938-4305-af5c-4f58ce4703a6.png)

3.8 Execute o sistema digitando no Terminal
```
dotnet run watch
```

## 4. Criando os demais Cadastros
Repetir a etapa 3 para cada Classe do projeto

