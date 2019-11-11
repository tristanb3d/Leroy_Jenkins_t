using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.Assertions;

namespace Tests
{
    public class SampleTests
    {
        private GameObject game;

        [UnitySetUp]
        public IEnumerator SetUp()
        {
            GameObject gamePrefab = Resources.Load<GameObject>("Prefabs/Game");
            game = Object.Instantiate(gamePrefab);
            yield return null;
        }
        [UnityTearDown]
        public IEnumerator TearDown()
        {
            Object.Destroy(game);
            yield return null;
        }
        

        [UnityTest] 
        public IEnumerator PlayeMove()
        {
            // Get Access to PlayerMovement
            PlayerMovement player = game.GetComponentInChildren<PlayerMovement>();


            Vector3 oldPosition = player.transform.position;

            // A. Run the Player 'Move' function
            player.Move(Vector3.right * 10f);

            // B. Wait till the end of Frame
            yield return new WaitForEndOfFrame();

            Vector3 newPosition = player.transform.position;

            // C. Check if the Player's position indicates movement
            Assert.AreNotEqual(oldPosition, newPosition);
        }


    }
}
