## Project Structure

The solution is structured as follows:

##

    │KOTHub
    ├── API/ // Web API (Startup Project)
    ├── Infrastructure/ // DbContext and EF Migrations
    ├── Application/ // Services and Use Cases
    ├── Domain/ // Entities and Interfaces

## Creating Migrations and Updating the Database

#### 1. Restore and Build the Solution

Open a terminal at the root of the KOTHub solution and run:

```powershell
dotnet restore
dotnet build
```

#### 2. Create a New Migration

Run the following command to generate a migration:

```
dotnet ef migrations add InitialCreate --project Infrastructure --startup-project API --output-dir Data/Migrations

```

- Replace InitialCreate with a descriptive name for the migration.

#### 3. Update the Database

Apply the migration to the database with:

```
dotnet ef database update --project Infrastructure --startup-project API
```
