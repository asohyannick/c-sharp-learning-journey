

# 🚀 C# & ASP.NET Core — Backend Developer Learning Journey

> A personal learning roadmap and project repository documenting my journey from C# beginner to professional backend developer using .NET 10 and ASP.NET Core.

---

## 👨‍💻 About This Repository

This repository serves as my learning journal and project workspace as I progress through the complete C# and ASP.NET Core backend development roadmap. Each folder corresponds to a stage in my learning journey, containing code exercises, mini-projects, and notes.

**Current Status:** 🟡 Stage 1 — C# Fundamentals (In Progress)  
**Started:** April 2026  
**Target Completion:** Q1 2027  
**Runtime:** .NET 10 (`10.0.201`)  
**OS:** Windows 11  

---

## 🗺️ Roadmap Overview

The roadmap is divided into **6 progressive stages**, moving from the C# language fundamentals all the way to microservices and cloud deployment.

```
Stage 1 → Stage 2 → Stage 3 → Stage 4 → Stage 5 → Stage 6
   C#      Async &    REST      Databases  Architecture  Cloud &
Basics     Testing    APIs      & EF Core  & Patterns   DevOps
```

---

## 📁 Repository Structure

```
📦 csharp-learning-journey/
├── 📂 stage-1-fundamentals/
│   ├── 📂 01-variables-and-types/
│   ├── 📂 02-control-flow/
│   ├── 📂 03-methods/
│   ├── 📂 04-oop/
│   ├── 📂 05-collections-and-generics/
│   ├── 📂 06-exception-handling/
│   ├── 📂 07-linq/
│   ├── 📂 08-modern-csharp/
│   └── 📂 project-library-management-system/
├── 📂 stage-2-intermediate/
│   ├── 📂 01-async-await/
│   ├── 📂 02-delegates-and-events/
│   ├── 📂 03-file-io/
│   ├── 📂 04-dependency-injection/
│   ├── 📂 05-unit-testing/
│   └── 📂 project-todo-app/
├── 📂 stage-3-aspnet-core/
│   ├── 📂 01-aspnet-fundamentals/
│   ├── 📂 02-routing-and-http/
│   ├── 📂 03-request-response/
│   ├── 📂 04-swagger-openapi/
│   ├── 📂 05-middleware-and-filters/
│   ├── 📂 06-authentication-jwt/
│   └── 📂 project-blog-api/
├── 📂 stage-4-databases/
│   ├── 📂 01-sql-fundamentals/
│   ├── 📂 02-ef-core-basics/
│   ├── 📂 03-migrations/
│   ├── 📂 04-crud-operations/
│   ├── 📂 05-advanced-ef-core/
│   ├── 📂 06-caching/
│   └── 📂 project-product-catalog-api/
├── 📂 stage-5-architecture/
│   ├── 📂 01-solid-principles/
│   ├── 📂 02-clean-architecture/
│   ├── 📂 03-design-patterns/
│   ├── 📂 04-api-best-practices/
│   ├── 📂 05-integration-testing/
│   ├── 📂 06-logging-observability/
│   └── 📂 project-ecommerce-api-clean-arch/
├── 📂 stage-6-advanced/
│   ├── 📂 01-docker/
│   ├── 📂 02-microservices/
│   ├── 📂 03-message-brokers/
│   ├── 📂 04-azure-cloud/
│   ├── 📂 05-ci-cd-pipelines/
│   ├── 📂 06-kubernetes/
│   └── 📂 project-microservices-app/
├── 📂 resources/
│   └── CSharp_ASPNetCore_Backend_Developer_Roadmap.docx
└── README.md
```

---

## 📚 Stage 1 — C# Fundamentals
**Duration:** 8 Weeks | **Status:** 🟡 In Progress

The foundation of everything. This stage focuses purely on the C# language — no frameworks, no databases, just the core language features that every C# developer must know inside and out.

### Topics Covered

#### 1.1 Variables, Data Types & Operators
- Value types: `int`, `double`, `float`, `decimal`, `bool`, `char`, `long`
- Reference types: `string`, `object`, arrays
- Type inference with `var`
- Arithmetic, comparison, and logical operators
- String interpolation: `$"Hello, {name}!"`
- Nullable types: `int?`
- Type conversion and casting

#### 1.2 Control Flow
- `if` / `else if` / `else` statements
- `switch` statements and modern switch expressions (C# 8+)
- `while`, `do...while`, `for`, and `foreach` loops
- `break`, `continue`, and `return` keywords

#### 1.3 Methods & Functions
- Method definitions, return types, and parameters
- Method overloading
- Optional parameters and named arguments
- `ref` and `out` parameters
- Expression-bodied methods: `public int Add(int a, int b) => a + b;`
- Recursion

#### 1.4 Object-Oriented Programming (OOP)
- Classes, objects, fields, properties, and methods
- Constructors and constructor overloading
- Access modifiers: `public`, `private`, `protected`, `internal`
- Static vs. instance members
- **The Four Pillars:**
  - Encapsulation — private fields + public properties
  - Inheritance — `: BaseClass` syntax
  - Polymorphism — `virtual` and `override` keywords
  - Abstraction — `abstract` classes
- Interfaces and the `interface` keyword
- Implementing multiple interfaces

#### 1.5 Collections & Generics
- Arrays — fixed-size collections
- `List<T>` — dynamic lists (most commonly used)
- `Dictionary<TKey, TValue>` — key-value pairs
- `HashSet<T>`, `Queue<T>`, `Stack<T>`
- Generics and type parameters `<T>`
- `IEnumerable<T>`, `ICollection<T>`, `IList<T>`

#### 1.6 Exception Handling
- `try` / `catch` / `finally`
- Catching specific exception types
- `throw` and custom exception classes
- Preserving the stack trace: `throw;` vs `throw ex;`

#### 1.7 LINQ (Language Integrated Query)
- Method syntax: `.Where()`, `.Select()`, `.OrderBy()`, `.GroupBy()`
- Query syntax: `from x in collection where ... select x`
- Key operators: `FirstOrDefault`, `Any`, `All`, `Count`, `Sum`, `Average`
- `SelectMany`, `Join`
- Materializing queries: `ToList()`, `ToArray()`, `ToDictionary()`

#### 1.8 Modern C# Features (C# 8 – 14)
- Null safety: `??`, `?.`, nullable reference types
- Pattern matching: switch expressions, `is` patterns
- Records — immutable data classes
- Init-only properties
- Tuples and deconstruction
- Top-level statements (as in .NET 10)

### 🏆 Stage 1 Milestone Project
**Console-based Library Management System**
> A full console application managing books, members, and borrowing records using classes, collections, LINQ, file I/O, and exception handling. No frameworks — pure C#.

---

## ⚡ Stage 2 — Intermediate C# & .NET
**Duration:** 6 Weeks | **Status:** ⚪ Not Started

### Topics Covered
- **Async/Await** — `Task`, `Task<T>`, `async`/`await`, `CancellationToken`, `Task.WhenAll()`
- **Delegates & Events** — `Action<T>`, `Func<T>`, lambda expressions, closures
- **File I/O & Streams** — reading/writing files, `StreamReader`/`StreamWriter`, JSON with `System.Text.Json`
- **Dependency Injection** — constructor injection, service lifetimes (Singleton, Scoped, Transient)
- **Unit Testing** — xUnit, Moq, FluentAssertions, AAA pattern, `dotnet test`
- **Git & Version Control** — branching, PRs, feature branch workflow

### 🏆 Stage 2 Milestone Project
**Async Console To-Do Application**
> A To-Do app with async file-based persistence, unit tests covering all core logic, and a clean Git history demonstrating the feature branch workflow.

---

## 🌐 Stage 3 — ASP.NET Core REST APIs
**Duration:** 8 Weeks | **Status:** ⚪ Not Started

### Topics Covered
- **ASP.NET Core Fundamentals** — `Program.cs`, middleware pipeline, `appsettings.json`
- **Routing & HTTP Methods** — attribute routing, GET/POST/PUT/PATCH/DELETE, minimal APIs
- **Request & Response** — DTOs, model binding, model validation, `IActionResult`, HTTP status codes
- **Swagger / OpenAPI** — auto-generated API documentation, testing via Swagger UI
- **Middleware & Filters** — custom middleware, action filters, global exception handling, CORS
- **Authentication & Authorization** — JWT tokens, `[Authorize]`, role-based auth, ASP.NET Core Identity

### 🏆 Stage 3 Milestone Project
**Blog REST API**
> A fully documented REST API with CRUD endpoints for posts and comments, JWT authentication, role-based access control, Swagger UI, and global error handling.

---

## 🗄️ Stage 4 — Databases & Data Access
**Duration:** 6 Weeks | **Status:** ⚪ Not Started

### Topics Covered
- **SQL Fundamentals** — SELECT, INSERT, UPDATE, DELETE, JOINs, GROUP BY, indexes
- **Entity Framework Core** — `DbContext`, `DbSet<T>`, connection strings, code-first approach
- **EF Core Migrations** — `dotnet ef migrations add`, `dotnet ef database update`
- **CRUD with EF Core** — async queries, LINQ with EF Core, `SaveChangesAsync()`
- **Advanced EF Core** — relationships, `Include()`/`ThenInclude()`, transactions, Repository Pattern
- **Caching** — `IMemoryCache`, Redis, response caching, cache invalidation

### 🏆 Stage 4 Milestone Project
**Product Catalog API**
> Extend the Blog API to connect to a real SQL Server database using Entity Framework Core, including migrations, relationships between entities, pagination, and in-memory caching.

---

## 🏛️ Stage 5 — Architecture & Best Practices
**Duration:** 8 Weeks | **Status:** ⚪ Not Started

### Topics Covered
- **SOLID Principles** — Single Responsibility, Open/Closed, Liskov Substitution, Interface Segregation, Dependency Inversion
- **Clean Architecture** — Domain, Application, Infrastructure, Presentation layers; the Dependency Rule
- **Design Patterns** — Repository, Factory, Singleton, Strategy, Observer, Decorator, Mediator (MediatR)
- **API Best Practices** — versioning, pagination, filtering, consistent error responses, rate limiting
- **Integration Testing** — `WebApplicationFactory<T>`, `HttpClient` in tests, Testcontainers
- **Logging & Observability** — `ILogger<T>`, Serilog, structured logging, health checks, OpenTelemetry

### 🏆 Stage 5 Milestone Project
**E-Commerce API (Clean Architecture)**
> Refactor a previous API project using Clean Architecture layers, apply SOLID principles throughout, add MediatR for CQRS, and achieve 80%+ test coverage with both unit and integration tests.

---

## ☁️ Stage 6 — Microservices, Cloud & DevOps
**Duration:** Ongoing | **Status:** ⚪ Not Started

### Topics Covered
- **Docker** — Dockerfile, multi-stage builds, Docker Compose, container registries
- **Microservices Architecture** — decomposition, service communication, API Gateway pattern
- **Message Brokers** — RabbitMQ, MassTransit, Azure Service Bus, Outbox Pattern
- **Azure Cloud** — App Service, Azure SQL, Blob Storage, Key Vault, Container Apps, Application Insights
- **CI/CD Pipelines** — GitHub Actions, automated build/test/deploy workflows
- **Kubernetes** — Pods, Deployments, Services, `kubectl`, Helm, AKS

### 🏆 Stage 6 Milestone Project
**Microservices Application**
> Split a monolithic API into two microservices (e.g., Orders and Inventory) that communicate via RabbitMQ, each deployed as a Docker container, with a GitHub Actions CI/CD pipeline deploying to Azure.

---

## 🛠️ Tech Stack & Tools

| Category | Technology |
|---|---|
| **Language** | C# 14 |
| **Runtime** | .NET 10 (`10.0.201`) |
| **Web Framework** | ASP.NET Core 10 |
| **ORM** | Entity Framework Core 10 |
| **Database** | SQL Server / PostgreSQL |
| **Testing** | xUnit, Moq, FluentAssertions |
| **Caching** | Redis, IMemoryCache |
| **Messaging** | RabbitMQ, MassTransit |
| **Cloud** | Microsoft Azure |
| **Containers** | Docker, Kubernetes |
| **CI/CD** | GitHub Actions |
| **IDE** | Visual Studio 2022 / VS Code |
| **API Docs** | Swagger / OpenAPI |
| **Version Control** | Git & GitHub |

---

## ⏱️ Learning Timeline

| Stage | Focus | Duration | Status |
|---|---|---|---|
| Stage 1 | C# Fundamentals | 8 weeks | 🟡 In Progress |
| Stage 2 | Intermediate C# & .NET | 6 weeks | ⚪ Upcoming |
| Stage 3 | ASP.NET Core REST APIs | 8 weeks | ⚪ Upcoming |
| Stage 4 | Databases & EF Core | 6 weeks | ⚪ Upcoming |
| Stage 5 | Architecture & Best Practices | 8 weeks | ⚪ Upcoming |
| Stage 6 | Microservices, Cloud & DevOps | Ongoing | ⚪ Upcoming |

**Legend:** 🟢 Complete | 🟡 In Progress | ⚪ Not Started

---

## 🚀 Getting Started

### Prerequisites
- [.NET 10 SDK](https://dotnet.microsoft.com/en-us/download) (already installed: `10.0.201`)
- [Visual Studio 2022 Community](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)
- [Git](https://git-scm.com/)

### Clone This Repository
```bash
git clone https://github.com/yourusername/csharp-learning-journey.git
cd csharp-learning-journey
```

### Run Any Exercise
```bash
# Navigate to any project folder
cd stage-1-fundamentals/04-oop

# Run the project
dotnet run

# Run tests (if present)
dotnet test
```

### Verify Your .NET Setup
```bash
# Check .NET SDK version
dotnet --version

# View full environment info
dotnet --info

# List installed runtimes
dotnet --list-runtimes
```

---

## 📖 Resources

### Official Documentation
- [Microsoft Learn — C# Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [ASP.NET Core Documentation](https://learn.microsoft.com/en-us/aspnet/core/)
- [Entity Framework Core Documentation](https://learn.microsoft.com/en-us/ef/core/)
- [.NET 10 Release Notes](https://dotnet.microsoft.com/en-us/download/dotnet/10.0)

### Books
- *C# Player's Guide* — RB Whitaker (Best beginner book)
- *C# in Depth* — Jon Skeet (Intermediate to Advanced)
- *Clean Architecture* — Robert C. Martin
- *ASP.NET Core in Action* — Andrew Lock

### YouTube Channels
- [Nick Chapsas](https://www.youtube.com/@nickchapsas) — Intermediate to Advanced .NET
- [Tim Corey](https://www.youtube.com/@IAmTimCorey) — Beginner-friendly .NET

### Practice Platforms
- [Exercism.io — C# Track](https://exercism.org/tracks/csharp)
- [LeetCode](https://leetcode.com/) — Algorithm practice
- [HackerRank — C#](https://www.hackerrank.com/domains/csharp)

---

## 📌 Coding Standards I Follow

```csharp
// ✅ PascalCase for classes, methods, and properties
public class ProductService
{
    public string ProductName { get; set; }
    public Product GetById(int id) { ... }
}

// ✅ camelCase for local variables and parameters
public void ProcessOrder(int orderId)
{
    var orderDetails = GetOrder(orderId);
}

// ✅ _camelCase for private fields
private readonly IProductRepository _productRepository;

// ✅ Meaningful names — no abbreviations
// ❌ Bad:  var p = GetPrd(id);
// ✅ Good: var product = GetProductById(id);

// ✅ Async methods always end with "Async"
public async Task<Product> GetProductByIdAsync(int id) { ... }

// ✅ Interfaces start with "I"
public interface IProductRepository { ... }
```

---

## 🎯 Goals

- [ ] Complete all 6 stages of the roadmap
- [ ] Build 6 milestone projects (one per stage)
- [ ] Achieve 80%+ test coverage on all projects
- [ ] Deploy at least one project to Microsoft Azure
- [ ] Earn the **Azure Developer Associate (AZ-204)** certification
- [ ] Land a junior **C# .NET Backend Developer** role

---

## 📝 Progress Log

| Date | Milestone |
|---|---|
| April 2026 | Started Stage 1 — C# Fundamentals |
| — | — |

---

## 🤝 Contributing

This is a personal learning repository, but feel free to open an issue if you spot an error in my code or notes. Feedback is always welcome!

---

## 📄 License

This project is open source and available under the [MIT License](LICENSE).

---

<div align="center">

**Built with dedication by a C# developer in training**

`.NET 10` · `C# 14` · `ASP.NET Core` · `Azure`

*"The expert in anything was once a beginner."*

</div>