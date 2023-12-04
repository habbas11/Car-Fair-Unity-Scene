using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Update()
    {
        // Check if the Escape button is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Close the game (this works in the Editor; for a built game, you might need different handling)
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #else
            Application.Quit();
            #endif
        }
    }
}
