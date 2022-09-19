<h1> spider_.net_console_app </h1>
<p>This .net concole app (demo) collects data from eshop website (example: https://www.jayagrocer.com/collections/alcohol) and store important information into Azure SQL Server database. The main tasks of this project include</p>
<ul>
    <li>Create an <b>Azure SQL server</b> database to host the information</li>
    <li>Use the code-first approach of Microsoft's entity framework to create the schema of the database</li>
    <li>Create HTTP driver to get the page source of the target website</li>
    <li>Parse the data source into JSON format and Use the ORM method to store the data into Azure SQL Server database</li>
</ul>
<p>Notes:</p>
<ul>
    <li>This application try to also implement Selenium driver to collect dynamic data (render by JS), still in progress</li>
    <li>This application try to collect data from source of JSON, XML and HTML, though current only implement JSON version</li>
</ul>
