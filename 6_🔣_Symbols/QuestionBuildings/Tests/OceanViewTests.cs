using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OceanViewBuildings.Tests
{
    [TestClass]
    public class OceanViewSolutionTests
    {
        private OceanViewSolution _solution = null!;

        [TestInitialize]
        public void Setup()
        {
            _solution = new OceanViewSolution();
        }

        [TestMethod]
        public void FindOceanViewBuildings_ExampleCase_ReturnsCorrectIndices()
        {
            // Arrange
            int[] buildings = { 5, 3, 2, 4, 1 };
            var expected = new List<int> { 0, 3, 4 };

            // Act
            var result = _solution.FindOceanViewBuildingsOptimized(buildings);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindOceanViewBuildings_AllDecreasingHeights_ReturnsAllIndices()
        {
            // Arrange
            int[] buildings = { 5, 4, 3, 2, 1 };
            var expected = new List<int> { 0, 1, 2, 3, 4 };

            // Act
            var result = _solution.FindOceanViewBuildingsOptimized(buildings);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindOceanViewBuildings_AllIncreasingHeights_ReturnsOnlyLastIndex()
        {
            // Arrange
            int[] buildings = { 1, 2, 3, 4, 5 };
            var expected = new List<int> { 4 };

            // Act
            var result = _solution.FindOceanViewBuildingsOptimized(buildings);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindOceanViewBuildings_SingleBuilding_ReturnsFirstIndex()
        {
            // Arrange
            int[] buildings = { 10 };
            var expected = new List<int> { 0 };

            // Act
            var result = _solution.FindOceanViewBuildingsOptimized(buildings);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindOceanViewBuildings_EmptyArray_ReturnsEmptyList()
        {
            // Arrange
            int[] buildings = { };
            var expected = new List<int>();

            // Act
            var result = _solution.FindOceanViewBuildingsOptimized(buildings);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindOceanViewBuildings_NullArray_ReturnsEmptyList()
        {
            // Arrange
            int[]? buildings = null;
            var expected = new List<int>();

            // Act
            var result = _solution.FindOceanViewBuildingsOptimized(buildings);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindOceanViewBuildings_AllSameHeight_ReturnsOnlyLastIndex()
        {
            // Arrange
            int[] buildings = { 3, 3, 3, 3, 3 };
            var expected = new List<int> { 4 };

            // Act
            var result = _solution.FindOceanViewBuildingsOptimized(buildings);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindOceanViewBuildings_TwoBuildings_ShorterThenTaller_ReturnsLastIndex()
        {
            // Arrange
            int[] buildings = { 2, 5 };
            var expected = new List<int> { 1 };

            // Act
            var result = _solution.FindOceanViewBuildingsOptimized(buildings);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindOceanViewBuildings_TwoBuildings_TallerThenShorter_ReturnsBothIndices()
        {
            // Arrange
            int[] buildings = { 5, 2 };
            var expected = new List<int> { 0, 1 };

            // Act
            var result = _solution.FindOceanViewBuildingsOptimized(buildings);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindOceanViewBuildings_ComplexCase_ReturnsCorrectIndices()
        {
            // Arrange
            int[] buildings = { 4, 2, 3, 1, 6, 5 };
            var expected = new List<int> { 0, 2, 4, 5 };

            // Act
            var result = _solution.FindOceanViewBuildingsOptimized(buildings);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void BothAlgorithms_ProduceSameResults_ForVariousInputs()
        {
            // Arrange
            var testCases = new List<int[]>
            {
                new int[] { 5, 3, 2, 4, 1 },
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 5, 4, 3, 2, 1 },
                new int[] { 3, 3, 3, 3 },
                new int[] { 10 },
                new int[] { 4, 2, 3, 1, 6, 5 },
                new int[] { }
            };

            // Act & Assert
            foreach (var testCase in testCases)
            {
                var basicResult = _solution.FindOceanViewBuildings(testCase);
                var optimizedResult = _solution.FindOceanViewBuildingsOptimized(testCase);

                CollectionAssert.AreEqual(basicResult, optimizedResult, 
                    $"Results differ for input: [{string.Join(", ", testCase)}]");
            }
        }
    }

    [TestClass]
    public class BuildingTests
    {
        [TestMethod]
        public void Building_Constructor_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var building = new Building(2, 10, "TestBuilding");

            // Assert
            Assert.AreEqual(2, building.Index);
            Assert.AreEqual(10, building.Height);
            Assert.AreEqual("TestBuilding", building.Name);
        }

        [TestMethod]
        public void Building_ConstructorWithoutName_GeneratesDefaultName()
        {
            // Arrange & Act
            var building = new Building(3, 15);

            // Assert
            Assert.AreEqual("Building_3", building.Name);
        }

        [TestMethod]
        public void CanSeeOcean_AllBuildingsToRightAreShorter_ReturnsTrue()
        {
            // Arrange
            var buildings = new List<Building>
            {
                new Building(0, 5),
                new Building(1, 3),
                new Building(2, 2),
                new Building(3, 1)
            };
            var testBuilding = buildings[0];

            // Act
            var canSee = testBuilding.CanSeeOcean(buildings);

            // Assert
            Assert.IsTrue(canSee);
        }

        [TestMethod]
        public void CanSeeOcean_SomeBuildingToRightIsTaller_ReturnsFalse()
        {
            // Arrange
            var buildings = new List<Building>
            {
                new Building(0, 3),
                new Building(1, 2),
                new Building(2, 4),
                new Building(3, 1)
            };
            var testBuilding = buildings[0];

            // Act
            var canSee = testBuilding.CanSeeOcean(buildings);

            // Assert
            Assert.IsFalse(canSee);
        }

        [TestMethod]
        public void CanSeeOcean_LastBuilding_ReturnsTrue()
        {
            // Arrange
            var buildings = new List<Building>
            {
                new Building(0, 5),
                new Building(1, 3),
                new Building(2, 4),
                new Building(3, 1)
            };
            var testBuilding = buildings[3]; // Last building

            // Act
            var canSee = testBuilding.CanSeeOcean(buildings);

            // Assert
            Assert.IsTrue(canSee);
        }

        [TestMethod]
        public void ToString_ReturnsFormattedString()
        {
            // Arrange
            var building = new Building(2, 10, "TestBuilding");

            // Act
            var result = building.ToString();

            // Assert
            Assert.AreEqual("TestBuilding (Index: 2, Height: 10)", result);
        }
    }
}