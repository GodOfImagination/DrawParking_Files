using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour, IPointerDownHandler, IPointerClickHandler
{
    public GameObject Screen_Hint;
    public GameObject Screen_Start;
    public GameObject Screen_Winner;
    private void Start()
    {
        Screen_Winner.SetActive(false);
        Screen_Start.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 clickPosition2D = new Vector2(clickPosition.x, clickPosition.y);

            RaycastHit2D hit2D = Physics2D.Raycast(clickPosition2D, Vector2.zero);

            if (hit2D.collider != null)
            {
                Debug.Log(hit2D.collider.gameObject.name);
                Screen_Hint.SetActive(false);
            }
        }
    }

    public void SceneLoader(int Number)
    {
        SceneManager.LoadScene(Number);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Clicked");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Down");
    }
}
