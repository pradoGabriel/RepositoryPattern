#Repository Pattern

O repository permite o encapsulamento da camada de acesso a dados, com ele conseguimos isolar a camada de dados da camada de negócios. 

Com o uso desse pattern, aplicamos em nossa camada de domínio o princípio da persistência ignorante (PI), ou seja, nossas entidades da camada de negócio, não devem sofrer impactos pela forma em que são persistidas no banco de dados.

Além disso, nesse projeto também está sendo implementado um modelo de UnitOfWork, onde tiramos a responsabilidade de efetivar as transações do repository. Dessa forma, em caso de maiores problemas e contextos em que uma tabela tenha dependencia de outra, podemos gerenciar as transações com mais eficiência com um Rollback() ou Commit(). 