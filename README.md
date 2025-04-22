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

  ## 📌 What's New in C# 13

C# 13, released in November 2024 alongside .NET 9, introduces several enhancements aimed at improving code clarity, performance, and developer productivity. Key highlights include:

- **New escape sequence (`\e`)**: Introducing a new escape character for better readability.
- **Implicit Index Access**: Allows simplified syntax for accessing array elements from the end.
- **New `Lock` object**: Providing a modern approach to thread synchronization.
- **Enhanced `params` collections**: Allowing `params` to work with various collection types beyond arrays.
- **Partial properties and indexers**: Enabling more flexible code generation and maintenance.
- **Search Value improvements**: Enhancement in `SearchValues<T>`
- **UUID Generation**: UUID generation improvements
- **Task.WhenEach**: Run multiple tasks and process their results individually as they complete.
- **Method group natural type improvements**: Enhancing type inference for method groups.
- **Overload resolution priority**: Allowing developers to specify preferred method overloads.
- **Field Keyword**: Makes accessing and modifying the backing field easier and cleaner
- **Support for `ref struct` types in interfaces and generics**: Expanding the usability of `ref struct` types.
- **Support for `ref` and `unsafe` in async methods and iterators**: Allowing more scenarios for performance-critical code.

  ## 📌 Let's explore all the features one by one
### 1. Escape Sequence (`\e`):
The new escape sequence `\e` introduced in C# 13 represents the ASCII escape character (`U+001B`). It is commonly used for terminal control codes, such as coloring console output. Previously, this character had to be inserted using Unicode or numeric escape syntax. Now, `\e` provides a more readable and concise way to include it in strings.
  
![carbon](https://github.com/user-attachments/assets/95f7dd0a-dccc-4853-9b8e-4623182d8a99)

- Click for demo: [EscapeSequence.cs](./C%2313/EscapeSequence.cs)

### 2. Implicit Index Access [^]:
It is a new feature in C# 13 that allows you to access the last elements of an array or list using the [^] syntax more intuitively. Instead of writing array[array.Length - 1], you can now simply write array[^1] to get the last item. This improves code readability and reduces chances of off-by-one errors, especially in collections.
  
![carbon (1)](https://github.com/user-attachments/assets/32670580-6717-4597-af7a-45220addb17c)

- Click for demo: [ImplicitIndexAccess.cs](./C%2313/ImplicitIndexAccess.cs)

 ### 3. Locks :
A new System.Threading.Lock type has been introduced as a modern alternative to the traditional lock keyword. It provides a more flexible and safer way to manage synchronization in multithreaded applications. Unlike the lock statement, it supports async/await patterns and offers explicit control over lock acquisition and release through a disposable scope. This makes it especially useful in asynchronous or complex locking scenarios.
  
![carbon (2)](https://github.com/user-attachments/assets/46560b18-464a-494b-86f3-3639ef5dc181)

- Click for demo: [Locks.cs](./C%2313/Locks.cs)

 ### 4. Params Collection:
It enhances the params keyword by allowing it to work with collection expressions like Span<T>, List<T>, or even array literals using the [..] syntax. This improvement removes the limitation of params only accepting arrays, making method calls cleaner and more flexible.
  
![carbon (3)](https://github.com/user-attachments/assets/14fe7302-dd2c-40f8-9c90-b77691eb5010)

- Click for demo: [ParamsCollection.cs](./C%2313/ParamsCollection.cs)

 ### 5. Partial Properties:
C# 13 introduces partial properties, allowing you to split the definition of a property across multiple parts of a partial class. This is especially useful in scenarios like source generators or large projects where different aspects of a property (e.g., getter, setter, attributes) are defined in separate files. It improves modularity and maintainability without breaking the property declaration pattern.
  
![carbon (4)](https://github.com/user-attachments/assets/a0efac80-8615-4ed0-ad19-fb0f2a7fc838)

- Click for demo: [PartialProperties.cs](./C%2313/PartialProperties.cs)

 ### 6. Search Values:
In earlier versions of C#, searching values typically worked with characters or bytes. However, in C# 13, this functionality has been extended to support string types as well, allowing for more flexible and efficient searches within text-based data.
  
![carbon (5)](https://github.com/user-attachments/assets/19702b40-838b-4265-a7c3-94f3a36c12fa)

- Click for demo: [SearchValues.cs](./C%2313/SearchValues.cs)

 ### 7. UUID Generation:
The UUIDGeneration class introduces a new internal method for UUID generation, which eliminates the need for external libraries. Previously, developers relied on external libraries for GUID generation, typically using Guid.NewGuid() to create a version 4 UUID. With C# 13, the Guid.CreateVersion7() method is introduced, which generates a version 7 UUID directly within the .NET library, offering a timestamp-based UUID for better traceability. Additionally, the method allows you to provide a custom timestamp using TimeProvider.System.GetUtcNow(), enabling more precise UUID creation.
 
![carbon (6)](https://github.com/user-attachments/assets/e51beeab-8a93-46f5-95a9-2be7b1fa7096)

- Click for demo: [UUIDGeneration.cs](./C%2313/UUIDGeneration.cs)

 ### 8. Task.WhenEach():
The Task.WhenEach method allows us to iterate through tasks as they complete, without having to call Task.WaitAny repeatedly in order to select the next task that completes. Task.WhenEach will be beneficial particularly in scenarios where you are waiting for tasks that differ in their execution times.
 
![carbon (7)](https://github.com/user-attachments/assets/8cb801eb-988c-4940-943e-58ee18615656)

- Click for demo: [WhenEach.cs](./C%2313/WhenEach.cs)

### 9. Method group natural type:
This feature improves how the compiler handles method groups, which consist of a method and all its overloads with the same name. In the past, the compiler would check all possible methods for a method group to find the right one. Now, the compiler prunes or removes methods that don't apply at each scope, like those with the wrong number of parameters or missing required constraints. This makes the process more efficient and matches how overload resolution usually works. If no suitable methods are found in a given scope, the method group won't have a natural type.

For more details refer: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-13.0/method-group-natural-type-improvements

### 10. Overload Resolution Priority:
The OverloadResolutionPriorityAttribute lets you tell the compiler which method overload to prefer when there are multiple options. This is useful for library authors who want to add a better or more efficient method without breaking existing code. By assigning a higher priority to the new overload, the compiler will choose it when the code is recompiled.

![carbon (8)](https://github.com/user-attachments/assets/f75abb8e-165b-48af-a222-b97f5c846a7c)

- Click for demo: [OverloadResolution.cs](./C%2313/OverloadResolution.cs)

### 11. The field keyword:
The field keyword is used within property accessors to refer to the backing field of an auto-property. This allows developers to access and modify the backing field directly within property setters and getters without exposing it to the rest of the class. It provides more control over property behavior, such as lazy initialization or validation, while maintaining cleaner code by avoiding manually declared backing fields.

![carbon (9)](https://github.com/user-attachments/assets/4087beed-95c5-4d9b-938a-c1ce7ec2a170)

- Click for demo: [FieldKeyword.cs](./C%2313/FieldKeyword.cs)

> **Note:** For the `field` keyword to work in C# 13, you must set `<LangVersion>preview</LangVersion>` in your `.csproj` file.

### 12. Ref Struct Types Can Implement Interfaces:
In C# 13, ref struct types can now implement interfaces and participate as generic type arguments. However, since they are stack-allocated by design (to avoid heap allocations and boxing), they can't be assigned to interface variables. This gives you the performance benefits of stack-based types while still enabling code reuse through interfaces.

![carbon (10)](https://github.com/user-attachments/assets/e1c791e4-af56-4b05-a9b8-df444515be5c)

- Click for demo: [RefStructType.cs](./C%2313/RefStructType.cs)

For more details refer: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/ref-struct 

### 13. Ref and unsafe in iterators and async methods:
In C# 13, async and iterator methods can now use `ref` variables or variables from `ref struct` types, which wasn't possible before. However, these variables can’t be used after an `await` or `yield return` statement. This change makes it safer to use types like `System.ReadOnlySpan<T>` in these methods. Also, iterator methods can now have unsafe code, but the `yield return` and `yield break` statements must still be safe.

For more details refer: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-13.0/ref-unsafe-in-iterators-async

  ## 🛠️ How to Implement the Solution

1. **Clone the Repository**
   ```bash
   git clone "repo-link"
   cd csharp13-features-demo
2. Open the project in your preferred C# IDE (e.g., Visual Studio, Visual Studio Code).
3. Navigate to the individual feature file (e.g., `EscapeSequence.cs`) to see the implementation of the specific feature.
4. `Program.cs`: The main entry point of the program, which executes the features.
  

