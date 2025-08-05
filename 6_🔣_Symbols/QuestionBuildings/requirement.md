# Ocean View Buildings Problem

## 🎯 Problem Statement

Given an array of building heights arranged in a line, determine which buildings can see the ocean. 

**Key Rules:**
- Buildings are positioned in a straight line from left to right
- The ocean is located to the **right** of all buildings
- A building can see the ocean if **ALL** buildings to its right are shorter than itself
- Return the indices of buildings that have an ocean view

## 📊 Example

**Input:** `[5, 3, 2, 4, 1]`  
**Output:** `[0, 3, 4]`

### Visual Representation:
```
Height
  5 |██|              
  4 |██|  ___         |██|
  3 |██|  |██|  ___   |██|
  2 |██|  |██|  |██|  |██|  ___
  1 |██|  |██|  |██|  |██|  |██|
    +--+  +--+  +--+  +--+  +--+  ~~~~~ Ocean
    b0    b1    b2    b3    b4
    ↑                 ↑     ↑
   Can see          Can   Can
   ocean            see   see
                   ocean ocean
```

### Analysis:
- **Building 0 (height=5)**: Can see ocean (all buildings to right are shorter: 3,2,4,1 < 5)
- **Building 1 (height=3)**: Cannot see ocean (building 3 height=4 > 3)
- **Building 2 (height=2)**: Cannot see ocean (building 3 height=4 > 2)
- **Building 3 (height=4)**: Can see ocean (only building 4 height=1 < 4)
- **Building 4 (height=1)**: Can see ocean (no buildings to the right)

## 🏗️ Requirements

### Functional Requirements:
1. **Input**: Array of positive integers representing building heights
2. **Output**: List of indices (0-based) of buildings with ocean view
3. **Algorithm**: Must check all buildings to the right of each building
4. **Edge Cases**: 
   - Single building always has ocean view
   - Empty array returns empty result
   - All buildings same height: only rightmost has view

### Non-Functional Requirements:
1. **Performance**: O(n) time complexity preferred
2. **Memory**: O(k) space where k is number of buildings with ocean view
3. **Code Quality**: Clean, readable, and well-documented C# code
4. **Testing**: Unit tests for various scenarios

## 🎯 Success Criteria

- [ ] Correctly identifies buildings with ocean view
- [ ] Handles edge cases (empty array, single building, equal heights)
- [ ] Efficient algorithm implementation
- [ ] Comprehensive unit tests
- [ ] Clear documentation and examples
