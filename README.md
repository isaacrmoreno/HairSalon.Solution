<h1 align="center">
💈 Eau Claire's Salon 💇 </h1>

<hr style="height: 1px; border:none; color:#333; background" />

### By Isaac Moreno 👨‍💻

Click [here](https://github.com/isaacrmoreno/HairSalon.Solution) to view project.

# Description 📝

This is a MVC one-to-many mock up site for Eau Claire who needs to manage her stylist and their clients.

# Prerequisites 🖥️

- [MySQL Community Server](https://dev.mysql.com/downloads/file/?id=484914)
- [MySQL Workbench](https://dev.mysql.com/downloads/file/?id=484391)
- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- A text editor like [VScode](https://code.visualstudio.com/) | [Atom](https://atom.io/) | [Sublime](https://www.sublimetext.com/)
- A command line interface like Terminal or Gitbash to run and interact with the console app.

# Setup/Installation Requirements 📁

### Database Setup:

- Carefully follow [these steps from LearnHowToProgram.com](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql) to install both **MySQL Server 8.0.19** and **MySQL Workbench**.
- Ensure the MySQL server is running by opening Terminal or Windows Powershell and entering the command `mysql -uroot -pepicodus`

  - If you set up MySQL Server with a different username and/or password, the command will be `mysql -uYourUsername -pYourPassword`

  To import the database structure:

- Open MySQL Workbench
- On the "Welcome" page, double-click the MySQL Local instance 3306 in the **MySQL Connections** section. You may be prompted to enter a password; if so, this will be `epicodus` or your custom password, just as in the earlier step
- Click on the **Adminstration** tab

  1. Click on _Data Import/Restore_
  2. In the Data Import window that appears, select _Import from Self-Contained File_
  3. Navigate the file selection to your cloned project location and choose the `.sql` file at `HairSalon.Solution/isaac_moreno.sql`
  4. At the **Default Target Schema** option, choose _New..._ and name the schema `whatever_your_database_schema_is_called`
  5. Click the _Start Import_ button at the bottom-right.

  ### Database Setup:

1. Download MySQL and MySQL Workbench to set up a local database

- Once installed, open MyMql Workbench and open a local server
- In the Navigator, select the Administration tab and then select Data Import/Restore
- Under Import Options, select Import From Self-Contained File, and then select the "isaac_moreno.sql" file which can be found in HairSalon.Solution
- In the Default Schema to be Imported To option, select New
- Enter a name for your database and select OK
- Click Start Import to begin database import

### Application Setup:

1. Clone this repository: `% git clone https://github.com/isaacrmoreno/HairSalon.Solution`
2. Navigate to the HairSalon.Solution directory on your computer
3. Open with your preferred text editor to view code
4. Within your Command line run `cd HairSalon`, touch `appsettings.json`.
5. Add the following block of code to your .json file

```
{
"ConnectionStrings": {
"DefaultConnection": "Server=localhost;Port=3306;database=[YOUR DATABASE];uid=root;pwd=[YOUR PASSWORD];"
}
}
```

- Note: Make sure that [YOUR DATABASE] and [YOUR PASSWORD] match the database name and password of your local MySql server.\_

### To Run Application:

1. To run console app:
   - Navigate to `HairSalon.Solution/HairSalon` in your command line
   - Run the command `dotnet restore` to restore the dependencies that are listed in the .csproj
   - Run the command `dotnet build` to build the project and its dependencies into a set of binaries
   - Run the command `dotnet run` to run project.
   - View project via web browser: `localhost:5000/`
   - Note: `dotnet run` also restores and builds the project, so you can use this single command to start the console app
2. (Optional) To run tests:
   - Navigate to `HairSalon.Solution/HairSalon.Tests` in your command line.
   - Run the command `dotnet restore` to restore the dependencies that are listed in the .csproj
   - Finally, run the command `dotnet test` to run the tests!

<hr style="height: 1px; border:none; color:#333;" />

# Bugs 🐛

No known issues

# Technologies Used 💾

<div align="center">
<img src="https://raw.githubusercontent.com/github/explore/80688e429a7d4ef2fca1e82350fe8e3517d3494d/topics/html/html.png" alt="html" height="45" style="vertical-align:top; margin:4px">
<img src="https://raw.githubusercontent.com/github/explore/80688e429a7d4ef2fca1e82350fe8e3517d3494d/topics/css/css.png" alt="css" height="45" style="vertical-align:top; margin:4px">
<img src="https://raw.githubusercontent.com/github/explore/80688e429a7d4ef2fca1e82350fe8e3517d3494d/topics/bootstrap/bootstrap.png" alt="Bootstrap" height="45" style="vertical-align:top; margin:4px">
<img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg" alt="csharp" height="45" style="vertical-align:top; margin:4px" />
<img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/dot-net/dot-net-original.svg" alt="dotnet" height="45" style="vertical-align:top; margin:4px"/>
<img src="https://raw.githubusercontent.com/github/explore/80688e429a7d4ef2fca1e82350fe8e3517d3494d/topics/visual-studio-code/visual-studio-code.png" alt="visual-studio-code" height="45" style="vertical-align:top; margin:4px">
</div>

# Contact ✉️

[GitHub](https://github.com/isaacrmoreno) | [Email](mailto:ipdxcreative@gmail.com)

<hr style="height: 1px; border:none; color:#333;" />

# Copyright and License ⚖️

[MIT License](license) &copy; 2021 Isaac Moreno
