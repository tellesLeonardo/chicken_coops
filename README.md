# Projeto Galinheiro

Este é um projeto em C# que simula o gerenciamento de um galinheiro. O sistema permite registrar e visualizar informações sobre as galinhas, como seus nomes e idades. A aplicação segue os princípios SOLID e usa as melhores práticas de desenvolvimento com C# e ASP.NET Core.

## Funcionalidades

- **Cadastrar Galinhas**: Permite adicionar novas galinhas ao galinheiro, fornecendo informações como nome e idade.
- **Visualizar Galinhas**: Exibe uma lista de todas as galinhas cadastradas no sistema.
- **Gerenciamento Simples**: A aplicação oferece uma API RESTful para realizar as operações de CRUD (Create, Read).

## Tecnologias Utilizadas

- **C#**: Linguagem de programação usada para desenvolver a aplicação.
- **ASP.NET Core**: Framework utilizado para construir a API RESTful.
- **Entity Framework Core**: Usado para gerenciar o banco de dados (se aplicável).
- **Injeção de Dependência**: Para desacoplar componentes e facilitar a manutenção.
- **SOLID**: Princípios de design de software aplicados para garantir código limpo e de fácil manutenção.

## Como Rodar o Projeto com Dev Containers

### Pré-requisitos

- **Visual Studio Code** com a extensão **Remote - Containers** instalada.
- **Docker** para rodar os containers.

### Passos

***fazer isso depois***

## Testando a API

### Endpoints disponíveis:

A aplicação expõe os seguintes endpoints para interagir com os dados do galinheiro:

### **POST** `/api/galinhas`

- **Método HTTP**: `POST`
- **URL**: `/api/galinhas`

---

### **GET** `/api/galinhas`

- **Método HTTP**: `GET`
- **URL**: `/api/galinhas`

---

### **GET** `/api/galinhas/{id}`

- **Método HTTP**: `GET`
- **URL**: `/api/galinhas/{id}`

---

### **PUT** `/api/galinhas/{id}`

- **Método HTTP**: `PUT`
- **URL**: `/api/galinhas/{id}`

---

### **DELETE** `/api/galinhas/{id}`

- **Método HTTP**: `DELETE`
- **URL**: `/api/galinhas/{id}`


