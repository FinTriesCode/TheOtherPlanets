using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{

    // This will contain a list of the game objects for the health icons
    // public = variable will be shown in the Unity editor
    // [] = variable will contain an array (list)
    // GameObject[] = The list will consist of GameObjects
    public GameObject[] healthIcons;

    // This will be the PlayerHealth component that we can ask for information about the player's health
    // PlayerHealth = variable is in the form of a PlayerHealth component (your script)
    PlayerHealth player;

    // Built in Unity function
    // Start is called before the first frame update
    void Start()
    {
        // Search the scene for the object with PlayerHealth script attached
        // Store the PlayerHealth component from that object in our player variable
        player = FindObjectOfType<PlayerHealth>();
    }

    // Built in Unity function
    // Update is called once per frame
    void Update()
    {
        // Create a variable to keep track of which item in the list we are on
        int currentIconHealth = 0;

        // Loop through all the GameObjects in the list
        // We will do everything inside the brackets for each item in the list
        // For each step in the loop, we'll store the list item in the "icon" variable
        foreach (GameObject icon in healthIcons)
        {
            // Each icon is worth one more health than the last
            // Get the current icon health value, add one to it, 
            // and store it back into the currentIconHealth variable
            currentIconHealth = currentIconHealth + 1;

            // If the player's current health is equal or greater 
            // than the health value for this icon...
            if (player.GetHealth() >= currentIconHealth)
            {
                // ...Then turn the icon ON
                icon.SetActive(true);
            }
            // Otherwise...
            // (the player's health is LESS than this icon's value)
            else
            {
                // ... Turn the icon OFF
                icon.SetActive(false);
            }

        }
    }
}