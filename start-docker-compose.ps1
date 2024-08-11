# Enable error handling
$ErrorActionPreference = "Stop"

try {
    # RUN Web-App
    docker-compose up --build
} catch {
    Write-Host "An error occurred: $_"
} finally {
    # Wait for user input before closing the window
    Read-Host -Prompt "Press Enter to exit"
}
