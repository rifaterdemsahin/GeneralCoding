using System;
using System.Collections.Generic;
using System.Linq;

namespace OceanViewBuildings
{
    /// <summary>
    /// Represents a building with height and position information
    /// </summary>
    public class Building
    {
        public int Index { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }

        public Building(int index, int height, string name = null)
        {
            Index = index;
            Height = height;
            Name = name ?? $"Building_{index}";
        }

        /// <summary>
        /// Determines if this building can see the ocean
        /// </summary>
        /// <param name="allBuildings">List of all buildings</param>
        /// <returns>True if building has ocean view, false otherwise</returns>
        public bool CanSeeOcean(List<Building> allBuildings)
        {
            // Check all buildings to the right (higher indices)
            var buildingsToRight = allBuildings.Where(b => b.Index > this.Index);
            
            // Can see ocean if all buildings to the right are shorter
            return buildingsToRight.All(b => b.Height < this.Height);
        }

        public override string ToString()
        {
            return $"{Name} (Index: {Index}, Height: {Height})";
        }
    }

    /// <summary>
    /// Solution class for the Ocean View Buildings problem
    /// </summary>
    public class OceanViewSolution
    {
        /// <summary>
        /// Finds all buildings that can see the ocean
        /// Time Complexity: O(n²) - for each building, check all buildings to the right
        /// Space Complexity: O(k) where k is the number of buildings with ocean view
        /// </summary>
        /// <param name="buildingHeights">Array of building heights</param>
        /// <returns>List of indices of buildings with ocean view</returns>
        public List<int> FindOceanViewBuildings(int[] buildingHeights)
        {
            if (buildingHeights == null || buildingHeights.Length == 0)
                return new List<int>();

            // Create building objects
            var buildings = buildingHeights
                .Select((height, index) => new Building(index, height))
                .ToList();

            // Find buildings with ocean view
            var oceanViewBuildings = buildings
                .Where(building => building.CanSeeOcean(buildings))
                .Select(building => building.Index)
                .OrderBy(index => index)
                .ToList();

            return oceanViewBuildings;
        }

        /// <summary>
        /// Optimized solution using reverse iteration
        /// Time Complexity: O(n) - single pass from right to left
        /// Space Complexity: O(k) where k is the number of buildings with ocean view
        /// </summary>
        /// <param name="buildingHeights">Array of building heights</param>
        /// <returns>List of indices of buildings with ocean view</returns>
        public List<int> FindOceanViewBuildingsOptimized(int[] buildingHeights)
        {
            if (buildingHeights == null || buildingHeights.Length == 0)
                return new List<int>();

            var result = new List<int>();
            int maxHeightFromRight = 0;

            // Iterate from right to left
            for (int i = buildingHeights.Length - 1; i >= 0; i--)
            {
                // If current building is taller than all buildings to its right
                if (buildingHeights[i] > maxHeightFromRight)
                {
                    result.Add(i);
                    maxHeightFromRight = buildingHeights[i];
                }
            }

            // Reverse to get indices in ascending order
            result.Reverse();
            return result;
        }

        /// <summary>
        /// Displays the building configuration and ocean view results
        /// </summary>
        /// <param name="buildingHeights">Array of building heights</param>
        /// <param name="oceanViewIndices">Indices of buildings with ocean view</param>
        public void DisplayResults(int[] buildingHeights, List<int> oceanViewIndices)
        {
            Console.WriteLine("🏢 Building Heights Configuration:");
            Console.WriteLine($"Heights: [{string.Join(", ", buildingHeights)}]");
            Console.WriteLine($"Indices: [{string.Join(", ", Enumerable.Range(0, buildingHeights.Length))}]");
            
            Console.WriteLine("\n🌊 Ocean View Analysis:");
            for (int i = 0; i < buildingHeights.Length; i++)
            {
                var hasOceanView = oceanViewIndices.Contains(i);
                var status = hasOceanView ? "✅ CAN SEE OCEAN" : "❌ Cannot see ocean";
                Console.WriteLine($"Building {i} (height={buildingHeights[i]}): {status}");
            }
            
            Console.WriteLine($"\n🎯 Result: Buildings with ocean view: [{string.Join(", ", oceanViewIndices)}]");
        }
    }

    /// <summary>
    /// Program entry point with example usage
    /// </summary>
    public class Program
    {
        public static void Main()
        {
            var solution = new OceanViewSolution();
            
            // Test Case 1: Example from requirements
            Console.WriteLine("=== Test Case 1: Example ===");
            int[] buildings1 = { 5, 3, 2, 4, 1 };
            var result1 = solution.FindOceanViewBuildingsOptimized(buildings1);
            solution.DisplayResults(buildings1, result1);
            
            Console.WriteLine("\n=== Test Case 2: All Decreasing Heights ===");
            int[] buildings2 = { 5, 4, 3, 2, 1 };
            var result2 = solution.FindOceanViewBuildingsOptimized(buildings2);
            solution.DisplayResults(buildings2, result2);
            
            Console.WriteLine("\n=== Test Case 3: All Increasing Heights ===");
            int[] buildings3 = { 1, 2, 3, 4, 5 };
            var result3 = solution.FindOceanViewBuildingsOptimized(buildings3);
            solution.DisplayResults(buildings3, result3);
            
            Console.WriteLine("\n=== Test Case 4: Single Building ===");
            int[] buildings4 = { 10 };
            var result4 = solution.FindOceanViewBuildingsOptimized(buildings4);
            solution.DisplayResults(buildings4, result4);
            
            Console.WriteLine("\n=== Performance Comparison ===");
            Console.WriteLine("Testing both algorithms with the example input...");
            
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var basicResult = solution.FindOceanViewBuildings(buildings1);
            watch.Stop();
            Console.WriteLine($"Basic Algorithm: {watch.ElapsedTicks} ticks");
            
            watch.Restart();
            var optimizedResult = solution.FindOceanViewBuildingsOptimized(buildings1);
            watch.Stop();
            Console.WriteLine($"Optimized Algorithm: {watch.ElapsedTicks} ticks");
            
            Console.WriteLine($"Results match: {basicResult.SequenceEqual(optimizedResult)}");
        }
    }
}