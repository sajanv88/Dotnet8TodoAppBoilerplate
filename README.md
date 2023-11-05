# The Blazor Dotnet 8 Fullstack boilerplate

A simple fullstack todo application boilerplate code. Styles are intergrated with tailwind and flowbite plugin.

## Recommended
- Dotnet 8 & Node js for tailwind support (Optional).
- Postgres database instance running in your local or in the cloud.

## Steps
- Clone this repo
- Install all the required dependencies
- Update database connection string in the `appsettings.json` based on your preference.
- Run migrations `dotnet ef migrations Add InitialCreate`
  - Run database update `dotnet ef database update`
- Generate tailwind `npx tailwindcss -i wwwroot/entrypoint.css -o wwwroot/app.css`
- Finally `dotnet watch run`

## Docker
- Build the docker image `docker build -t dotnet8 .`
- Run ```docker run --name todoapp -p 80:8080 --env ConnectionStrings:DefaultConnection="Server=tyke.db.elephantsql.com;User Id=exadrrcg;Database=exadrrcg;Password=mAO7ezDVYYjfxQ1SoJfFM3Yzx-qBD8p5;" --env ASPNETCORE_ENVIRONMENT=Production  dotnet8```
- The above database connection i am pointing to [elephantsql.com](https://elephantsql.com) it is free version of postgresql cloud. Create one and update the docker env connection strings.