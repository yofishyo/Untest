
## 專案環境

### 通用
- 採用.net5開發

### 01_Presentation/Untest.API
- .net Core API，DI注入service
- 使用Swagger 建立API文件

### 03_Data Access/Untest.EntityCore
- [使用DB first的方式，建立Model](https://learn.microsoft.com/zh-tw/ef/core/managing-schemas/scaffolding/?tabs=dotnet-core-cli)
- 相關NuGet套件 
    - Microsoft.EntityFrameworkCore
    - Microsoft.EntityFrameworkCore.Design
    - Microsoft.EntityFrameworkCore.SqlServer
    - Microsoft.EntityFrameworkCore.Tools
### Test
- 使用NUnit，建立單元測試專案
- FluentAssertions套件：提高程式碼可讀性
- NSubstitute套件：隔離相依物件

### 附錄
- 資料庫範例 [下載 北風資料庫sql Script](https://raw.githubusercontent.com/microsoft/sql-server-samples/master/samples/databases/northwind-pubs/instnwnd.sql)
