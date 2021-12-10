using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using PacManNS;

public class PacManTests
{
    [Test]
    public void MoveToStartingPosition_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var pacMan = new PacMan();

        // Act
        pacMan.MoveToStartingPosition();

        // Assert
        Assert.Fail();
    }

    [Test]
    public void Restart_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var pacMan = new PacMan();

        // Act
        pacMan.Restart();

        // Assert
        Assert.Fail();
    }
}
