Для запуска необходимо иметь mssql server на локальном компьютере/на докере и изменить строку подключения в App.config на необходимые данные для подключения  
<connectionStrings>
    <add name="EmployeesDB" connectionString="Data Source=YOUR_HOST,1433;Database=YOUR_DB_NAME;User=YOUR_USER;Password=YOUR_PASSWORD;TrustServerCertificate=True;Integrated Security=False;" providerName="System.Data.SqlClient" />
</connectionStrings>