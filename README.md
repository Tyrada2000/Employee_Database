# Employee_Database

This Project was created using visual Basic.NET to handle the formating and code. \
To handle the database management MySQL Workbench was used. \
\
The database only works locally \
When creating the server one must set the server setting to: <br> 
server=localhost \
userid=root \
password=Dragons1@ \
database=employeedata \
<br>
The name of the Database = employeedata <br>
The name of the only Table used = employeedata <br>

The Table will have 7 columns in this order: <br>
EmId <br>
Firstname <br>
Lastname <br>
JobTitle <br>
DateOfHire <br>
user_name <br>
passwords <br>
<br>
The First spot of the database will be filled using the command: <br>
<br>
INSERT into employeedata.employeedata(EmId, user_name, passwords) values ('0','',''); <br>
(feel free to insert whatever user_name and password you want, just dont forget it) <br>
<br>
The database is now ready to use with the program!! <br>
<br>
To run/build from command prompt: <br>
<br>
Navigate to your solution folder. <br>
Run: msbuild EmployeeDataBase.sln /p:Configuration=Release (or Debug) <br>
cd EmployeeDataBase (within your solution folder - it's a sub-folder) <br>
cd bin.<br>
cd Release (or Debug) <br>
Run: EmployeeDataBase.exe. <br>
<br>
If that doesn't work and you have Visual Studio Installed: <br>
<br>
Open Visual Studio and select EmployeeDatabase.sln <br>
Select Build solution <br>
