```markdown
# 🛠️ MergingPNG

A simple C# tool to merge multiple PNG images into a single, larger PNG.

Create spritesheets or combine images easily with this utility.

![License](https://img.shields.io/github/license/KrzysztofIwan/MergingPNG)
![GitHub stars](https://img.shields.io/github/stars/KrzysztofIwan/MergingPNG?style=social)
![GitHub forks](https://img.shields.io/github/forks/KrzysztofIwan/MergingPNG?style=social)
![GitHub issues](https://img.shields.io/github/issues/KrzysztofIwan/MergingPNG)
![GitHub pull requests](https://img.shields.io/github/issues-pr/KrzysztofIwan/MergingPNG)
![GitHub last commit](https://img.shields.io/github/last-commit/KrzysztofIwan/MergingPNG)

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-%235C2D91.svg?style=for-the-badge&logo=.net&logoColor=white)

## 📋 Table of Contents

- [About](#about)
- [Features](#features)
- [Demo](#demo)
- [Quick Start](#quick-start)
- [Installation](#installation)
- [Usage](#usage)
- [Configuration](#configuration)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [Testing](#testing)
- [Deployment](#deployment)
- [FAQ](#faq)
- [License](#license)
- [Support](#support)
- [Acknowledgments](#acknowledgments)

## About

MergingPNG is a C# command-line tool designed to simplify the process of combining multiple PNG images into a single PNG file. This tool is particularly useful for creating spritesheets for game development, combining image assets for web development, or simply merging images for archival purposes.

The primary goal of MergingPNG is to provide a fast, efficient, and easy-to-use solution for image merging. It handles various image sizes and formats, ensuring the final merged image maintains optimal quality. The tool is built using C# and leverages the .NET framework for image processing capabilities.

MergingPNG stands out by offering a simple command-line interface and cross-platform compatibility, making it accessible to developers on Windows, macOS, and Linux. Its lightweight design and minimal dependencies ensure it can be easily integrated into existing workflows and build processes.

## ✨ Features

- 🎯 **Image Merging**: Combines multiple PNG images into a single PNG.
- ⚡ **Performance**: Efficiently processes images, minimizing processing time.
- 🎨 **Customizable Layout**: Configurable options for arranging images in the merged output (horizontal, vertical, grid).
- 🛠️ **Command-Line Interface**: Easy-to-use command-line interface for quick execution.
- 📱 **Cross-Platform**: Compatible with Windows, macOS, and Linux.
- ⚙️ **Configuration Options**: Allows setting output path, layout type, and padding between images.

## 🎬 Demo

Since this is a command-line tool, a live demo is not applicable. Here are some example screenshots demonstrating usage:

### Screenshots

![Command-Line Usage](screenshots/command-line-usage.png)
*Example of running the tool with various command-line arguments.*

![Output Image](screenshots/output-image.png)
*Resulting merged PNG image.*

## 🚀 Quick Start

Clone and run the tool in a few steps:

```bash
git clone https://github.com/KrzysztofIwan/MergingPNG.git
cd MergingPNG
dotnet build
dotnet run --project MergingPNG.csproj -- -i "path/to/images/*.png" -o "output.png"
```

Replace `"path/to/images/*.png"` with the actual path to your PNG images and `"output.png"` with the desired output file name.

## 📦 Installation

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/en-us/download) (version 6.0 or higher)
- Git

### From Source

```bash
# Clone repository
git clone https://github.com/KrzysztofIwan/MergingPNG.git
cd MergingPNG

# Build project
dotnet build
```

## 💻 Usage

### Basic Usage

To merge all PNG images in a directory into a single output file:

```bash
dotnet run --project MergingPNG.csproj -- -i "path/to/images/*.png" -o "output.png"
```

### Advanced Examples

To specify a different layout (e.g., vertical):

```bash
dotnet run --project MergingPNG.csproj -- -i "path/to/images/*.png" -o "output.png" -l vertical
```

To add padding between images:

```bash
dotnet run --project MergingPNG.csproj -- -i "path/to/images/*.png" -o "output.png" -p 10
```

### CLI Options

- `-i` or `--input`: Input path to PNG images (supports wildcards).
- `-o` or `--output`: Output file path for the merged PNG.
- `-l` or `--layout`: Layout type (horizontal, vertical, grid). Default is horizontal.
- `-p` or `--padding`: Padding in pixels between images. Default is 0.

## ⚙️ Configuration

The tool can be configured through command-line arguments.  No external configuration files are used.

### Environment Variables
No environment variables are used.

## 📁 Project Structure

```
MergingPNG/
├── 📁 src/
│   ├── 📄 MergingPNG.csproj     # Project file
│   ├── 📄 Program.cs            # Main application logic
│   └── 📄 ImageMerger.cs       # Image merging logic
├── 📄 .gitignore              # Git ignore rules
├── 📄 README.md               # Project documentation
└── 📄 LICENSE                 # License file
```

## 🤝 Contributing

We welcome contributions! Please see our [Contributing Guide](CONTRIBUTING.md) (not yet created, but will be) for details.

### Quick Contribution Steps

1. 🍴 Fork the repository
2. 🌟 Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. ✅ Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. 📤 Push to the branch (`git push origin feature/AmazingFeature`)
5. 🔃 Open a Pull Request

### Development Setup

```bash
# Fork and clone the repo
git clone https://github.com/yourusername/MergingPNG.git

# Navigate to the project directory
cd MergingPNG

# Build the project
dotnet build
```

### Code Style

- Follow existing code conventions
- Use meaningful variable and function names
- Add comments where necessary

## Testing

To run tests (if any were implemented):

```bash
dotnet test
```

## Deployment

The tool can be deployed as a standalone executable. After building, the executable can be found in the `bin/Debug` or `bin/Release` directory.

## FAQ

**Q: What image formats are supported?**

A: Currently, only PNG images are supported.

**Q: Can I specify the order of images to be merged?**

A: The images are merged in the order they are found in the input directory.  To control the order, rename the files appropriately.

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

### License Summary

- ✅ Commercial use
- ✅ Modification
- ✅ Distribution
- ✅ Private use
- ❌ Liability
- ❌ Warranty

## 🙏 Acknowledgments

- 📚 **Libraries used**:
  - [System.Drawing.Common](https://www.nuget.org/packages/System.Drawing.Common/) - Used for image processing.
```
