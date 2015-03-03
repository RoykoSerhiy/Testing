Run("notepad.exe")
WinWaitActive("[CLASS:Notepad]")
Send("Hello from Notepad.{ENTER}")
WinClose("[CLASS:Notepad]")
WinWaitActive("[CLASS:#32770]")

Send("{ENTER}")
WinWaitActive("Сохранить как")
Send("C:\Users\Serhiy\Desktop\Text{Enter}")

WinWaitClose("[CLASS:Notepad]")


