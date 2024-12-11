# Solution-Template ASP.NET Core Web API
Solution Template adalah N-Tier Architecture yang dikembangkan menggunakan ASP.NET Core 3.1 dan Database SQL Server

# Cara Konfigurasi menggunakan SQL Server
  1. Migration IdentityDbContext
  ```
add-migration InitialCreateIdentity -Context AppIdentityDbContext -OutputDir Identity\Migrations
update-database -Context AppIdentityDbContext 
  ```

2. Migration DbContext
```
add-migration InitialCreate -Context ApplicationDbContext -OutputDir Data\Migrations
update-database -Context ApplicationDbContext 
```
# Referensi
https://github.com/dotnet-architecture/eShopOnWeb
