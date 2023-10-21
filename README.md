# Curso de Azure DevOps

Este curso tiene por objetivo aprender todo lo que se necesita de Azure Devops y Azure Repos

![PruebasUnitarias](https://vsrm.dev.azure.com/joshuarosev/_apis/public/Release/badge/cb5173c6-decf-421f-b8fe-c3f34d41deec/1/2)

![Desarrollo](https://vsrm.dev.azure.com/joshuarosev/_apis/public/Release/badge/cb5173c6-decf-421f-b8fe-c3f34d41deec/1/1)

![QA](https://vsrm.dev.azure.com/joshuarosev/_apis/public/Release/badge/cb5173c6-decf-421f-b8fe-c3f34d41deec/1/3)

# Azure Repos
Este es un archivo modificado por mi otro yo

## Pasos para añadir secrets a un proyecto de .NET

Utilizar los siguientes comandos:

- Para crear el user secrets escribir:

`dotnet user-secrets init` 

- Para asignar un valor a la configuracion

`dotnet user-secrets set "ConnectionStrings:Conexion" "Server=servidor;Database=Bd;Trusted_Connection=True"`

Respetar las comillas dobles

- Para listar las configuraciones

`dotnet user-secrets list`
