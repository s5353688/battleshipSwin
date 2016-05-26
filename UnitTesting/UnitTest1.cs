using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyGame
{
    [TestClass]
    public class TestCase
    {
        [TestMethod]
        public void AIDifficulty()
        {
            AIOption _aiopt;
            _aiopt = AIOption.Hard;

            Assert.IsTrue(_aiopt == AIOption.Hard);
            
            _aiopt = AIOption.Medium;

            Assert.IsTrue(_aiopt == AIOption.Medium);
        }

        [TestMethod]
        public void CreatingAiPlayer()
        {
            AIPlayer _ai1 , _ai2 , _ai3, temp;
            BattleShipsGame _thegame;

            _thegame = new BattleShipsGame();

            _ai1 = new AIHardPlayer(_thegame);
            _ai2 = new AIMediumPlayer(_thegame);
            _ai3 = null;
            temp = new AIHardPlayer(_thegame);

            Assert.IsTrue(_ai1.GetType() == temp.GetType());
            Assert.IsFalse(_ai1.GetType() == _ai2.GetType());

            Assert.AreNotEqual(_ai1, null);
            Assert.AreNotEqual(_ai2, null);
            Assert.AreEqual(_ai3, null);
        }
    }
}
