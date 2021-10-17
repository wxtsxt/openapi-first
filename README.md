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