using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject Screen_Menu;
    public GameObject Screen_Credits;
    public GameObject Screen_Selection;
    private void Start()
    {
        //Screen_Credits.SetActive(false);
        Screen_Selection.SetActive(false);
    }
    public void SceneLoader(int Number)
    {
        SceneManager.LoadScene(Number);
    }
    public void Selection()
    {
        Screen_Menu.SetActive(false);
        Screen_Selection.SetActive(true);
    }
}
