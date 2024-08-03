<h1 align="center" id="title">The Relaxing Koala IT Solution</h1>

<p align="center"><img src="https://socialify.git.ci/khoatrbl/the-relaxing-koala-app/image?description=1&amp;descriptionEditable=The%20IT%20Solution%20for%20the%20Relaxing%20Koala%20Caf%C3%A9&amp;font=Raleway&amp;language=1&amp;name=1&amp;pattern=Solid&amp;theme=Auto" alt="project-image"></p>

<p id="description">This project is an IT Solution designed as per request of The Relaxing Koala owner as they wish to expand their business and automate operations for a more efficient running of the restaurant. This IT Solution is a POS System that can help automate the process of ordering, reporting on sale, making reservations and table management with the backing of a database.</p>

<h2>Project Screenshots:</h2>

<img src="https://media.discordapp.net/attachments/1214598042917797928/1268751070234935317/image.png?ex=66ad9003&amp;is=66ac3e83&amp;hm=f4a74658275a27635b7d5c898444e2ff16fb7c096f360d21f622cdda223d17ed&amp;=&amp;format=webp&amp;quality=lossless" alt="project-screenshot" width="600" height="400/">

<img src="https://media.discordapp.net/attachments/1214598042917797928/1268783479282339941/image.png?ex=66adae32&amp;is=66ac5cb2&amp;hm=76819b32c554535cbe8ed9f4404d2f9ca32f184232a8b8d3ea67c3542dd78839&amp;=&amp;format=webp&amp;quality=lossless&amp;width=515&amp;height=350" alt="project-screenshot" width="600" height="400/">

  
  
<h2>🧐 Features</h2>

Here're some of the project's best features:

*   Table Management
*   Ordering
*   Payment
*   Make reservations
*   Monitoring sales
*   Creating sale reports

<h2>🛠️ Installation Steps:</h2>

<p>1. Download and install MSSQL Express .</p>

```
https://www.microsoft.com/en-us/download/details.aspx?id=101064
```

<p>2. Download and install Microsoft SQL Server Management Studio.</p>

```
https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16
```

<p>3. Clone this project to your device using the following command:</p>

```
git clone https://github.com/khoatrbl/the-relaxing-koala-app.git
```

<p>4. In the cloned project, there is a file named <strong>Data.sql</strong>. Open the file using SSMS.</p>

<p>5. A connection setup window should appear. <strong>Tick "Trust server certificate"</strong> and click <strong>Connect</strong>.</p>
<img src="https://media.discordapp.net/attachments/1214598042917797928/1268567437511757834/image.png?ex=66ad8dbd&is=66ac3c3d&hm=9fed071477ce98379a17a5c3623e5b2da12072e7ca5103249f13b42b18cca3d6&=&format=webp&quality=lossless" alt="project-screenshot" width="500">

<p>6. If <i>Inconsistent Line Endings</i> window appears, <strong>click on Yes</strong>.</p>
<img src="https://media.discordapp.net/attachments/1214598042917797928/1268569322138374325/image.png?ex=66ad8f7f&is=66ac3dff&hm=94445cdcf2a6d9107e53de068e3cc9f3b21c18a693665c8be6524e6df6b31243&=&format=webp&quality=lossless" alt="project-screenshot" width="500">

<p>7. Once the database is done loading (with the queries appear on screen). <strong>Press F5</strong> or click on <strong>Execute</strong> to create the database.</p>

<p>8. You can use the following query to check if there is an account registered into the database:</p>

```
SELECT * FROM Account
```

<p>9. Now open the project in Visual Studio. Choose <strong>Tools</strong> on the menu bar, and select <strong>Connect to Database</strong>.</p>
<img src="https://media.discordapp.net/attachments/1214598042917797928/1268572136616886313/image.png?ex=66ad921e&is=66ac409e&hm=265e1480aa5b822d332a704f1c0272aeff76251c2a7f76dbbd11db884adf1463&=&format=webp&quality=lossless" alt="project-screenshot" width="500">

<p>10. When the <strong>Choose Data Source</strong> pops up, choose <strong>Microsoft SQL Server</strong> and <strong>Continue</strong>.</p>
<img src="https://media.discordapp.net/attachments/1214598042917797928/1268572223522738206/image.png?ex=66ad9233&is=66ac40b3&hm=ce318f22b9f7fee91d643a21049442c8afd8b27b9190b1a84d09692cd656ede5&=&format=webp&quality=lossless" alt="project-screenshot" width="500">

<p>11. <strong>Add connection</strong> should now pop up. Here, you enter the Server Name (specified in SSMS) and select <strong>TheRelaxingKoala</strong> database.</p>
<img src="https://media.discordapp.net/attachments/1214598042917797928/1268575325323792498/image.png?ex=66ad9516&is=66ac4396&hm=d456f98c026bffbe167f41dfff3850fe830e10fb6aa45b8dc1290afcfbb8c4c6&=&format=webp&quality=lossless&width=536&height=676" alt="project-screenshot" width="500">

<p>12. Click on <strong>Test Connection</strong> and check if we have successfully connected to the database.</p>

<p>13. Click on <strong>Advanced</strong> to get the connection string and <strong>Copy</strong> it.</p>
<img src="https://media.discordapp.net/attachments/1214598042917797928/1268576253930246188/image.png?ex=66ad95f3&is=66ac4473&hm=29834c0935c49dbd19d81d032c47f80b9c5f3949fa0642f5f1ca736cb71c7782&=&format=webp&quality=lossless" width="500">

<p>14. Head to folder <strong>DAO -> DataProvider.cs</strong> and paste the connection string into the predefined variable (noted within the file).</p>
<img src="https://media.discordapp.net/attachments/1214598042917797928/1268576599650074624/image.png?ex=66ad9646&is=66ac44c6&hm=c1534c51b9374fb2c259c50cec81b575142bbfebd2d8b3a6a03f9d7ada42b7b3&=&format=webp&quality=lossless" with="500">
 
<p>15. The application is now ready. You can run the program, and login using the credentials you added into the database before, with the password of <strong>1</strong>. You can change your password after you have logged in.</p>

