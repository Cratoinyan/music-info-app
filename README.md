# music-info-app
A web application that holds information about artists, songs and other music industry related entities
# Project Structure
Project has 2 different solutions; one for displaying the data in a web interface and one for providing a RestAPI for the UI to consume. RestAPI consists of 3 layers:

1-Data Layer: Definition of Entities

2-Data Access Layer: Repositories for all the entities

3-Business Logic: Contains Controllers that handle api endpoints
# Building the Project

To build the project simply call the init.ps1 script from an elevated console. This script will download all the dependincies set up a database and fill the database with some initial data. Initial data may not be successfuly completed in that case after the init.ps1 is finished run the given exampleRequests.json from postman.