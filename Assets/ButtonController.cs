using UnityEngine;
using UnityEngine.SceneManagement;  // Import the Scene Management namespace

public class ButtonController : MonoBehaviour
{
    // Function to load a new scene when a button is clicked
    public void LoadScene(string SAMPLE)
    {
        SceneManager.LoadScene("SAMPLE"); // Load the specified scene
    }
}