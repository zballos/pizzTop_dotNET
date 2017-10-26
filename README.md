# PizzTop [ASP.NET](https://www.asp.net/)
Nova versão do *projetinho* de exemplo PizzTop usado para estudos, este com CSharp, aplicando padrão DDD, injeção de dependência, testes unitários, entre outros.

### Dependências/Referências
0. Presentation
	1. MVC
		- Ninject (v3.2.2)
		- EntityFramework (v6)
		- EntityFramework.SqlServer
		- {Projeto}.Application
		- Ninject.Mvc5 (v3.2.0) 
1. Services
2. Application
3. Domain
4. Infra
	1. Data
		- DomainValidation (v1.0.0.0)
		- EntityFramework (v6)
		- EntityFramework.SqlServer
		- Dapper (v1.50.2.0)
		- Microsoft.Practices.ServiceLocation (v1.3.0.0)
		- {Projeto}.Domain
	2. CrossCutting.IoC
		- Ninject (v3.2.2)
		- {Projeto}.Domain
		- {Projeto}.Infra.Data
		- {Projeto}.Application
