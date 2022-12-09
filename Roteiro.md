# Roteiro para criação do projeto

## Sistema de Barbearia
### Gestão dos Serviços e Produtos
### Controle de acesso por login e senha

## 1. Criar o Projeto
Dentro do Visual Studio ou VS Code
Abrir o Terminal do VS
Criar o projeto
```
dotnet new mvc --auth Individual -o CodeBarberShop -f net6.0
```
![image](https://user-images.githubusercontent.com/20090580/206591453-ea5d7cdc-af58-4c40-bfc2-32a5b4cb30c4.png)



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

3.3 Adicionar a classe Categoria ao ApplicationDbContext (responsável pela comunicação com o BD)
![image](https://user-images.githubusercontent.com/20090580/206594632-85e82e87-59c7-48fc-9bc8-81b5b1088d9b.png)

3.4. Usar o Migration para atualizar o Banco de Dados
```
migrations add AddCategorias;
```
```
dotnet ef database update
```
3.5 Criar o Contoller de Categoria
```
dotnet-aspnet-codegenerator controller -name Controller/CategoriasController -dc ApplicationDbContext -m Categoria --useDefaultLayout --useSqlite --referenceScriptLibraries
```

3.6 Ajustar o link da página
Abrir o arquivo Views/Shared/_Layout.cshtml e adicionar um link para o Index do Controller Categorias
```
  <li class="nav-item">
      <a class="nav-link text-dark" asp-area="" asp-controller="Categorias" asp-action="Index">Categorias</a>
  </li>
```
3.7 Fazer com que o Controller Categorias só possa ser acessível por um usuário logado
Abrir /Controller/CategoriasController
Modificar o arquivo adicionado o [Authorize]
![image](https://user-images.githubusercontent.com/20090580/206599774-d0ae5615-3938-4305-af5c-4f58ce4703a6.png)

```
```
