# projeto-sistema-web
Uniftec - Disciplina Projeto de Sistemas para Web

# ASP.NET Core Docker

```
git clone https://github.com/rbarros/projeto-sistema-web.git
cd projeto-sistema-web
docker build -t aspnetapp .
docker run -p 8000:80 -e "ASPNETCORE_URLS=http://+:80" -it --rm --name Ftec.Cadastro.Site aspnetapp
```

Depois da aplicação iniciar, visite `http://localhost:8000` no seu navegador.

Estrutura de componentes para DDD:

Ftec.Cadastro (Projeto)
|__ Aplicacao
    |__ Ftec.Cadastro.Aplicacao - Biblioteca de Classes (.NET Framework)
|__ Apresentacao
    |__ Ftec.Cadastro.Site
|__ Croscutting
|__ Dominio - Não pode acessar ninguem - camada de nível 0
    |__ Ftec.Cadastro.Dominio - BibliotecDDDa de Classes (.NET Framework)
|__ Infraestrtura
    |__ Ftec.Cadastro.Infra.Repositorio - Biblioteca de Classes (.NET Framework)
|__ Servico
    |__ Ftec.Cadastro.Servico - Aplicativo Web ASP.NET (.NET Framework) - Vazio e Web API

Site
 .
 .
 v
Servico
|   |
|   v
|   Aplicacao
|   .    |
|   .    v
|   .    Dominio
|   .    ^
|   .    |
v   v    |
Repositorio


Na infraestrutura em Referências clicar Adicionar Referencias
Bibliotecas externas para a aplicação
Adicionar Ftec.Condastro.Dominio

Na aplicacao em Referências clicar Adicionar Referencias
Bibliotecas externas para a aplicação
Adicionar Ftec.Condastro.Dominio

Na servico em Referências clicar Adicionar Referencias
Bibliotecas externas para a aplicação
Adicionar Ftec.Condastro.Aplicacao
Adicionar Ftec.Condastro.Dominio
Adicionar Ftec.Condastro.Infra.Repositorio