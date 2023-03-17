# BillingApp
Simple Billing and Inventory Management Desktop Program build in C#

You can download this project as a zip file and run on your computer but you'll need to have Visual Studio installed on you computer and XAMPP server

# What you need to know
1) Visit this link to Download a zip file which contains all resources 
2) Inorder to run the database you need to install XAMPP and create a database called "inventory_manager"
3) Open the database you just created and from the downloaded file from 1 above  import  "inventory_manager" sql to the database
4) Depending on the setup of your XAMPP you might need to change the connection settings in project solution App.config file 
<add name="connstrng" connectionString="server=localhost;user=root;database=inventory_manager;port=3306;password=;" />
The default user is root and password is empty
5)Right click on reference in The project solution and click on Add Reference then Browse to the Unzipped file you downloaded in 1 above
6) Unzip MySql.Data file then import MySql.Data.DLL

# Fix a problem
You might encounter this error
System.IO.FileNotFoundException: 'Could not load file or assembly 'Renci.SshNet, Version=2016.1.0.0, Culture=neutral, PublicKeyToken=1cee9f8bde3db106' or one of its dependencies. The system cannot find the file specified.'

TO FIX IT 
Go to Tools > NuGet Package Manager > Manage NuGet Packages for Solution.

Search and install Renci.SshNet.Async

If you face any Issues please create an issue.
