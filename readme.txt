Projeto Final do Curso Formação MS

Autor: Carlos Silva
Plataforma: Ubuntu 18
IDE: VSCode
Linguagem: C#

-------------------------------------------------------------------------

Instalar o Ambiente
-------------------------------------------------------------------------


- NET FRAMEWORK E RUNTIME

https://docs.microsoft.com/pt-br/dotnet/core/install/linux-ubuntu

- Diretorio do SDK 
-  /usr/share/dotnet/sdk/




- VSCode

sudo snap install –classic code


-------------------------------------------------------------------------

Criar um projeto c# console
-------------------------------------------------------------------------

#criar diretorio/pasta
~$ mkdir elevador

#acessar diretorio/pasta
~$ cd elevador

#verificar opções de projeto disponiveis
~$ dotnet new --list

# escolher modelo "Aplicativo de console"
# Então digite dentro do diretorio elevador
~$ dotnet new console

# se tiver o vscode instalado digite o comando abaixo

~$ code .

# Para executar a aplicação digite:  
~$ dotnet run

-------------------------------------------------------------------------

Criar um projeto um Aplicativo ASPNET CORE
-------------------------------------------------------------------------

# Criar pasta do projeto
~$ mkdir elevador-documentacao 

# Acessar pasta do projeto
~$ cd elevador-documentacao

# Verificar opções de projeto disponiveis
~$ dotnet new --list

# Escolher modelo "ASP.NET Core Web App (Model-View-Controller)"
~$ dotnet new mvc --framework net5.0

# se tiver o vscode instalado digite o comando abaixo

~$ code .

# Para executar a aplicação digite:  
~$ dotnet run

-------------------------------------------------------------------------
