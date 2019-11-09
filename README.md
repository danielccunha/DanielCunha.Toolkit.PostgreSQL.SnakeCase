# PostgreSQL with Snake Case

This package basically contains a **pre-configured** DbContext which automatically converts all your properties and tables to **snake case** (lorem_ipsum_dolor), PostgreSQL default syntax.

## Motivation

Have you ever created a table in PostgreSQL using **Pascal Case**? This is the default syntax used by Entity Framework Core, specially when you are generating your database using migrations.

It's horrible to work with, at least using pgAdmin 4, because it breaks the default syntax. Therefore, you have to reference every column and table using double quotes, otherwise PostgreSQL will not find the table/column.

The goal of this package is to automatically convert your classes (tables) and properties (columns) into snake case when talking to the database, without having to change the default syntax of .NET projects.

## Installation

Install NuGet package **DanielCunha.Toolkit.PostgreSQL** or download repo and compile it manually so you can reference it from your target project.

## Usage

Just inherit your implementation of the DbContext from **SnakeCaseDbContext** and it's done. Now, try to generate a migration and you'll see your properties being generated in **snake_case_syntax**.

## Contribute

Fell free to clone this repository and modify the projects as you wish. I'll glad to add your changes to the next version of the package!

## License

MIT License.
