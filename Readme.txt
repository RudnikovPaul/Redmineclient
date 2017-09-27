Redmine Client version 1.0

just some statements:
1. This client works in two modes: Online and Offline.

Online:
	1. When the app is started it automatically checks servers availability and applies the last written
	authentification settings to authentificate.
	2. After succesfull authentification the client downloads the task list from the server.
		a. If there wher some commits made in offline mode, you will be asked to send them to the server.
	3. On app start you click on a task and click the button 'start'. the time will start logging.
	4. After finishing the task you need to click on the button 'commit' to commit the issue, or on the
	button 'reset' to reset the timer.
		a. If you press the button 'reset' or accedently close the application, your time spent will not 
		be lost. It will be added to the overall time, when you will commit the task the next time.

Offline:
	1. When the app starts it picks up the tasks from the local storage and shows them to you.
	2. You start working with a task by clicking the button 'start'.
	3. After pressing the button 'commit' your time will be committing localy.
		a. If you press the button 'reset' or accedently close the application, your time spent will not 
		be lost. It will be added to the overall time, when you will commit the task the next time.

some else statements:
1. The app has two authentification modes: by login/password and by API key.
2. Double clicking the task in the list opens the edit window.
3. The issues can be sorted by all columns.