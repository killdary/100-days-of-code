# 100 Days Of Code - Log

### Day 0: August 09, 2020

**Today's Progress**: Initialization of the project organization. 

**Thoughts:** An organization of 10 days of study content will be created. If any content exceeds the day, the content schedule will be adjusted on the 8th day to organize the study timeline for the next 10 days, until the 100th day is reached.

**Link to work:** [Schedule](https://www.evernote.com/shard/s669/sh/fb343d9e-310e-b60a-58fe-be633b146910/c05e4a4f0abfa0c846caaf097b2bd673)


### Day 1: August 10, 2020

**Today's Progress**: Study the bases of LINQ and combination of your meyhods. 

**Thoughts:** An organization of 10 days of study content will be created. If any content exceeds the day, the content schedule will be adjusted on the 8th day to organize the study timeline for the next 10 days, until the 100th day is reached.


### Day 2: August 11, 2020

**Today's Progress**: Study the bases of Entity Framework Core and your migrations and seed database. 

**Thoughts:** The basics of the entity studied to create a console application with a database for managing a school's courses. It was easy to create the internal structure. The database used was Sqlite. This is important for day 3 to study complex queries.

The basis for this study of efcore is being the book Entity Framework Core in Action by JON P SMITH


### Day 3: August 12, 2020

**Today's Progress**: Create Complex Querys in ef Core. 

**Thoughts:** I Always created querys in EF using methos and inner joins wih the include, but in the book I learned That I can apply the select and select only the fiellds I want in any table relatec with the main entity oth my context.

### Day 4: August 13, 2020

**Today's Progress**: CLI in ef core and the migrations. 

**Thoughts:** I used only the basic for create a migration, only the commands add, remove and update database, but I never applied the other parametrs these commands. So today I separed the project in two, a API and a DataAccess. In the API I put the settings of the connection the database and apply changes in migrations using th parametrs like:
-p|--project <PROJECT>                 The project to use.
-s|--startup-project <PROJECT>         The startup project to use.
-v|--verbose                           Show verbose output.

These parameters this is a greateful help in architectures with separeted projects, like CQRS.





