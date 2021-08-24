<h1>Introdução</h1>

Projeto de teste para a empresa **Funcional Health Tech**.

Conforme solicitado foi desenvolvido utilizando linguagem C#.
A arquitetura utilizada para a API foi a GraphQL.
Para base de dados foi utilizado Postgres, usando Docker para o mesmo.

A seguir as instruções para poder executar o projeto.

1 - Abrir a pasta do projeto e na pasta principal, onde se encontra o arquivo da solução do projeto, abrir o terminal para executar o seguinte comando: docker-compose up -d

Isso vai fazer com que ele crie a base de dados no Docker.

Conforme imagem:

<img src="Images\passo-1.jpg" />

2 - Para executar o projeto, abrir a pasta AppFuncional, dentro vai ter um arquivo chamado Funcional.Tech.Api.exe, executando ele irá abrir a seguinte janela:

<img src="Images\passo-2.jpg" />

3 - No navegador acessar o seguinte endereço: http://localhost:5000/ui/playground

4 - Agora basta executar as seguintes Mutation ou Query:

**Para adicionar uma conta utilizar a seguinte mutation:**

```
mutation addConta {
  addConta(conta: **numero da conta**, saldo: **saldo da conta**){
    conta
    saldo
  }
}
```

No lugar de **numero da conta** e **saldo da conta** digitar um valor qualquer.

**Para deletar uma conta :**

```
mutation deletar{
  deletar(conta: numero da conta)
}
```

**Para sacar um valor da conta:**

```
mutation sacar {
  sacar(conta: numero da conta, valor: valor a retirar)
  {
    conta
    saldo
  }
}
```

Caso o numero da conta não exista ele ira retornar um erro informando que não existe esta conta.
Caso o valor a retirar for maior que o disponível no saldo ele vai informar que o valor e maior que o saldo.

**Para depositar um valor na conta:**

```
mutation depositar{
  depositar(conta: **numero da conta**, valor: **valor depositar**)
  {
    conta
    saldo
  }
}
```

**Para verificar o saldo de todas as contas :**

```
query saldo{
  saldo
  {
    conta
    saldo
  }
}
```

**Para verificar saldo de uma conta especifica:**

```
query saldo{
  saldo(conta: **numero da conta**)
  {
    conta
    saldo
  }
```

Fonte: https://github.com/killjoy2013/graphql-net-core-api-starter
