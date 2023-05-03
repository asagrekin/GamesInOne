# Weekly status reports (Week 6)
#
## Team Report
### Backend:
Last Week's Goal: Begin to have a functioning interaction with the database. Storing, deleting, and retrieving games that are within the database.

Progress: We now have a functioning interaction with the database. Storing, deleting, and retrieving games that are within the database.

High Level Goal: Functioning interaction with the front end. Displaying, filtering, and sorting games based on user inputs.

### Frontend:
Last Week's Goal: Create connection with the back end, create file explorer for the add game screen.

Progress:
- Successfully added files explore for the user to locate game and image paths
- Created test framework for the front end using MSBuild
- Created a Github action for on push on my front-end branch

High Level Goal: Fully integrate front and back end for Alpha release. Add more test cases.

### Database:
Last Week's Goal: Finalize the database (deals with errors in saving robustly, stores data efficiently, etc). Also, any additional features needed for the front end get added.

Progress: Revamped the database to deal with front-end needs better. Got it fully up and running, and merged with back-end again. Also worked on CI testing integration.

High Level Goal: Fix any errors that arise.

### Agenda for Project Meeting:
- Discuss current progress
- Discuss individual contribution
- Discuss about issues
- Discuss goal for next week
- Discuss revisions for Project Requirements (Living Doc) diliverable

## Contributions
### Leo & Kelby
Last week's goal:
- By April 26 we should begin to have a functioning interaction with the database. Storing, deleting, and retrieving games that are within the database.

Progress:
- We now have a functioning interaction with the database. Storing, deleting, and retrieving games that are within the database.
- Created a new Make File for our original launcher files.

Issue:
- An issue was integrating the database with the backend. This issue was resolved and the only other issue was not being able to delete a game from the database. 

Goal for next week:
- By May 3 we plan to have functioning interaction with the front end. Displaying, filtering, and sorting games based on user inputs.

### Asa
Last week's goal:
- Deal with any errors that arise in database use.
- Add features as needed for front end.

Progress:
- Refactored/revamped database.
- Started working on unit testing and CI.

Issues:
- None

Goal for next week:
- Fix any bugs that show up.
- Help other teams with unit testing.

### Steven
Last week's goal: By May 3
- Make connection with the back end, create the DLL project.
- Add file explorer for the Add Game Screen so the user do not have to type the path.

Progress:
- Added File explorer to the add game screen
- Researched on options of testing frameworks for front-end C#
- DEcided on using MSTest, as it already included in VIsual Studio, allowing easier build and access. MSBuild allow easy reference of different components within my interface.

Issue:
- Was having difficulties setting up the CI for that framework. (Solved)

Goal for next week: By May 9
- Fully integrate with backend for Alpha Release
- Add more test cases
