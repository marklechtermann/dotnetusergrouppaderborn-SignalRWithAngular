# Lightning Talk - Signal, Angular and .NET Core

My small chat application with .NET Core, REST, Angular and SignalR.

## Prerequisites
We only need 3 things:
* VSCode
    * https://code.visualstudio.com/
* donetcore
    * https://www.microsoft.com/net/download/windows
* node.js with npm and yarn
    * https://nodejs.org/en/
    * **npm install --global yarn** *(if you want to use yarn)*


## Update your NPM and nuget packages

In the ./WebApp folder:
 
```
yarn install
```


In the root folder:
```
dotnet restore
```

## Build and run the application
To build the Angular application (frontend):
```
ng build
```

or 
```
ng build --watch
```

To start the .NET Core application (backend):

```
dotnet run
```

or (see https://docs.microsoft.com/en-gb/aspnet/core/tutorials/dotnet-watch)

```
dotnet watch run
```



Have fun :-)
