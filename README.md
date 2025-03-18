## Elden Ring Death Counter

# Overview

Elden Ring Death Counter is a Windows Forms application designed to automatically detect and count player deaths in Elden Ring games. The application uses OCR (Optical Character Recognition) via Tesseract to detect death messages on the screen and maintain a death count.
This project was made at the release of the game where no anti cheat disable mod were available or for people that want a death counter without disabling the anti cheat of the game.

# Features

- Automatic Death Detection: Uses OCR to detect the "YOU DIED" screen in Elden Ring.

- Death Counter: Tracks both total deaths and daily deaths.

- Manual Adjustments: Users can manually increase or decrease the death count.

- Screen Capture: Captures a portion of the screen to analyze text.

- File Storage: Saves death counts in local text files.

- Background Processing: Runs in the background using BackgroundWorker.

- User Interface: Simple and functional UI to control the counter.

- Logs: Debug mode logs OCR results.

# Usage

1. Start the Program: Click the "Launch Program" button.

2. Stop the Program: Click the "Stop" button.

3. View Death Count: The UI displays the current session's deaths and total deaths.

4. Manually Adjust Count: Use the + and - buttons to modify counts.

5. Reset Daily Deaths: Click the reset button.

6. Take a Screenshot: Manually capture a screen to check the detected text.

7. Open Logs/Folder: View logs or open the data folder.

8. Exit: Click the "Terminate" button to close the application.

# File Structure

- D:\DeathCounter\
 - ├── Capture.bmp      # Latest screenshot for OCR analysis
 - ├── Deaths.txt       # Total death count
 - ├── TodayDeaths.txt  # Death count for the current session
 - ├── Logs.txt         # Debug logs (only in debug mode)

# Known Issues

- False Negatives: OCR may misread text under certain conditions.

- Performance Impact: The application continuously captures and processes images, which may impact system performance.

- Multi-Monitor Issues: The capture region is currently set to the primary screen.
