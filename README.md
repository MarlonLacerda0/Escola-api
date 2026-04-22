# 📚 Escola API

API desenvolvida para simular um sistema escolar, com o objetivo de estudar e aplicar conceitos de **Clean Architecture**, boas práticas de desenvolvimento e padrões de código utilizando **.NET**.

---

## 🚀 Objetivo

Este projeto foi criado com foco em aprendizado, visando:

- Aplicar os princípios da **Clean Architecture**
- Separação de responsabilidades em camadas
- Utilização de **Repository Pattern**
- Implementação de boas práticas de código
- Estruturação de uma API RESTful

---

## 🧱 Arquitetura

O projeto segue o padrão de **Clean Architecture**, dividido em camadas:

### 📌 Domain
- Entidades
- Interfaces de repositórios
- Regras de negócio mais centrais

### 📌 Application
- Services
- Interfaces de serviços
- Casos de uso da aplicação

### 📌 Infrastructure (Infra.Data)
- Implementação dos repositórios
- Contexto do banco de dados (Entity Framework)
- Migrations

### 📌 API (Presentation)
- Controllers
- Configurações da aplicação
- Endpoints HTTP

---

## 🛠️ Tecnologias utilizadas

- .NET
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Swagger 
