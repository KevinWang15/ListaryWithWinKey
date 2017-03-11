# Start [Listary](http://www.listary.com/) with Win key only
[Listary](http://www.listary.com/) is a powerful search utility for windows, similar to spotlight in Mac. 

It's a great software, but for people like me who are used to windows search (press <kbd>Win</kbd> and then type), listary's default shortcut <kbd>Ctrl+Ctrl</kbd> can be a little clumsy and it takes some time to get used to it. The software itself doesn't offer a way to set the shortcut to <kbd>Win</kbd> and replace the original windows menu, so I wrote a C# program to make it happen.

It's essentially a program that remaps <kbd>Win</kbd> to a hotkey that shows Listary toolbar, the remapping happens after <kbd>Win</kbd> is released so it doesn't interferes with other <kbd>Win</kbd>-related hotkeys such as <kbd>Win+D</kbd>. 

It uses a keyboard hook, so it may be reported by anti-virus software, and it requires administrator privileges, but it is an open-source software with only 100+ lines of code, so you can check the source code and be assured that it does nothing harmful.

# Download
https://github.com/KevinWang15/ListaryWithWinKey/releases

# How to use
1. Install and run [Listary](http://www.listary.com/).
2. Configure Listary, in ```Hotkeys```, optionally disable ```Press Ctrl twice to show/hide Listary``` (if you trigger it by mistake sometimes and hate it).
3. In ```Hotkeys```, configure ```Show Listary toolbar``` to <kbd>Ctrl+Shift+Alt+Win+F</kbd>. (press all five keys at the same time) (this is to make sure it doesn't conflict with other hotkeys, so that remapping <kbd>Win</kbd> to this hotkey will not have any side effect. If you don't like this shortcut, you can [modify the code.](https://github.com/KevinWang15/ListaryWithWinKey/blob/master/Program.cs#L44-L57))
4. Run the program ```ListaryWithWinKey.exe``` as Administrator (double click and it will ask for administrator privilege).
5. Press <kbd>Win</kbd> to open the launcher.
6. Press <kbd>Win</kbd> again to close it.

# How to disable it
Run ```Configurator.exe``` and click ```Stop```.

# How to make it start on boot
Run ```Configurator.exe``` and click ```Enable``` on ```Start on boot```.	

# Current state of the program
Tested on Windows 10 and it is working fine. More tests are needed. It is more a proof-of-concept than a reliable software. I also wish the devs of listary could see it and integrate the idea/code into their official release.

Pull requests and Issues are welcome.

# Special Thanks to
https://github.com/shanselman/babysmash/blob/master/KeyboardHook.cs
