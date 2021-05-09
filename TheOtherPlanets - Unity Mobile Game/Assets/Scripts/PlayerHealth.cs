using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // This will be the starting health for the player
    // Public variable = shown in Unity editor and accessible from other scripts
    // int = whole numbers
    public int startingHealth;

    // This will be the player's current health
    // Private variable = NOT shown in Unity or accessible from other scripts
    // int = whole numbers
    private int currentHealth;

    // Built in Unity function called when the object this script is attached to is created
    // Usually this is when the game starts unless the object is spawned in later
    // this happens BEFORE the Start() function
    // Usually used for initialisation
    void Awake()
    {
        // Initialise our current health to be equal to our 
        // starting health at the beginning of the game
        currentHealth = startingHealth;
    }

    // This function is NOT built in to Unity
    // It will only be called manually by our own code
    // It must be marked "public" so our other scripts can access it
    // This function will change the health value of the player
    public void ChangeHealth(int changeAmount)
    {
        // Take our current health, add the change amount, and store the result back in the current health variable
        currentHealth = currentHealth + changeAmount;

        // We don't want our current health to go below zero
        // And we don't want it to go above our starting health
        // So we use the special "Clamp" function to keep it 
        // between 0 and our starting health
        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);

        // If our health has dropped to 0, that means our player should die.
        if (currentHealth == 0)
        {
            // We call the Kill function to kill the player
            Kill();
        }
    }

    // This function is NOT built in to Unity
    // It will only be called manually by our own code
    // It must be marked "public" so our other scripts can access it
    // This function will kill the player
    public void Kill()
    {
        // This will destroy the gameObject that this script is attached to
        Destroy(gameObject);
    }

    // This simple function will let other scripts ask this one what the current health is
    // the function RETURNS an integer, meaning it gives a number back to the code that called it
    public int GetHealth()
    {
        return currentHealth;
    }

    // This simple function will let other scripts ask this one what the max health is
    // the function RETURNS an integer, meaning it gives a number back to the code that called it
    public int GetMaxHealth()
    {
        return startingHealth;
    }
}