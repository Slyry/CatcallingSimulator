using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class DialogueBoxDisplay : MonoBehaviour {

    //for player pawn the 3D Text will be above
    [SerializeField]
    GameObject pawn;

    //for Player Character
    [SerializeField]
    GameObject playerCharacter;

    //checker variable
    bool firstRun = false;

	void Start () {

        gameObject.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {

        if (firstRun == false)
        {
            DisplayText();
        }

        UpdateTextBoxPosition();	
	}

    //method so the text box follows the pawn around
    private void UpdateTextBoxPosition()
    {
        transform.Translate(pawn.transform.position.x, (pawn.transform.position.y + 5), pawn.transform.position.z);         
    }

    private void DisplayText()
    {
        //position for player character
        float playerX = playerCharacter.transform.position.x;
        float playerZ = playerCharacter.transform.position.z;

        //position for pawn position
        float pawnX = pawn.transform.position.x;
        float pawnZ = pawn.transform.position.z;

        //int var for text to be displayed
        int choice = UnityEngine.Random.Range(1, 11);

        //switch for displaying text via random, with default, and only run once
        if (((playerX - pawnX < 10) || (pawnX - playerX < 10)) || ((playerZ - pawnZ < 10) || (pawnZ - playerZ < 10)))
        {
            gameObject.SetActive(true);
            firstRun = true;

            switch (choice)
            {

                default:
                    gameObject.GetComponent<TextMesh>().text = "Hey Baby! Looking Fine.";
                    break;

                case 1:
                    gameObject.GetComponent<TextMesh>().text = "Don't you look hot.";
                    break;
                   
                case 2:
                    gameObject.GetComponent<TextMesh>().text = "Looking for something with that outfit?";
                    break;

                case 3:
                    gameObject.GetComponent<TextMesh>().text = "Going my way?";
                    break;

                case 4:
                    gameObject.GetComponent<TextMesh>().text = "ChecWho let you out of the house like that?";
                    break;

                case 5:
                    gameObject.GetComponent<TextMesh>().text = "*Whistle*";
                    break;

                case 6:
                    gameObject.GetComponent<TextMesh>().text = "Going somewhere like that?";
                    break;

                case 7:
                    gameObject.GetComponent<TextMesh>().text = ".";
                    break;

                case 8:
                    gameObject.GetComponent<TextMesh>().text = "Wish my friend was that attractive.";
                    break;

                case 9:
                    gameObject.GetComponent<TextMesh>().text = "Show off!";
                    break;

                case 10:
                    gameObject.GetComponent<TextMesh>().text = "componsating for something?";
                    break;
            }
        }
    }
}
