# Stenden-Weerstation
C# 1 eindopdracht

# How to run
1. Get an API key from [Open Weather Map](https://home.openweathermap.org/users/sign_up)
2. Attach Database in [SSMS](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15)
   <br>I used this command to attach the Database (file location may be different):
```SQL
CREATE DATABASE "StendenWeerstation" ON
(FILENAME = "C:\Users\jesper\source\repos\Stenden-Weerstation\StendenWeerstation.mdf")
FOR ATTACH_REBUILD_LOG
GO
```
3. Open solution in visual studio
4. Add the file [ApiKey.cs](https://pastebin.com/zbLtcipp) path should be \WebAPIController\ApiKey.cs
5. Right click WebAPIController and click view in browser
6. Run the mighty code ;)
