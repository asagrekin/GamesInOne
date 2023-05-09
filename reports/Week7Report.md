# Weekly status reports (Week 7)
#
## Team Report
### Backend:
Last Week's Goal: Add unit testing to all elements. Fix any issues that arise with the back end when testing.

Progress: We now have new unit testing for all elements. This new testing has shed light on some errors with existing methods which we have fixed.

High Level Goal: Make changes based on Alpha Release feedback.

### Frontend:
Last Week's Goal: Create connection with the back end, create file explorer for the add game screen.

Progress:
- Successfully added files explore for the user to locate game and image paths
- Created test framework for the front end using MSBuild
- Created a Github action for on push on my front-end branch

High Level Goal: Fully integrate front and back end for Alpha release. Add more test cases.

### Database:
Last Week's Goal: Fix any errors that arise.

Progress: No bugs arose, foused energy on other areas that needed more attention beofre Alpha Release. A couple of CI tests have been added for testing.

High Level Goal: Add more unit testing, and implement anything needed to respond to Alpha Release feedback.

### Agenda for Project Meeting:
- Discuss current progress
- Discuss individual contribution
- Discuss about issues
- Discuss goal for next week
- Discuss revisions for Project Requirements (Living Doc) diliverable

## Contributions
### Leo & Kelby
Last week's goal:
- By May 9 we plan to add unit testing to all elements. Fix any issues that arise with the back end when testing.

Progress:
- We now have new unit testing for all backend elements. 
- This new testing has shed light on some errors with existing methods which we have fixed.
- Biggest error came from our EnhancePath method where we made serious imporvements to the logic within it.

Issue:
- An issue we had was getting the Google Tests to recgonzie some of the work being conducted by the database such as the add functionality. 

Goal for next week:
- By May 16 we plan to make changes based on Alpha Release feedback.

### Asa
Last week's goal:
- Fix any bugs that show up.
- Help other teams with unit testing.

Progress:
- No bugs showed up with the database, so nothing needed to be done there.
- Worked a lot on the documentation for downloading and installing the app.

Issues:
- None

Goal for next week:
- Work on more CI tests.
- Work on a proper installer for the app.
- Respond to Alpha Release feedback.

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
