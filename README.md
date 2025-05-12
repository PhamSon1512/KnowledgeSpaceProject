# Introduction 
KnowledgeSpace is a open source project for everyone. Every member can create new knowledge base record (KB) and share to community.
For each KB, user can vote it and comment to below KB.

# Migration
- Add-Migration Initial -OutputDir Data/Migrations

#Technology Stack
1. ASP.NET Core 8.0
2. Angular 8
3. Identity Server 4
5. SQL Server 2022

# How to run this Project
1. Clone this source code from Repository
2. Build solution to restore all Nuget Packages
2. Set startup project is KnowledgeSpace.BackendServer
3. Run Update-Database to generate database
4. Set startup project to multiple projects include: KnowledgeSpace.BackendServer and KnowledgeSpace.WebPortal

# References
- [ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-8.0)
- [Visual Studio](https://visualstudio.microsoft.com/)
- [IdentityServer4](https://identityserver.io/)

# Angular Installation
- NPM (https://nodejs.org/en/)
- https://git-scm.com/downloads
- npm install -g @angular/cli
- Visual Studio Code (https://code.visualstudio.com/)
- Run command: git clone https://github.com/start-angular/SB-Admin-BS4-Angular-8.git admin-app
# Cachce table SQL
```sql
    CREATE TABLE [dbo].[CacheTable](
        [Id] [nvarchar](449) NOT NULL,
        [Value] [varbinary](max) NOT NULL,
        [ExpiresAtTime] [datetimeoffset](7) NOT NULL,
        [SlidingExpirationInSeconds] [bigint] NULL,
        [AbsoluteExpiration] [datetimeoffset](7) NULL,
     CONSTRAINT [pk_Id] PRIMARY KEY CLUSTERED 
    (
        [Id] ASC
    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, 
           IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, 
           ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
 
    CREATE NONCLUSTERED INDEX [Index_ExpiresAtTime] ON [dbo].[CacheTable]
    (
        [ExpiresAtTime] ASC
    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, 
           SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, 
           ONLINE = OFF, ALLOW_ROW_LOCKS = ON, 
           ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
```
# Deployment
1. Publish source code to package (BackendServer, WebPortal, Admin App)
2. Install server environment (SQL Server, .NET Core Runtime, ASP.NET Core Runtime)
3. Copy artifacts to Server
4. Install IIS (Internet information service)
5. Create IIS Web App (Configure Pool IIS No managed)
6. Config connection string appsettings.Production.json
7. Install Certificate for IIS (friendly name)
8. Setup security IIS_IUSR permission for web app, enable 32 bit in pool, enable stdout log in webconfig.
9. Instal rewrite URL Module for IIS (https://www.iis.net/downloads/microsoft/url-rewrite)
10. Create webconfig
```xml

<configuration>
      <system.webServer>
        <rewrite>
          <rules>
            <rule name="AngularJS Routes" stopProcessing="true">
              <match url=".*" />
              <conditions logicalGrouping="MatchAll">
                <add input="{REQUEST_FILENAME}" matchType="IsFile" negate="true" />
                <add input="{REQUEST_FILENAME}" matchType="IsDirectory" negate="true" />   
              </conditions>
              <action type="Rewrite" url="/" />
            </rule>
          </rules>
        </rewrite>
      </system.webServer>
</configuration>
```
11. Check url in setting

# Reference
1. https://jakeydocs.readthedocs.io/en/latest/client-side/using-gulp.html
