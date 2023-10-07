# Curso de Azure DevOps

Este curso tiene por objetivo aprender todo lo que se necesita de Azure Devops

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