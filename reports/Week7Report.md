# Weekly status reports (Week 7)
#
## Team Report
### Backend:
Last Week's Goal: Add unit testing to all elements. Fix any issues that arise with the back end when testing.

Progress: We now have new unit testing for all elements. This new testing has shed light on some errors with existing methods which we have fixed.

High Level Goal: Make changes based on Alpha Release feedback.

### Frontend:
Last Week's Goal: Fully integrate front and back end for Alpha release. Add more test cases.

Progress:
- Successfully integrated the front and back-end for Alpha release.
- Added test cases for the AddGameScreen.
- Added a default iamge path (our Logo image) as a place holder if the user do not have a image at the moment.

High Level Goal: Work on the custom ordering of the game list, refine UI.

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
Last week's goal: By May 9
- Fully integrate with backend for Alpha Release
- Add more test cases

Progress:
- Successfully integrated the front and back end.
- Image path is now optional, added default image path to our logo if not provided.
- Tested the building/running instructions with different people to ensure it is working as expected.
- Wrote AddScreen unit tests.

Issue:
- Was having trouble retrieving a list of dbObjects from backend due to struct and type differece. Solve by creating a functions to iterate through the list and returning it to front-end one by one.

Goal for next week: By May 16
- Add custom ordering of the list.
- Improve UI.
