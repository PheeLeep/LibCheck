# LibCheck
LibCheck is an open source library book borrowing and returning software that gives a librarian an ease of use and manage of books and records.

## Disclaimer
This is an unstable phase and there are many changes will occur in the future.

## Notice (For Developers)
- Please uncheck **'Common Language Runtime Exceptions'** in the Exception Settings (`Ctrl+Alt+E`), before you start debugging.
  - The reason is where the program hangs while in the Secure Desktop mode as the debugger breaks when detected an error (even it's inside the try-block).
  - If the scenario occurs, invoke the 'Ctrl+Alt+Delete' and perform a restart. **(This will lose your data.)**

## Build
**NOTE:** It requires Visual Studio 2022 with .NET 7 SDK to build a program.

To build a program:
1. Download this repo or pull it through command line:
   ```cmd
   git pull https://github.com/PheeLeep/LibCheck
   ```
2. Go to the folder where you downloaded the source code.
3. Double-click `LibCheck.sln` inside the source code folder and start coding.
4. Once done, perform debugging by pressing `F5` on the keyboard.
