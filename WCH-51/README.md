# .NET Command Line Solution

## Primary Challenge
Here are the steps to run in PowerShell or the command line option of your choice to complete the primary challenge (make sure you are in the directory where you want your solution to live):

1. dotnet new sln -n "WeeklyChallengeApp"
2. dotnet new webapp -n "ChallengeWeb"
3. dotnet new classlib -n "ChallengeLib"
4. dotnet sln WeeklyChallengeApp.sln add ChallengeWeb/ChallengeWeb.csproj
5. dotnet sln WeeklyChallengeApp.sln add ChallengeLib/ChallengeLib.csproj
6. dotnet add ChallengeWeb/ChallengeWeb.csproj reference ChallengeLib/ChallengeLib.csproj

## Bonus Challenge
To complete the bonus challenge, you will most likely need to install the NuGet packages for the project templates and the item templates. I have included them in the source code zip file, but if you would like to check on the latest versions, go to https://github.com/Azure/azure-functions-templates/wiki/Using-the-templates-directly-via-dotnet-new  

Here are the steps to run in PowerShell or the command line option of your choice to complete the bonus challenge (make sure you are in the directory where you want your solution to live):

1. dotnet new -i "C:\Temp\projecttemplates.nupkg"
2. dotnet new -i "C:\Temp\itemtemplates.nupkg"
3. dotnet new sln -n "WeeklyChallengeBonusApp"
4. mkdir TimerFunction
5. cd TimerFunction
6. dotnet new func -n "TimerFunction"
7. dotnet new timer -n "TimerFunction"
8. cd ..
9. dotnet sln WeeklyChallengeBonusApp.sln add TimerFunction/TimerFunction.csproj