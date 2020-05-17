using System.Resources;
using System.Reflection;
using System.Runtime.InteropServices;
using MelonLoader;

[assembly: AssemblyTitle(Freeze_Manipulator.BuildInfo.Name)]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(Freeze_Manipulator.BuildInfo.Company)]
[assembly: AssemblyProduct(Freeze_Manipulator.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + Freeze_Manipulator.BuildInfo.Author)]
[assembly: AssemblyTrademark(Freeze_Manipulator.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
//[assembly: Guid("")]
[assembly: AssemblyVersion(Freeze_Manipulator.BuildInfo.Version)]
[assembly: AssemblyFileVersion(Freeze_Manipulator.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonModInfo(typeof(Freeze_Manipulator.Freeze_Manipulator), Freeze_Manipulator.BuildInfo.Name, Freeze_Manipulator.BuildInfo.Version, Freeze_Manipulator.BuildInfo.Author, Freeze_Manipulator.BuildInfo.DownloadLink)]


// Create and Setup a MelonModGame to mark a Mod as Universal or Compatible with specific Games.
// If no MelonModGameAttribute is found or any of the Values for any MelonModGame on the Mod is null or empty it will be assumed the Mod is Universal.
// Values for MelonModGame can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonModGame(null, null)]