$client = new-object System.Net.WebClient
$client.DownloadFile("https://nuget.org/nuget.exe","nuget.exe")