using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrackPlanner;

namespace WPFTrackPlannerTest
{
    [TestClass]
    public class TrackTest
    {
        [TestMethod]
        public void TestCurveCreate()
        {
            var curve = new Curve();
            Assert.AreEqual(2, curve.Nodes.Count);
        }

        [TestMethod]
        public void TestStraightCreate()
        {
            var straight = new Straight();
            Assert.AreEqual(2, straight.Nodes.Count);
        }

        [TestMethod]
        public void TestCrossingCreate()
        {
            var crossing = new Crossing();
            Assert.AreEqual(2, crossing.Nodes.Count);
        }

        [TestMethod]
        public void TestSwitchCreate()
        {
            var switch_ = new Switch();
            Assert.AreEqual(3, switch_.Nodes.Count);
        }

        [TestMethod]
        public void TestCrossCreate()
        {
            var cross = new Cross();
            Assert.AreEqual(4, cross.Nodes.Count);
        }
    }
}
