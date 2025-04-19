## 📋 Prerequisites

Ensure you have the following tools and configurations set up before diving into the implementation:

- ✅ **.NET SDK 9 Preview** or higher  
  Make sure you’ve installed the preview version of .NET 9 from the official [.NET downloads](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) page.

- ✅ **Visual Studio 2022/2025 Preview**  
  With support for .NET 9 and C# 13 (ensure `.NET 9` is selected during installation via the Visual Studio Installer).

- ✅ **Git**  
  For cloning and managing the repository version control.
  
- ✅ **Basic understanding of C# and .NET Core concepts**  
  This will help you grasp the new C# 13 features faster and integrate them efficiently into real-world apps.

  ## 📌 What This PoC Covers

This PoC covers following C# 13 features.

### 🧪 Implemented Features

Each of the following features has a code sample in the corresponding `.cs` file:

| File Name | Feature |
|-----------|---------|
| `EscapeSequence.cs` | Modern escape sequences |
| `ImplicitIndexAccess.cs` | Implicit index access (`[^]`) |
| `Locks.cs` | Improved locking mechanisms |
| `ParamsCollection.cs` | `params Span<T>` and collection expressions |
| `PartialProperties.cs` | Partial property declarations |
| `SearchValues.cs` | Enhancement in `SearchValues<T>` |
| `UUIDGeneration.cs` | UUID generation improvements |
| `WhenEach.cs` | New `Task.WhenEach()` |

### 📚 Other Features

These features are not easily demoed in isolation but are explained in this README with use cases and context:

- **Method Group Natural Type Improvements**  
This feature optimizes how the compiler handles method groups (a method and its overloads). Previously, it considered all overloads to determine the best match. Now, it simplifies the process by improving overload resolution, making it more efficient.

- **Ref Struct Types Can Implement Interfaces**  
  Previously disallowed, `ref struct` can now implement interfaces for more flexible design.

- **Overload Resolution Priority**  
  Developers can now hint to the compiler which method overload is preferred when multiple matches exist.

  ## 🛠️ How to Implement the Solution

1. **Clone the Repository**
   ```bash
   git clone "repo-link"
   cd csharp13-features-demo
2. Open the project in your preferred C# IDE (e.g., Visual Studio, Visual Studio Code).
3. Navigate to the individual feature file (e.g., `EscapeSequence.cs`) to see the implementation of the specific feature.
4. `Program.cs`: The main entry point of the program, which executes the features.
  

