using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class tessting
    {
        // A Test behaves as an ordinary method
        [Test]
        public void tesstingSimplePasses()
        {
            // Use the Assert class to test conditions
        }
        [UnityTest]
        public void movetest()
        {

        }
        [UnityTest]
        public void shootTest()
        {

        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator tesstingWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
