# Grading-System-
Desktop application for manage grouping and marks of students, developed using C# and Windows Forms 

Only 4 students can be in a group. One student cannot be in two groups
"Display Mark for Group..." buttons calculates students marks and works like the following:
* Enter group mark, for example 100. 100 / 4 = 25. 
* Enter weighting for each student in the group (less than or equal to25)
* Marks are display for the students in the console


Three methods of adding students to groups:
* Adding one by one by selecting them from class list on the screen
* adding them in bulk ("Bulk-Assign To Groups" button)
* Manually adding ("Group2" button)

Buttons:
Import - imports class list from text file. Check Sample class list below
Exit- exists the application
Group2 - Open a new Window for adding students manually
Display Group... - Displays students in the group
Display Mark for Group... -- calculates students marks
Save Group... -- saves students in groups and their marks through serialization
Retrieve Group... -- retrieves students in groups and their marks through deserialization
Add Studnet-- lets add students manually


