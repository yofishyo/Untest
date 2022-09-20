## 專案環境

### 通用
- 採用.net5開發

### 01_Presentation/Untest.API
- .net Core API
- 使用Swagger 建立API文件

### 03_Data Access/Untest.EntityCore
- [使用DB first的方式，建立Model](https://learn.microsoft.com/zh-tw/ef/core/managing-schemas/scaffolding/?tabs=dotnet-core-cli)
- 相關NuGet套件 
    - Microsoft.EntityFrameworkCore
    - Microsoft.EntityFrameworkCore.Design
    - Microsoft.EntityFrameworkCore.SqlServer
    - Microsoft.EntityFrameworkCore.Tools
### Test
- 使用[NUnit 3](https://marketplace.visualstudio.com/items?itemName=NUnitDevelopers.TestGeneratorNUnitextension-18371)，建立單元測試專案
- [FluentAssertions](https://fluentassertions.com/introduction)套件：提高程式碼可讀性
- [NSubstitute](https://nsubstitute.github.io/)套件：隔離相依物件

### 附錄
- 資料庫範例 [下載 北風資料庫sql Script](https://raw.githubusercontent.com/microsoft/sql-server-samples/master/samples/databases/northwind-pubs/instnwnd.sql)
