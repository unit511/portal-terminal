# Portal themed Windows Terminal

To set the profile you need to paste the contents of settings.txt into the Windows Terminal settings file (can be accessed by clicking on settings in the dropdown menu) between 2 already existing profiles.
After saving the edits you made to the settings.json, in the dropdown menu you will see an "Aperture Science CMD" option, by selecting it you can load the newly created profile.

If you do not want tu run a script at startup you can modify the following line in the settings

"commandline": "C:/Terminal/startup.bat",

To look like this:

"commandline": "cmd.exe /K \"echo Your simple message here\"",

or without a message:

"commandline": "cmd.exe",

For the startup message to run you need to create a folder named "Terminal" on your C: drive (or anywhere, but you will have to edit the file paths). 
Paste the .bat, .exe and if you want a custom logo the .png file into said folder.

If you'd like to modify the C# script you can clone this repository in Visual Studio or paste the contents of Program.cs into a new project.
To run a different script you need to modify the .bat to open up your script instead of logoprint.exe
