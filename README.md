# projeto-sistema-web
Uniftec - Disciplina de Projeto de Sistemas para Web

# ASP.NET Core Docker

```console
cd aspnetapp
docker build -t aspnetapp .
docker run -p 8000:80 -e "ASPNETCORE_URLS=http://+:80" -it --rm --name projeto1 aspnetapp
```

Depois da aplicação iniciar, visite `http://localhost:8000` no seu navegador.