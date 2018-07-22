
Tools & technologies
-------------------------------
Visual Studio, .NET Framework 4.0, Winforms, C#.NET, ADO.NET

Pattern
------------------------------
1. Developed using layered-architecture approach
	a. Physical Layers
		1. Presentation Layer
		2. Data Layer
	b. Logical Layers
		1. Business Service
		2. Data Access
		3. Data Model
2. Test project for login username and password validation
	a.Test class Methods
		1. Users input for password is between 6 and 12 characters, has uppercase, and symbols
		2. User input is less than 6 characters
		3. User input is greater than 12
		4. User input does not contain number
		5. User input does not contain symbol
		6. User input does not contain upper case
		7. The user did not input 
3. Written code is stylecop compliant.
4. Coding and naming conventions are as per MSDN standards.

Forms
--------------------------------
1. Simple login screen
	a. Username: demodemo
	b. Password: Demo123!
1. Registration form to register new club members
2. Search / Manage screen
	a. Retrieve data based on search parameters or retrieves all data 
		1. Search parameters include Occupation (AND/OR) Marital Status			
	b. Print preview and Print functionality provided to print report
	c. Export functionality to export to excel
	d. Update/Delete Social club members

External library used
---------------------
1. A light weight class library named "DataGridViewPrinter.dll" used for print functionality
(This library is taken from a open source project)

other details
---------------
a. Database "SocialClub.accdb" is located in application startup path (bin folder)
b. Database driver "Microsoft.ACE.OLEDB.12.0" used for Database communication

How to use the code
--------------------
1. Visual studio is installed
2. If yes, Open the solution file
3. Build Solution 
4. Run the application
	a. In case of exception, try changing the following in your machine and check if it runs
		1. Startup project -> properties -> build -> platform target -> x86
5. To Run Test Methods
	a. Test -> Run -> All Tests
		1. Test Explorer will show results
			a. No Test Explorer?
				1. Test -> Windows -> Test Explorer









		







 