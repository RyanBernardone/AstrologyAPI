# Astrology Project - Instalação e Execução

Este projeto consiste em um sistema distribuído com um servidor em C# (.NET) e um cliente em Python que consome os serviços fornecidos pelo servidor. Siga as instruções abaixo para instalar e executar o projeto em qualquer computador.

---

## Requisitos
Antes de começar, certifique-se de que as seguintes ferramentas estão instaladas no computador:

### Para o Servidor (C#):
1. **.NET SDK** (versão 9 ou superior)  
   - Download: https://dotnet.microsoft.com/pt-br/download

2. **Ferramenta de Linha de Comando do Entity Framework Core** (opcional, para gerenciar o banco de dados SQLite).  
   Instale com o comando:
   ``bash
   dotnet tool install --global dotnet-ef

   Utilize os comandos para realizar as migrações:
   ``bash
   dotnet-ef migrations add InitialCreate
   dotnet-ef database update

### Para o Cliente (Pyhton):
1. **Python** (versão 3.13.0)
   - Download: https://www.python.org/downloads/

2. **Certifique-se que o pip está instalado corretamente em sua maquina**.
   Utilize os seguintes comando para isso:
   ``bash
   python -m ensurepip --upgrade

   Após instalar o pip, instale o requests:
   ``bash
   pip install requests

## Executando o projeto:

1. **Para executar o projeto siga os seguintes passos**.
   Execute primeiramente o servidor pelo terminal integrado:
   ``bash
   dotnet run

   Após executar o servidor, execute o cliente pelo terminal:
   ``bash
   python client.py
