# 使用Win键打开[Listary](http://www.listary.com/)
[Listary](http://www.listary.com/) 类似Mac中的Spotlight，是一款很强的Windows下的搜索与快速打开工具。 

但是它的默认快捷键<kbd>Ctrl+Ctrl</kbd>却不那么方便，有时这个快捷键会被误触，而且对于习惯按<kbd>Win</kbd>然后打字来搜索的人来说，这不太符合习惯。软件本身并没有使用<kbd>Win</kbd>作为快捷键的功能，所以我用C#写了个小程序提供这个功能。

这个程序实质上是把<kbd>Win</kbd>映射为打开Listary的快捷键。映射是在<kbd>Win</kbd>松开的时候进行的，所以不会影响别的快捷键，比如<kbd>Win+D</kbd>。这个程序使用了一个键盘钩子所以可能会被杀毒软件误报，以及它需要管理员权限。但这是一个只有一百多行的开源程序，所以你们可以检查代码，绝对安全。 

# 下载
https://github.com/KevinWang15/ListaryWithWinKey/releases

# 如何使用
1. 安装并运行[Listary](http://www.listary.com/)。
2. 设置Listary, 在```快捷键```中，你可以选择禁用掉```按下Ctrl两次以显示/隐藏Listary```(如果你经常误触)。
3. 在```快捷键```中, 把```显示 Listary 工具条```快捷键设置为<kbd>Ctrl+Shift+Alt+Win+F</kbd>. (五个键同时按) (这保证了这个快捷键不会和别的快捷键冲突，所以把<kbd>Win</kbd>映射过去不会有任何副作用。如果你不喜欢这个快捷键，你可以[修改代码](https://github.com/KevinWang15/ListaryWithWinKey/blob/master/Program.cs#L44-L57))。
4. 用管理员权限运行程序```ListaryWithWinKey.exe```(双击后会自动索要管理员权限)。
5. 按<kbd>Win</kbd>打开工具条。
6. 再按一次<kbd>Win</kbd>关闭工具条。

# 如何禁用此功能
运行```Configurator.exe```并点击```Stop```。

# 如何开机启用
运行```Configurator.exe```并在```Start on boot```中点击```Enable```。

# 特别感谢
https://github.com/shanselman/babysmash/blob/master/KeyboardHook.cs
