# 🌊 Ocean View Buildings Problem

## 📁 Project Overview

This folder contains a complete C# implementation of the "Ocean View Buildings" algorithmic problem, demonstrating both basic and optimized solutions with comprehensive testing.

## 🏗️ Problem Description

Given an array of building heights in a line, determine which buildings can see the ocean located to the right of all buildings. A building has an ocean view if all buildings to its right are shorter.

**Example:** `[5, 3, 2, 4, 1]` → Buildings at indices `[0, 3, 4]` can see the ocean.

## 📂 Files Structure

```
QuestionBuildings/
├── requirement.md         # Detailed problem specification and requirements
├── OceanViewSolution.cs   # Main implementation with two algorithms
├── OceanViewTests.cs      # Comprehensive unit tests
└── README.md             # This documentation file
```

## 🚀 How to Run

### Prerequisites
- .NET 8.0 SDK installed
- For unit tests: MSTest framework (included in .NET SDK)

### Compile and Run
```bash
# Navigate to the QuestionBuildings directory
cd "6_🔣_Symbols/QuestionBuildings"

# Compile the solution
csc OceanViewSolution.cs

# Run the program
./OceanViewSolution.exe  # Windows
# or
mono OceanViewSolution.exe  # macOS/Linux
```

### Run with dotnet (if .csproj exists)
```bash
dotnet run
```

### Run Unit Tests
```bash
# Create test project (if needed)
dotnet new mstest -n OceanViewTests

# Add the test file and run
dotnet test
```

## 🧮 Algorithm Implementations

### 1. Basic Algorithm (O(n²))
- **Approach**: For each building, check all buildings to its right
- **Time Complexity**: O(n²) 
- **Space Complexity**: O(k) where k = buildings with ocean view
- **Use Case**: Educational, easy to understand

### 2. Optimized Algorithm (O(n))
- **Approach**: Single pass from right to left, tracking maximum height
- **Time Complexity**: O(n)
- **Space Complexity**: O(k) where k = buildings with ocean view  
- **Use Case**: Production code, large datasets

## 📊 Test Cases Covered

✅ **Example Case**: `[5, 3, 2, 4, 1]` → `[0, 3, 4]`  
✅ **All Decreasing**: `[5, 4, 3, 2, 1]` → `[0, 1, 2, 3, 4]`  
✅ **All Increasing**: `[1, 2, 3, 4, 5]` → `[4]`  
✅ **Single Building**: `[10]` → `[0]`  
✅ **Empty Array**: `[]` → `[]`  
✅ **Null Input**: `null` → `[]`  
✅ **Same Heights**: `[3, 3, 3, 3]` → `[3]`  
✅ **Complex Case**: `[4, 2, 3, 1, 6, 5]` → `[0, 2, 4, 5]`

## 🎯 Key Features

- **Two Algorithm Implementations**: Basic O(n²) and optimized O(n)
- **Comprehensive Unit Tests**: 15+ test cases covering edge cases
- **Clean Object-Oriented Design**: Building class with encapsulated logic
- **Performance Comparison**: Built-in timing comparison between algorithms
- **Detailed Documentation**: Requirements, analysis, and usage examples
- **Visual Output**: Console display with emojis and clear formatting

## 💡 Learning Objectives

This implementation demonstrates:
- **Algorithm Optimization**: From O(n²) to O(n) time complexity
- **Object-Oriented Programming**: Classes, methods, encapsulation
- **Unit Testing**: Comprehensive test coverage with MSTest
- **Edge Case Handling**: Null inputs, empty arrays, single elements
- **Code Documentation**: XML comments and clear naming conventions
- **Performance Analysis**: Algorithm comparison and measurement

## 🔍 Sample Output

```
=== Test Case 1: Example ===
🏢 Building Heights Configuration:
Heights: [5, 3, 2, 4, 1]
Indices: [0, 1, 2, 3, 4]

🌊 Ocean View Analysis:
Building 0 (height=5): ✅ CAN SEE OCEAN
Building 1 (height=3): ❌ Cannot see ocean
Building 2 (height=2): ❌ Cannot see ocean
Building 3 (height=4): ✅ CAN SEE OCEAN
Building 4 (height=1): ✅ CAN SEE OCEAN

🎯 Result: Buildings with ocean view: [0, 3, 4]
```

## 🔗 Related Files

- **Requirements**: See `requirement.md` for detailed problem specification
- **Implementation**: `OceanViewSolution.cs` contains both algorithms
- **Testing**: `OceanViewTests.cs` provides comprehensive test coverage
- **Project Context**: Part of the General Coding self-learning project in `6_🔣_Symbols`