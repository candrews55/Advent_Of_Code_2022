using System.IO;
using System.Linq;
using Advent_Of_Code_2022;
using Advent_Of_Code_2022.Day2;
using Xunit;
using Xunit.Abstractions;

namespace Advent_of_Code_2022_Tests;

public class Day2Tests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public Day2Tests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    #region Part 1
    
    [Fact]
    public void ShouldGetAScoreOf15()
    {
        // Arrange
        var path = UsefulConstants.DataFilesPath;
        var testValues = File.ReadAllLines(Path.Combine(path, "Day2ExampleData.txt"));
        
        // Act
        var results = Day2.Day2Part1(testValues.ToList());
        
        // Assert
        Assert.Equal(15, results);
    }

    [Fact]
    public void Day2Part1()
    {
        // Arrange
        var path = UsefulConstants.DataFilesPath;
        var testValues = File.ReadAllLines(Path.Combine(path, "Day2RealData.txt"));
        
        // Act
        var results = Day2.Day2Part1(testValues.ToList());
        
        // Show Results
        _testOutputHelper.WriteLine(results.ToString());
    }
    #endregion

     #region Part 2

     [Fact]
     public void ShouldGetAScoreOf12()
     {
         // Arrange
         var path = UsefulConstants.DataFilesPath;
         var testValues = File.ReadAllLines(Path.Combine(path, "Day2ExampleData.txt"));
         
         // Act
         var results = Day2.Part2(testValues.ToList());
         
         // Assert
         Assert.Equal(12, results);
     }
     
     [Fact]
     public void Day2Part2()
     {
         // Arrange
         var path = UsefulConstants.DataFilesPath;
         var testValues = File.ReadAllLines(Path.Combine(path, "Day2RealData.txt"));
         
         // Act
         var results = Day2.Part2(testValues.ToList());
         
         // Show Results
         _testOutputHelper.WriteLine(results.ToString());
     }
     
     #endregion
}