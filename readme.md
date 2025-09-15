# Local environment configuration

## Setup profile

Set the environment name for user variables.
[See details.](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/environments?view=aspnetcore-8.0#windows---set-environment-variable-globally)

## [GetVersion](https://gitversion.net/) setup

To be able to build version of an services should be installed `dotnet-getversion`.

> dotnet tool install --global GitVersion.Tool --version 5.\*

The `GitVersion.yml` file, in the root of the repository folder, have all necessary settings.
To get a new version will be enough run command

> dotnet-gitversion

# Docker setup

To setup Docker go to [Docker Desktop site](https://www.docker.com/products/docker-desktop/) download and install like a regular application. After installation has been completed run it. First run can propose to use `WSL2` if CPU is supported it. Choose it to get more faster docker, it can take some time of configuration.
After installation has been completed, you can run some commands in the console to setup containers.

## Docker setup for Windows

1. Setup `PostgreSQL`
	> `docker run -d -p 5432:5432 --name postgres --restart unless-stopped -e POSTGRES_PASSWORD=Qwerty123$% -v d:\hyt-data\postgresql:/var/lib/postgresql/data postgres`

## Docker setup for Mac OS

1. Setup `PostgreSQL`
	> `docker run -d -p 5432:5432 --name postgres --restart unless-stopped -e POSTGRES_PASSWORD=Qwerty123$% -v ~/documents/HYT/containers/data/postgresql:/var/lib/postgresql/data postgres`

## Setup Local Environments
Press Windows button and find "Edit the system environment variables", open "Environment variables" and add 
`ASPNETCORE_ENVIRONMENT` with value `Local` to "User variables".

## Setup Certificate
1. Close all browsers.
2. Setup certificate `dotnet dev-certs https --trust`.

## VS Code settings

The list of plugins that should be installed to have the same development environment settings.

1. [Angular Language Service](https://marketplace.visualstudio.com/items?itemName=Angular.ng-template)
2. [EditorConfig for VS Code](https://marketplace.visualstudio.com/items?itemName=EditorConfig.EditorConfig)
3. [ESLint](https://marketplace.visualstudio.com/items?itemName=dbaeumer.vscode-eslint)
4. [Code Spell Checker](https://marketplace.visualstudio.com/items?itemName=streetsidesoftware.code-spell-checker)
5. [Prettier - Code formatter](https://marketplace.visualstudio.com/items?itemName=esbenp.prettier-vscode)
6. [SVG](https://marketplace.visualstudio.com/items?itemName=jock.svg)

[npm-check-updates](https://www.npmjs.com/package/npm-check-updates) tool for easy checking packages for updates.<br>
Install globally: `npm install -g npm-check-updates`<br>
Usage: `ncu`
Update All packages:
1. Update the package.json "ncu --upgrade"
2. Validate the changes to your package.json
3. Install the new packages "npm install"

## WebStorm settings

The list of plugins that should be installed to have the same development environment settings.

1. [Prettier](https://plugins.jetbrains.com/plugin/10456-prettier)

Install prettier globally: `npm install --global prettier`

Make sure you choose "Automatic Prettier Configuration" in [Settings -> Languages & Frameworks -> JavaScript -> Prettier](jetbrains://WebStorm/settings?name=Languages+%26+Frameworks--JavaScript--Prettier) and turn on "Run on Save". 
In "Run for files" pass `**/*.{js,cshtml,html,ts,jsx,tsx,vue,astro,scss,css,json`

## Creating angular module 

1. Use the command in terminal npm g m ./{module name}
2. Add path into "paths" section of tsconfig.json "@{module name}/*": ["src/{module name}/*"]

## Creating angular component 

1. Use the command in terminal npm c m ./{module name}/components/{component name}
2. Add file index.ts into ./{module name}/components/ if it doesn't exist.
3. Add export into index.ts file export * from './{component name}/{component name}.component';
