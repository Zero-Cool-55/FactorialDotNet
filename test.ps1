dotnet run
if($LastExitCode -eq 0){
    Write-Host "Execution succeeded"
} else {
    Write-Host "Execution failed"
}
Write-Host "Return value - " $LastExitCode