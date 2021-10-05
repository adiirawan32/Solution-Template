# Solution-Template
Solution Template Net Core 3.1

 # Migration IdentityDbContext
add-migration InitialCreateIdentity -Context AppIdentityDbContext -OutputDir Identity\Migrations
update-database -Context AppIdentityDbContext 

# Migration DbContext
add-migration InitialCreate -Context ApplicationDbContext -OutputDir Data\Migrations
update-database -Context ApplicationDbContext 

# Reference
https://github.com/dotnet-architecture/eShopOnWeb