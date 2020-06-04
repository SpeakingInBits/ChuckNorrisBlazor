# ChuckNorrisBlazor
Testing out a simple Blazor WebAssembly (WASM) app communicating with a Web API

## Hosted via Azure Static Web Apps
Instead of loading on a server with or without ASP.NET Core this app uses the new Azure Static Web App feature. 
https://azure.microsoft.com/en-us/services/app-service/static/

## Live Website
Check out the live website at https://witty-rock-0ee9aa81e.azurestaticapps.net/

## Blazor WASM initial issues
After publishing the client app an integrity check error was showing in the browser. See [issue #3](https://github.com/SpeakingInBits/ChuckNorrisBlazor/issues/3) for details.
A line was added in the .gitattributes file to not change line endings for files in the published folder. After the line was added in
.gitattributes the website had to be republished and it now deployed with GitHub Actions and the Azure Static Web Apps platform
