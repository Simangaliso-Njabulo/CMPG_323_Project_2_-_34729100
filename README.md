# CMPG_323_Project_2_-_34729100

In this project I am expected to create an API for managing IoT Devices. The API will be created using visual studio .NET core and will be tested using Swagger.

# How to test the API

Step 1: Go to this url - https://cmpg323project2-34729100-ase.azurewebsites.net/swagger/index.html<br/>

Step 2: Under Authenticate click "Post/api/Authenticate/login".<br/>

Step 3: In the right conner of the "Post/api/Authenticate/login" window click on "try it out".<br/>

Step 4: The black "Example Value" textbox will turn white. Replace the 1st text that reads "string" with a user name and the 2nd with a password. List of users provided below. 
NOTE !!! Login using one of the admin users (user name: dave or fifi || password: Abc123!@) because all my endpoints need admin authetication.<br/>

Step 5: Click the blue "Execute" button<br/>

Step 6: Under "Responses" the "Sever response" will return a token.<br/>

Step 7: Copy the token from after the open quotes till just before to close quotes. Example of what you copied must look something like this:<br/> 

eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiZmlmaSIsImp0aSI6ImI2NmM5M2YzLTdhN2MtNGUyYi04ZTc5LTdkMjkxOWM1MWNhMSIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvcm9sZSI6IkFkbWluIiwiZXhwIjoxNjYyNjU3NTAxLCJpc3MiOiJodHRwOi8vbG9jYWxob3N0OjYxOTU1IiwiYXVkIjoiaHR0cDovL2xvY2FsaG9zdDo0MjAwIn0.Co8MyT3ESa46KrI-TE71dBuQ_SteaShNTHa3XAfVRU8<br/>

Step 8: Scroll down to "Categories" and click "Get/api/Categories".<br/>

Step 9: In the right conner of the "Get/api/Categories" window click on the gray lock icon.<br/>

Step 10: The "Availible authorizations" window will pop up. Follow the given instructions and click "Authorize". Then click close.

Step 11: In the right conner of the "Get/api/Categories" window click on "try it out". Then "Execute"<br/>

If you scroll down to "server response" you should see a list of all categories.<br/>

NOTE !!! You have been authenticated. The gray lock has turned black for all the other methods as well. You can simple test the rest of the api in a simular manner.<br/>

## List of Users 

* All users use this same password: Abc123!@ for ease of testing.

### Admin users

User Name: dave<br/>
User assword: Abc123!@<br/>

User Name: fifi<br/>
User assword: Abc123!@<br/>

### General users

User Name: sue<br/>
User assword: Abc123!@<br/>

User Name: steve<br/>
User assword: Abc123!@<br/>

## List of Categories

Category Id: 3fa85f64-5717-4562-b3fc-2c963f66afa6<br/>
Category Name: Lights<br/>

Category Id: 8f692fa8-7175-4562-b3fc-2c963f66afa6<br/>
Category Name: Air Conditioners<br/>

Category Id: 5f643fa8-7175-4562-b3fc-2c963f66afa6<br/>
Category Name: Doors<br/>

Category Id: 2f653fa8-7175-4562-b3fc-2c963f66afa6<br/>
Category Name: Security Cameras<br/>

Category Id: 3f693fa8-7175-4562-b3fc-2c963f66afa6<br/>
Category Name: Gates<br/>

## List of Devices

Device Id: f04238d2-bad6-4823-82da-c2f65287153c<br/>
Device Name": Light A1<br/>

Device Id: 1a76e340-40f8-4ed4-ab91-f64edf9fbd95<br/>
Device Name": Light A2<br/>

Device Id: 8ef02dde-730f-4e70-b446-c82b22cbcf65<br/>
Device Name": Light A3<br/>

Device Id: 67e4be1f-b268-4f4f-bd00-027788297f4e<br/>
Device Name": Light B1<br/>

Device Id: ecddc633-2503-4abf-8d8e-a5b8c5a63b05<br/>
Device Name": Light B2<br/>

Device Id: 12174b3e-d2bd-42ff-a7d4-009b5d58aafd<br/>
Device Name": Light C<br/>

Device Id: 96d733dc-428a-4f69-86ff-803018bc43f0<br/>
Device Name": AirCon A<br/>
  
Device Id: b95dcaad-2483-4e48-a7a2-ecea0edf7926<br/>
Device Name": AirCon B<br/>

Device Id: 1e08d9d3-888d-45c9-9682-191ef6284572<br/>
Device Name": AirCon C<br/>
   
Device Id: 6d801940-dc4b-47fd-baf1-8ea230bbf845<br/>
Device Name": Door A<br/>

Device Id: e580d077-d547-43c9-970a-ba347aaaede8<br/>
Device Name": Door B<br/>

Device Id: 6d229ddb-c935-472d-89aa-02620bdd9b8e<br/>
Device Name": Door C<br/>

Device Id: 9d0b9343-f799-4f63-89f2-c2a72c235834<br/>
Device Name": Door C2<br/>

Device Id: cd24b236-be81-4d68-bb7c-24288eedabe7<br/>
Device Name": Camera A<br/>
  
Device Id: 40b85444-4200-457e-895d-4e7ebe4e1b94<br/>
Device Name": Camera B<br/>  

Device Id: 2c41f878-15e4-4f7f-8e50-aa9aea25069b<br/>
Device Name": Camera C<br/>  

Device Id: af93357f-2586-4f59-ba6e-42f5a873af3e<br/>
Device Name": Gate A<br/> 
 
Device Id: be3776a2-b9eb-43cb-80f3-07bb28cc9159<br/>
Device Name": Gate B<br/> 

Device Id: 0621cad0-e985-427d-8a44-2362ab241a72<br/>
Device Name": Gate C<br/> 

## List of Zones

* Note!! Zones D-H are currently under construction and therefore have on devices in them yet.

Zone Id: emsp 4d37cb12-4359-430a-a5c6-09f1198781b6<br/> 
Zone Name: Zone A<br/>
Zone Description: Faculty of Economic and Management Sciences<br/>

Zone Id: 68f749d9-3b12-44c3-8cf8-1b0759bef41a<br/>
Zone Name: Zone B<br/>
Zone Description: Faculty of Education<br/>

Zone Id: ef59f094-97e2-4b7f-9b35-4c8cb8fb3e75<br/>
Zone Name: Zone C<br/>
Zone Description: Faculty of Engineering<br/>

Zone Id: 93116015-676c-403a-bfe2-56139b5ba2e3<br/>
Zone Name: Zone D<br/>
Zone Description: Faculty of Health Sciences<br/>

Zone Id: 719f0d35-29fd-48e0-85f9-81e870e4c56d<br/>
Zone Name: Zone E<br/>
Zone Description: Faculty of Humanities<br/>

Zone Id: a4debc7c-fb77-47e3-b8cd-96f6c2b8014f<br/>
Zone Name: Zone F<br/>
Zone Description: Faculty of Law<br/>

Zone Id: b89bdafb-717b-4784-8cf8-a9e8ecc79ef0<br/>
Zone Name: Zone G<br/>
Zone Description: Faculty of Natural and Agricultural Sciences<br/>

Zone Id: 4f29dcac-affd-457e-843f-e0497a1f76c5<br/>
Zone Name: Zone H<br/>
Zone Description: Faculty of Theology<br/>

## Project progress 

### 30/08/22

Today I will be creating my Azure database and connecting it to my API.
> I created my Azure database but failed to connect it to my API. I will go do reseach and ask some questions and try again another day.

Late update - On Saturday 27/08/22 I made a local database and created a simple API to see how everything works. I also created a resource group on MS Azure and tried to create the database, but I ran into some problems. Unfortunately, I forgot to update my readme.

### 01/09/22

Today I will be reattempting to connect my Azure database to my API. I will also be creating the basic methods.
> Succeeded in linking my Azure database with my API, also added a basic methods.

### 05/09/22

On the 3rd and 4th of Sept I was completing my training hence no update was made to my read me. Today I'll be looking into Security within my API. 
> Created methods for authentication but couldn’t get the into my database because it said I had 2 contexts. Will have a crack at it again tomorrow.

### 06/09/22

Today I will be attempting to fixing the errors  I encountered yesterday and completing my API security (Authentication) . 
> API security is up and running so glad I found solutions to my errors.

## References

<ul>
 <li><p><a href="https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio">Tutorial: Create a web API with ASP.NET       Core</a></p></li> 
  <li><p><a href="https://www.guidgenerator.com/online-guid-generator.aspx">GUID generator</a></p></li> 
  <li><p><a href="https://www.dropbox.com/sh/p8fiokfpiqv4gud/AAC5X8SdanTnduTWYzVq4kQ7a?dl=0&preview=05+CMPG+323+-+API+Security+intro+23+Aug.mp4">23 Aug Class Recording    || API Security</a></p></li> 
  <li><p><a href="https://www.dropbox.com/sh/p8fiokfpiqv4gud/AAC5X8SdanTnduTWYzVq4kQ7a?dl=0&preview=05+CMPG+323+-+CLOUD+and+API+Security+25+August.mp4">25 Aug Class  Recording    || Cloud and API Security</a></p></li>
  <li><p><a href="https://brightsec.com/blog/api-security/">API Security: The Complete Guide to Threats, Methods & Tools</a></p></li> 
  <li><p><a href="https://www.microfocus.com/en-us/what-is/api-security">What is API Security?</a></p></li> 
  <li><p><a href="https://youtu.be/ht9e01bTklE"> How to protect your APIs against these 6 security threats</a></p></li>
  <li><p><a href="https://docs.microsoft.com/en-us/learn/modules/build-web-api-aspnet-core/">Create a web API with ASP.NET Core controllers</a></p></li>
  <li><p><a href="https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-3.1">ASP.NET Core web API documentation with      Swagger / OpenAPI</a></p></li>
  <li><p><a href="https://docs.microsoft.com/en-us/learn/paths/create-microservices-with-dotnet/">Create microservices with .NET and ASP.NET Core</a></p></li>
  <li><p><a href="https://jwt.io/introduction/">Introduction to JSON Web Tokens</a></p></li>
  <li><p><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.identity.entityframeworkcore?view=aspnetcore- 1.1">Microsoft.AspNetCore.Identity.EntityFrameworkCore Namespace</a></p></li>
  <li><p><a href="https://youtu.be/YMBAeHaqrVs">Package Manager Console More than one DbContext was found in ASP NET CORE</a></p></li>
  <li><p><a href="https://youtu.be/C2L7SUZY9fw">InvalidOperationException Unable resolve service Context attempt activate Controller ASP.NET Core</a></p></li> 
  <li><p><a href="https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-6.0">Dependency injection in ASP.NET Core</a></p></li>
  <li><p><a href="https://stackoverflow.com/questions/40023013/tab-space-in-markdown">Markdown tab syntax</a></p></li>
  <li><p><a href="https://jd-bots.com/2022/01/24/join-two-entities-in-net-core-using-lambda-and-entity-framework-core/">Join two entities in .NET Core, using lambda and Entity Framework Core</a></p></li>
  <li><p><a href="https://docs.microsoft.com/en-us/aspnet/core/tutorials/publish-to-azure-api-management-using-vs?view=aspnetcore-6.0">Publish an ASP.NET Core web API to Azure API Management with Visual Studio</a></p></li>
  <li><p><a href="https://youtu.be/z8pMW1Lmm-Q">How to Deploy/Publish your Web-API to Azure App Service</a></p></li>
  <li><p><a href="https://youtu.be/Gu9reN09mXI">Azure API Management in 7 minutes (from provisioning to API deployment) - tutorial for beginners</a></p></li>
  <li><p><a href="https://thejpanda.com/2020/08/10/python-automating-asp-net-core-web-api-creation-that-communicates-with-your-database-in-60-seconds-or-less/">Automating ASP.NET Core Web API Creation That Communicates With Your Database in 60 Seconds or Less</a></p></li>
  <li><p><a href="https://youtu.be/ScWU8K4XH1c">Open Source and Community: Get the most out of your APIs with API Management</a></p></li>
  <li><p><a href="https://youtu.be/5qZRzwjKNJ4">Building Web API Solutions with Authentication</a></p></li>
  <li><p><a href="https://youtu.be/XUCsHYNPzrI">Learning Azure: Part 2—Architecture and interactive APIs for .NET and REST APIs | Azure Friday</a></p></li>
  <li><p><a href="https://docs.microsoft.com/en-us/answers/questions/585436/web-api-with-entity-framework-core-using-the-join.html"> WEB API with Entity Framework Core using the JOIN statement</a></p></li>
  <li><p><a href="https://stackoverflow.com/questions/58653768/joining-two-tables-in-asp-net-webapi-2">Joining two tables in asp.net webapi 2</a></p></li>
</ul>
