using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [Space(10)]

    public GameObject Screen_Menu;
    public GameObject Screen_Credits;
    public GameObject Screen_Selection;

    private void Start()
    {
        Screen_Credits.SetActive(false);
        Screen_Selection.SetActive(false);
    }
    public void SceneLoader(int Number)
    {
        SceneManager.LoadScene(Number);
    }
    public void Menu()
    {
        Screen_Menu.SetActive(true);
        Screen_Credits.SetActive(false);
        Screen_Selection.SetActive(false);
    }

    public void Selection()
    {
        Screen_Menu.SetActive(false);
        Screen_Credits.SetActive(false);
        Screen_Selection.SetActive(true);
    }
    public void Credits()
    {
        Screen_Menu.SetActive(false);
        Screen_Credits.SetActive(true);
        Screen_Selection.SetActive(false);
    }
}
