; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Automated Food-Outlet System"
#define MyAppVersion "1.0.4.73"
#define MyAppPublisher "Vegatronix, Inc."
#define MyAppURL "http://www.vegatronix.com/"
#define MyAppExeName "Fast Food-Outlet System.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{77DC17C8-CFC4-4562-B9AD-599BD6937396}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\Vegatronix Food Outlet System
DisableProgramGroupPage=yes
OutputDir=C:\Users\Stanlry Brikkz\Desktop
OutputBaseFilename=Vegatronix Setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\Stanlry Brikkz\Documents\Visual Studio 2015\Projects\WindowsApplication2\WindowsApplication2\bin\Debug\Fast Food-Outlet System.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Stanlry Brikkz\Documents\Visual Studio 2015\Projects\WindowsApplication2\WindowsApplication2\bin\Debug\Fast Food-Outlet System.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Stanlry Brikkz\Documents\Visual Studio 2015\Projects\WindowsApplication2\WindowsApplication2\bin\Debug\Fast Food-Outlet System.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Stanlry Brikkz\Documents\Visual Studio 2015\Projects\WindowsApplication2\WindowsApplication2\bin\Debug\readme.txt"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
