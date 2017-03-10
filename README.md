# Start [Listary](http://www.listary.com/) with Win key only
[Listary](http://www.listary.com/) is a powerful search utility for windows, similar to spotlight in Mac. 

It's a great software, but for people like me who are used to windows search (press <kbd>Win</kbd> and then type), listary's default shortcut <kbd>Ctrl+Ctrl</kbd> can be a little clumsy and it takes some time to get used to it. The software itself doesn't offer a way to set the shortcut to <kbd>Win</kbd> and replace the original windows menu, so I wrote a C# program to make it happen.

It's essentially a program that remaps <kbd>Win</kbd> to <kbd>Ctrl+Ctrl</kbd>, the remapping happens after <kbd>Win</kbd> is released so it doesn't interferes with other <kbd>Win</kbd>-related hotkeys such as <kbd>Win+D</kbd>. 

It uses a keyboard hook, so it may be reported by anti-virus software, but it is an open-source software with only 100+ lines of code, so you can check the source code and be assured that it does nothing harmful.

# How to use
1. Make sure <kbd>Win+J</kbd> is not bound to any hotkey (required due to some technical issues explained in the code). If it is, either change the hotkey or modify the code to another <kbd>Win+...</kbd> that is not bound to any hotkey.
2. Make sure you have [Listary](http://www.listary.com/) installed and the default shortcut <kbd>Ctrl+Ctrl</kbd> enabled.
3. Run the program ```ListaryWithWinKey.exe```.
4. Press <kbd>Win</kbd> to see if it works.
5. If you wish to open the original Windows menu, either click on the left-bottom corner of your screen or press <kbd>Win</kbd> twice.

# How to disable it
Remapping is done when the program ```ListaryWithWinKey.exe``` is running. To disable it, simply use task manager to kill the process ```ListaryWithWinKey.exe```.

# How to make it start on boot
Copy the program ```ListaryWithWinKey.exe``` to ```C:\Users\Username\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup``` (replace ```Username``` with your user name) as explained [in this web page](!http://tunecomp.net/add-app-to-startup/).

# Current state of the program
Tested on Windows 10 and it is working fine. More tests are needed. It is more a proof-of-concept than a reliable software. I also wish the devs of listary could see it and integrate the idea/code into their official release.

Pull requests and Issues are welcome.

# Special Thanks to
https://github.com/shanselman/babysmash/blob/master/KeyboardHook.cs
