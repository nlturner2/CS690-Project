# Capstone team projects tracking system
## User Manual

## Home Dashboard:
![Home Dashboard](https://github.com/nlturner2/CS690-Project/blob/master/HomeDashboard.PNG)

Home Dashboard is the main page of the application, it has features of adding a team, removing a team, refreshing the page, viewing the team list, viewing notifications of teams, dismissing notifications and also settings for the notification. 
### Add a team:

How to:

![add Team](https://github.com/nlturner2/CS690-Project/blob/master/addTeam.png)

1. click on the “Add Team” button ![add Team Button](https://github.com/nlturner2/CS690-Project/blob/master/AddTeamButton.png) on the top of the Home Dashboard, the add team window will pop up.
2. Insert the team’s name in the textbox under “team name”, and Insert the team’s github URL in the textBox under “Github URL:”.
3. Click on “Add” button on the bottom to add the team, or click on “Cancel” button to cancel the operation. 


### Remove a Team:


![Remove Team](https://github.com/nlturner2/CS690-Project/blob/master/removeTeam.PNG)


1. Click on the "Remove Team" button ![remove Team Button](https://github.com/nlturner2/CS690-Project/blob/master/RemoveTeamButton.png)on the top of the Home Dashboard, the remove team window will show up.
2. Insert the team's name in the text box and click on the "Remove" button to remove the team.


### View Team List:

1. All the teams that has been added will be shown on the team list, each team is shown as a button, when you click on the team, it will go to the team dashboard of this team. 
2. If there are notifiations from a team, icons will show up in the top of the right corner of team button. There are four different icons. ![commit Iron](https://github.com/nlturner2/CS690-Project/blob/master/commitIron.png) means that the team has not committed for a number of days(based on the user's setting). ![meeting icon](https://github.com/nlturner2/CS690-Project/blob/master/MeetingIcon.png) means that the team did not meet in the past number of weeks(based on the user's setting). ![standard icon](https://github.com/nlturner2/CS690-Project/blob/master/StandardIcon.png) means that the team is not following the standard format in their files. ![multiple icons](https://github.com/nlturner2/CS690-Project/blob/master/multipleIcon.png) means that the team has more than one notifications.

### Manage notifications:

1. All the notificaitons about the teams will be shown on the right side of the Home Dashboard. 
2. Dismiss notifications: click on the "X" button on the right corner of each notification will dimiss the notification. 
  a. When you dismiss a "did not meet" notification, the notification will not show up until the number of weeks (based on the user's setting).
  b. when you dismiss a "did not commit" notification, the notification will not show up until the number of days(based on the user's setting).
  c. when you dimiss a "not following the standard" notification, the notification will show up when you refresh the page or reopen the application, unless the team fixed the format of files. 
 
 ### Setting:
 ![settings](https://github.com/nlturner2/CS690-Project/blob/master/settings.PNG)
 
 1. click on the setting button ![setting button](https://github.com/nlturner2/CS690-Project/blob/master/Setting.png)in the top right corner, the setting window will show up. 
 2. in the settnigs window, insert number of days in the text box following "Member Notification", and then click "Save" button to save the setting. 
 3. In the settings window, insert number of weeks in the text box following "Team Notification", and ten click "Save" button to save the setting. 
 4. The number enter has to be a integer larger than 0, any other input will cause a warning.


## Team Dashboard

![Summary](https://github.com/nlturner2/CS690-Project/blob/master/summary.PNG)

1. When you click on one of the team, it will go to Team Dashboard. The summary of the team's project will show up as default. The content of the summary is from the team's README file of project repository.
2. In the top right corner of the Team Dashboard, there is a "Home" button. When you click on the "Home" button, it will go back to the Home Dashboard. 

### View Members and member notification:

![TeamDashboard](https://github.com/nlturner2/CS690-Project/blob/master/TeamDashboard.PNG)


1. On the Team Dashboard, click on "Members" in the menu bar on the top of the page. List of all the members' github username of a team will show up in the text box below. 
2. on the right side of the page, a notification section will show the commit notification of team members. If a team member did not commit in the past number of days(based on the user's setting), a notification of "xxx(member) did not commit" will show up in the notification section. 
3. When you click on the "X" button in the top right corner of each notification, that notification will be dismissed. That notification will not show up until number of days(based on the user's setting).

### View Team Meeting Files

![TeamMeeting](https://github.com/nlturner2/CS690-Project/blob/master/TeamMeeting.PNG)

1. On the Team Dashboard, click on "Team Meeting" in the menu bar on the top of the page, the latest meeting minutes file will show up in the rich text box below the menu bar. 
2. on the right side of the page, in the list box, a list of all the meeting minutes files will be displayed from the latest to the oldest date. If the team has a team template file, it will be shown in the bottom of the list. 
3. when you click on each of the file that is displayed in the list box, the content of the meeting minutes file will show up in the rich text box in the middle of the page. 

### View Weekly Progress

![WeeklyProgress](https://github.com/nlturner2/CS690-Project/blob/master/weeklyProgress.PNG)


1. On the Team Dashboard, click on "Weekly Progress" in the menu bar on the top of the page, weekly progress details according to the commit history on the github repository of the team will show up. 
2. It includes time, name of the person who commited and commit description of all the commits that has been made for the repository.


### Notes

![notes](https://github.com/nlturner2/CS690-Project/blob/master/notes.PNG)

1. On the Team Dashboard, click on "notes" in the menu bar on the top of the page, a text box will show up. User can write notes in the text box and click on the "save” button on the right side of the page to save the note. 
2. When the note is created and saved, the note will stay on the note page.
