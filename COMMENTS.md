
## Decisão da arquitetura utilizada
A aplicação desenvolvida analisa segue um modelo baseado em Domain-Driven Design (DDD), para fornecer uma estrutura base robusta, escalável e que possibilite a fácil implementação dos principios SOLID.
## Lista de bibliotecas de terceiros utilizadas

Para a execução da aplicação é preciso que o ambiente .Net de execução contenha  os seguintes pacotes

```sh
Autofac: ^5.1.4
Autofac.Extensions.DependencyInjection: ^6.0.0
Swashbuckle.AspNetCore: ^5.4.1
Microsoft.EntityFrameworkCore.Design: ^6.0.9">
Pomelo.EntityFrameworkCore.MySql: ^6.0.2
Microsoft.Extensions.ApiDescription.Server: ^3.0.0
Microsoft.EntityFrameworkCore.Tools: ^3.1.10
```

Para a aplicação front-end é preciso que o ambiente contenha o gerenciador de pacotes npm, e os seguintes pacotes

```sh
axios: ^1.1.3
core-js: ^3.8.3
vue: ^2.6.14
vue-router: ^3.4.3
vuetify: ^2.6.0
```
## O que você melhoraria se tivesse mais tempo
Dada disponibilidade de um prazo maior, os seguintes pontos seriam melhorados e ou adicionados:
- Retorno e tratamento dos erros e exceções da API Back-End
- Trativa melhorias na estrutura do front-end, ajustes para utilização de modals e snackbars para apresentração dos erros e exceções vindas da API
- Documentação da arquitetura
- Testes unitários 
- Tratativa para o sistema de pesquisa de  alunos
- Implementação de um sistema de autenticação e autorização

## Quais requisitos obrigatórios que não foram entregues
Dos requisitos obrigatórios, faltaram implementar os seguinte:
- A implementação de Modals/Janelas para manipulação dos formulários de dados
- Implementação da rotina de busca de alunos
