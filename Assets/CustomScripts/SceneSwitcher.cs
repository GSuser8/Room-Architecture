using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Call this function on a button click or any other event
    public void SwitchToKidsBedroom()
    {
        SceneManager.LoadScene("Kids room");
    }

    public void SwitchToMasterBedroom()
    {
        SceneManager.LoadScene("Master bedroom");
    }

    public void SwitchToStart()
    {
        SceneManager.LoadScene("Start");
    }
}
