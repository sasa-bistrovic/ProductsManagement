<p><b><font face="Arial" size="4">Procedure for starting the project:</font></b></p>
<p><b><font face="Arial">1. You must have Microsoft ASP.NET 8.0 and Microsoft SQL Server Express installed.</font></b></p>

<p><b><font face="Arial">2. Clone the project from github.com with the command:</font></b></p>

<p><font face="Arial">$ git clone https://github.com/sasa-bistrovic/ProductsManagement.git</font></p>

<p><b><font face="Arial">3. In file appsettings.json in the folder "/ProductsManagement", set:</font></b></p>

<p style="margin-top: 0; margin-bottom: 0"><font face="Arial">{</font></p>
<p style="margin-top: 0; margin-bottom: 0"><font face="Arial">  "ConnectionStrings": {</font></p>
<p style="margin-top: 0; margin-bottom: 0"><font face="Arial">    "ProductContext": "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;Encrypt=False;"</font></p>
<p style="margin-top: 0; margin-bottom: 0"><font face="Arial">  }</font></p>
<p style="margin-top: 0; margin-bottom: 0"><font face="Arial">}</font></p>

<p><b><font face="Arial">4. In the "/ProductsManagement" folder, run the command:</font></b></p>

<p style="margin-top: 0; margin-bottom: 0"><font face="Arial">dotnet add package Microsoft.EntityFrameworkCore</font></p>
<p style="margin-top: 0; margin-bottom: 0"><font face="Arial">dotnet add package Microsoft.EntityFrameworkCore.SqlServer</font></p>
<p style="margin-top: 0; margin-bottom: 0"><font face="Arial">dotnet add package Microsoft.EntityFrameworkCore.Tools</font></p>

<p style="margin-top: 0; margin-bottom: 0"><font face="Arial">dotnet ef migrations add InitialCreate</font></p>

<p style="margin-top: 0; margin-bottom: 0"><font face="Arial">dotnet ef database update</font></p>

<p style="margin-top: 0; margin-bottom: 0"><font face="Arial">dotnet run</font></p>

<p><b><font face="Arial">5. Here is picture from ProductsManagement URL "http://localhost:5069":</font></b></p>

<font face="Arial">

<img src="https://github.com/sasa-bistrovic/ProductsManagement/blob/main/ProductsManagement-1.png"></img>

</font>