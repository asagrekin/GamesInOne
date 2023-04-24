# Weekly status reports (Week 5)
#
## Team Report
### Backend:
Last Week's Goal: Be able to Anticipating and handle user errors.
Begin setting up a larger system to function with the database and front end.

Progress: Created a system to handle poor user inputs as well as a strong foundation to begin connecting to database and frontend.

High Level Goal: Begin to have a functioning interaction with the database. Storing, deleting, and retrieving games that are within the database.

### Frontend:
Last Week's Goal: work on handling user interactions for the front end. Look into how to communicate between C++ and C# code. Complete by April 19.

Progress: Created an add game screen to the UI, it is displayed when the user click on the "Add game" button.

High Level Goal: Application is able to create a new game row based on what has been entered by the user in the add game screen.

### Database:
Last Week's Goal: Initial database is working (can store platforms as objects in the database, and has a list of game and platform names).

Progress: Got databse working as a proof of concept. Issue is: I don't know what the backend and front end need stored in the databse, so I'm blocked on that, until I get more information.

High Level Goal: Get database working in context of app (i.e. meet requirements for what is stored based on back-end/front-end needs).

### Agenda for Project Meeting:
- Discuss current progress
- Discuss individual contribution
- Discuss about issues
- Discuss goal for next week
- Discuss revisions for Project Requirements (Living Doc) diliverable

## Contributions
### Leo & Kelby
Last week's goal:
- By April 19 we should be Anticipating and handling user errors.
Begin setting up a larger system to function with the database and front end.

Progress:
- Created two new methods to handle poor user inputs. The method called checkPath checks to make sure the inputted path is a valid path to execute. The method EnhancePath checks that the file is of type .exe and if it is it fixes the path to account for needed escape characters. Additionally, we created a way to take in user input and store it which accompilshes our goal of setting up a larger system to function with database and front end.

Issue:
- Ran into some varaible type issues when factoring code out of main into seperate methods. Simple fix was being more cautious when using string and making sure to use addresses of the strings' starts when referencing.

Goal for next week:
- By April 26 we plan to have a functioning interaction with the database. Storing, deleting, and retrieving games that are within the database.

### Asa
Last week's goal:
- Keep up with the deadlines.
- Get initial txt file database up and running so that it can store info.

Progress:
- Got a working proof of concept for the databse up.
- Added documentation to database.
- Got example code of how to use databse runing.
- Thought about next steps/ointigrating with back-end.

Issues:
- Blocked by lack of info for what needs to be stored in database/how it should be stored.

Goal for next week:
- Sync with back-end. Get info as needed for the database.
- Implement database to work with the back-end.
- Merge with back-end.

### Steven
Last week's goal:
- Continue to work on handling user interactions for the front end. Look into how to communicate between C++ and C# code. Complete by April 19.

Progress:
- Able to create multiple rows of game. Created an add game screen to the UI, looked into how to dispaly/remove new screen on the application based on button interactions. Look into how to communicate between C++ and C# code.


Issue:
- Was encountering issue of the text box not reacting as expecting.

Goal for next week: By April 26
- Application is able to create new game rows based on the infromation entered by the user
- Improve user interaction handling
- Allow user to add an image path (for the image in a game row)
