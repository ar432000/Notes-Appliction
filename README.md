# Notes Application

A cross-platform notes application built with **.NET MAUI**, providing a seamless note-taking experience on Android devices.

## Overview

This application allows users to create, edit, and manage notes with a clean and intuitive user interface. Built using .NET MAUI, it leverages modern cross-platform development practices to deliver a native-like experience on Android.

## Features

- 📝 **Create Notes** - Easily create and organize your thoughts and ideas.
- ✏️ **Edit Notes** - Modify existing notes with a simple tap.
- 🗑️ **Delete Notes** - Remove notes you no longer need.
- 💾 **Local Storage** - Notes are stored locally on your device.
- 🎨 **Clean UI** - Intuitive and user-friendly interface.
- ⚡ **Fast Performance** - Optimized for smooth operation.

## Prerequisites

Before you begin, ensure you have the following installed:

- **.NET 8 SDK** - [Download](https://dotnet.microsoft.com/download)
- **Visual Studio 2022** - Community edition or higher with MAUI workload.
- **Android SDK** - Installed via Visual Studio.
- **Git** - For cloning the repository.

### Required Workloads

To develop for .NET MAUI, install the following workload:

```bash
dotnet workload install maui
```

## Getting Started

### Clone the Repository

```bash
git clone https://github.com/ar432000/Notes-Appliction.git
cd Application1
```

### Build the Application

To build the Android application:

```bash
dotnet build -f net8.0-android
```

### Run on Android Device/Emulator

```bash
dotnet run -f net8.0-android
```

Alternatively, using Visual Studio:
1. Open `Application1.csproj` in Visual Studio 2022.
2. Select an Android emulator or connected device from the debug target dropdown.
3. Press `F5` or click **Run**.

## Project Structure

```plaintext
Application1/
├── Resources/          # Application resources
│   ├── AppIcon/       # App icons
│   ├── Splash/        # Splash screen
│   ├── Images/        # Image assets
│   └── Fonts/         # Custom fonts
├── MauiProgram.cs     # MAUI app configuration
├── App.xaml           # Application-level resources
├── AppShell.xaml      # Shell navigation structure
└── Pages/             # Application pages and views
```

## Technology Stack

- **Framework**: .NET MAUI
- **.NET Version**: .NET 8
- **Target Platform**: Android 21.0 and above
- **Language**: C#
- **UI Framework**: MAUI with XAML

## Development

### Application Configuration

The app is configured with the following settings:

- **App ID**: `com.companyname.application1`
- **Display Version**: 1.0
- **Minimum Android API Level**: 21
- **Target Framework**: `net8.0-android`

### Building and Debugging

- **Debug Mode**: Press `F5` in Visual Studio to debug with breakpoints.
- **Release Build**: Use `dotnet build -c Release -f net8.0-android` for production builds.

## Requirements

### System Requirements

- **OS**: Windows 10 or later (for development).
- **RAM**: 8 GB minimum (16 GB recommended).
- **Disk Space**: At least 5 GB free.

### Android Requirements

- **Minimum API Level**: 21 (Android 5.0).
- **Target API Level**: Latest stable.

## Troubleshooting

### MAUI Workload Not Found

If you encounter issues with the MAUI workload, run:

```bash
dotnet workload restore
```

### Build Failures

If you experience build failures, follow these steps:

1. Clean the project:
   ```bash
   dotnet clean -f net8.0-android
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

3. Rebuild:
   ```bash
   dotnet build -f net8.0-android
   ```

### Emulator Issues

- Ensure the Android emulator is running before deploying.
- Check Android SDK installation through Visual Studio's SDK Manager.

## Contributing

Contributions are welcome! Please feel free to submit pull requests or open issues for bugs and feature requests.

## License

This project is open source and available under the MIT License.

## Support

For issues, questions, or suggestions, please open an issue on the [GitHub repository](https://github.com/ar432000/Notes-Appliction/issues).

## Resources

- [.NET MAUI Documentation](https://learn.microsoft.com/en-us/dotnet/maui/)
- [.NET 8 Release Notes](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-8)
- [Android Developer Guide](https://developer.android.com/guide)
- [GitHub Copilot Documentation](https://docs.github.com/en/copilot)