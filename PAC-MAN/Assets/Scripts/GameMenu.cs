using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace PacManNS
{
    public class GameMenu : MonoBehaviour
    {
        public bool isOnStartGame = true;

        public Text startGameText;
        public Text quitGameText;
        public Text optionSelector;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                if (!isOnStartGame)
                {
                    isOnStartGame = true;
                    optionSelector.transform.localPosition = new Vector3(optionSelector.transform.localPosition.x, startGameText.transform.localPosition.y, optionSelector.transform.localPosition.z);
                }
            }
            else if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                if (isOnStartGame)
                {
                    isOnStartGame = false;
                    optionSelector.transform.localPosition = new Vector3(optionSelector.transform.localPosition.x, quitGameText.transform.localPosition.y, optionSelector.transform.localPosition.z);
                }
            }
            else if (Input.GetKeyUp(KeyCode.Return))
            {
                if (isOnStartGame)
                {
                    SceneManager.LoadScene("Level1");
                }
                else if (!isOnStartGame)
                {
                    Application.Quit();
                }
            }
        }
    }
}