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

