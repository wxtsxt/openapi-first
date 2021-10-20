# openapi-first

Create OpenAPI yaml files and generate contract C# files

# Generate contract code from json contract

- Install Microsoft dotnet-openapi tool
    https://docs.microsoft.com/en-us/aspnet/core/web-api/microsoft.dotnet-openapi
- dotnet tool install -g Microsoft.dotnet-openapi
- dotnet openapi add file --updateProject .\Ref.csproj ..\OpenAPIs\contract-first-swagger.json

# Enrich the contract based on yaml format

- https://editor.swagger.io - view/edit contract or convert to yaml

- http://stevetalkscode.co.uk/openapireference-commands
```xml
 <OpenApiReference Include="OpenAPIs\swagger.yaml" CodeGenerator="NSwagCSharp"  Link="OpenAPIs\swagger.yaml" Options="/DateType:NodaTime.LocalDate /GenerateOptionalPropertiesAsNullable:true /GenerateNullableReferenceTypes:true" Namespace="WebApiFromTemplate" AdditionalNamespaceUsages="NodaTime">
      <AdditionalNamespaceUsages>NodaTime</AdditionalNamespaceUsages>
      <SourceUri>https://localhost:5051/swagger/v1/swagger.yaml</SourceUri>
</OpenApiReference>
```

OpenAPI data types
 - json schema https://datatracker.ietf.org/doc/html/draft-bhutton-json-schema-validation-00#section-7.3
 - extra types https://github.com/OAI/OpenAPI-Specification/blob/main/versions/3.1.0.md#data-types

#tools
- Visual Studio code OpenAPI editor https://marketplace.visualstudio.com/items?itemName=42Crunch.vscode-openapi
- Visual Studio Code REST client https://marketplace.visualstudio.com/items?itemName=humao.rest-client
- editor.swagger.io