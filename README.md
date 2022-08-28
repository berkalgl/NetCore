# NetCore
Turkcell Net Core Training Git Repository

# Why and When NetCore ?
-Net core intruduced in 2015, because of cloud computing and growth in open source.
-Net Framework apps could not be run on Linux environment.

# MVC Archtiture
-Invented at Xerox Parc in the 70's
-MVC is the seminal insight of the whole field of graphical user interfaces

# Service Lifetimes
-Singleton
-Scoped --> Can be used in db processes etc
-Transient --> Credit cart and payment process etc

# Agnostic Design 
-If a machine continues to work when a broken part is replaced, that machine was designed to be agnostic.
-DB can be agnostic, applications should not depend on any specific Db

# Options and builder pattern
-Builder pattern means the addition of configuration of building application in program.cs
-And combining them afterwards in builder.Build()

# Adding migration
-Add-Migration init
-Update-Database

# Why HttpContext.Session has only string, int and byte data types ?
-OWasp 10 insecure deserialization
-https://www.cloudflare.com/learning/security/threats/owasp-top-10/

# Extension classes and method have to be static.

# Authentication 
-Is the auth of a employee go to the workplace.

# Authorization
-are the places where a employee can enter in workplace

# What is Claim ?
-It is used to hold personal information about user.
-Auth with role based.
-https://www.gencayyildiz.com/blog/asp-net-core-identity-claim-bazli-kimlik-dogrulama-xvii/

# Reverse Engineering
-Db to model first is an example of reverse engineering.
-Scaffold-DbContext 'ConnectionString' Microsoft.EntityFrameworkCore.Sqlserver
-https://docs.microsoft.com/en-us/ef/core/managing-schemas/scaffolding?tabs=dotnet-core-cli

# Multi-layered Architeture
-Clean, onion arch.
-Onion --> business -- access layers

# What does business layer do ?

# API Authentication
-JWT is the most popular access token.
-The package is JwtBearer in NetCore
-Jwt.io for serialization and deserialization.

# builder.Services.AddCors() has to be add in program.cs for clients to reach the apis. Cross Origin Resource Sharing
-https://www.gencayyildiz.com/blog/asp-net-core-uygulamalarinda-corscross-origin-resource-sharing-politikasi-ayarlama/

-https://docs.simpleinjector.org/en/latest/aspnetintegration.html

# What is a partial class in C# ?
-A partial class is a special feature of C#. It provides a special ability to implement the functionality of a single class into multiple files and all these files are combined into a single class file when the application is compiled