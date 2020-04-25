# Starter App with EF Core, Swagger/OpenApi, NgRx, Bootstrap

## Goal

Create a Starter App with EF Core, Swagger/OpenApi, NgRx, Bootstrap.

## Content

- [Starter App with EF Core, Swagger/OpenApi, NgRx, Bootstrap](#starter-app-with-ef-core-swaggeropenapi-ngrx-bootstrap)
  - [Goal](#goal)
  - [Content](#content)
  - [Step 1: Swagger/OpenApi](#step-1-swaggeropenapi)
  - [Step 2: add EF Core](#step-2-add-ef-core)
  - [Step 3: add Bootstrap](#step-3-add-bootstrap)
  - [Step 4: add NgRx](#step-4-add-ngrx)
  - [What's next](#whats-next)
  - [Additional Information](#additional-information)
    - [Links](#links)
    - [Current Versions](#current-versions)

## Step 1: Swagger/OpenApi

Clone this app: <https://github.com/boeschenstein/angular9-dotnetcore-openapi-swagger>

This is the starter pack from here: <https://github.com/boeschenstein/angular9-dotnetcore3>
enriched with Swagger/OpenApi.

## Step 2: add EF Core

Add EF Core: <https://github.com/boeschenstein/angular9-dotnetcore-ef-sql>

> To avoid conflicts between different projects, I decided to use another database here: BloggingEF2Test instead of BloggingEFTest

## Step 3: add Bootstrap

Bootstrap is a well know UI Library: <https://getbootstrap.com/>

We install `ng-bootstrap`, an Angular specific version: <https://ng-bootstrap.github.io/>.

Open cmd in your frontend folder (where your `package.json` lies) and enter:

``` cmd
ng add @ng-bootstrap/ng-bootstrap
```

> [ng-bootstrap](https://ng-bootstrap.github.io/) is a wrapper for [bootstrap](https://getbootstrap.com/), therefore [bootstrap](https://getbootstrap.com/) will also get installed (check package.json)

Replace the code in `app.component.html` by this:

``` html
<ngb-accordion #acc="ngbAccordion" activeIds="ngb-panel-0">
  <ngb-panel title="Simple">
    <ng-template ngbPanelContent>
      This is the first test with ng-bootstrap.
    </ng-template>
  </ngb-panel>
  <ngb-panel>
    <ng-template ngbPanelTitle>
      <span>Click me! I will show a secret!</span>
    </ng-template>
    <ng-template ngbPanelContent>
      Congratulations! You just have successfully installed ng-bootstrap!
      (You can remove ngb-accordion from app.component.html)
    </ng-template>
  </ngb-panel>
</ngb-accordion>

<router-outlet></router-outlet>
```

## Step 4: add NgRx

NgRx is a well know State Management Library: <https://ngrx.io/>

Open cmd in your frontend folder (where your `package.json` lies) and enter:

``` cmd
rem Install NgRx Library
npm install @ngrx/store --save

rem Add and Configure NgRx
ng add @ngrx/store --minimal false
```

## What's next

## Additional Information

### Links

- Setup a new ASP.Cor 3.1/Angular 9.1 solution from scratch: <https://github.com/boeschenstein/angular9-dotnetcore3>
- ASP.NET WebApi: <https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-3.1&tabs=visual-studio>
- Swashbuckle: <https://github.com/domaindrivendev/Swashbuckle.AspNetCore>
- Angular: <https://angular.io/>
- Bootstrap: <https://getbootstrap.com/>
- ng-bootstrap: <https://ng-bootstrap.github.io/>.
- NgRx: <https://ngrx.io/>
- About me: <https://github.com/boeschenstein>

### Current Versions

- Visual Studio 2019 16.5.3
- .NET core 3.1
- npm 6.14.4
- node 12.16.1
- Angular CLI 9.1
- SwashBuckle 5.3.1
- "@ng-bootstrap/ng-bootstrap": "^6.1.0"
- "@ngrx/store": "^9.1.0"
