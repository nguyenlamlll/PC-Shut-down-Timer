## PC Shut Down Timer
--------------
This is an example of using a timer to Shut Down or Reboot your computer.




## Navigate Through Files
--------------

 - **Form1.cs**:  The testing user interface. It mainly calls the functions from ShutDownManager.cs
 - **ShutDownManager.cs**:  The "business" core of this example.
 - **TickEvents.cs**: Defines methods of shutting down/ rebooting. For example:

    System.Diagnostics.Process.Start("shutdown", "/s /t 0");

--------------
