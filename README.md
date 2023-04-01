# LINQ-Tutorials

The basic and advanced concepts of LINQ using C# Language

# What is LINQ?

/// The term LINQ stands for Language Integrated Query and it is pronounced as LINK. The LINQ (Language Integrated Query) is a part of a language but not a complete language. It was introduced by Microsoft with .NET Framework 3.5 and C# 3.0 and is available in System.Linq namespace.

# Why we learn LINQ

// LINQ provides a Uniform Programming Model (i.e. Common Query Syntax) which allows us to work with different data sources such as databases, XML Documents, in-memory objects, etc. As a result, we don’t require to learn different syntaxes to query different data sources.

# LINQ Providers

A LINQ provider is software that implements the IQueryProvider and IQueryable interface for a particular data source. In other words, it allows us to write LINQ queries against that data source. If you want to create your custom LINQ provider then it must implement IQueryProvider and IQueryable interface. Without LINQ Provider we cannot execute our LINQ Queries.
Let us discuss some of the LINQ Providers and how they work internally.

/// LINQ to SQL (DLINQ):
The LINQ to SQL Provider is designed to work with only the SQL Server database. You can consider this as an object-relational mapping (ORM) framework which allows one-to-one mapping between the SQL Server database and related .NET Classes. These .NET classes are going to be created automatically by the wizard based on the database table.

/// LINQ to Entities:
The LINQ to Entities provider looks like LINQ to SQL. It means it is also an object-relational mapping (ORM) framework that allows one-to-one, one-to-many, and many-to-many mapping between the database tables and .NET Classes. The point that you need to remember is that it is used to query any database such as SQL Server, Oracle, MySQL, DB2, etc. Now, it is called ADO.NET Entity Framework.

/// Parallel LINQ (PLINQ):
The Parallel LINQ or PLINQ was introduced with .NET Framework 4.0. This provider provides the flexibility of parallel implementation of LINQ to Objects. The PLINQ was designed in such a way that it uses the power of parallel programming which targets the Task Parallel Library. So if you want to execute your LINQ query simultaneously or parallel on different processors then you need to write the query using PLINQ.

# What is a Query?

A query is nothing but a set of instructions that are applied to a data source to perform certain operations and then tells the shape of the output from that query. Each query is a combination of three things.

They are as follows:

            > Initialization (to work with a particular data source)
            > Condition (where, filter, sorting condition)
            > Selection (single selection, group selection, or joining)

We can write the LINQ query in three different ways

            > Query Syntax
            > Method Syntax
            > Mixed Syntax (Query + Method)

Note: From the performance point of view there is no difference between the above three approaches. So, which you need to use, totally depends on your personal preference.
