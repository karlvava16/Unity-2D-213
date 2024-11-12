using Assets.Scripts;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModalScript : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private GameObject content;
    [SerializeField]
    private TMPro.TextMeshProUGUI titleTMP;
    [SerializeField]
    private TMPro.TextMeshProUGUI messageTMP;
    [SerializeField]
    private GameObject OnButton;


    void Start()
    {
        //titleTMP = GameObject.Find("TitleTMP").GetComponent<TMPro.TextMeshProUGUI>();
        this.ShowModal(content.activeInHierarchy);
        GameState.modalScriptInstance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            this.ShowModal(!content.activeInHierarchy);
        }
    }

    public void ShowModal(bool isShown, string title = null, string message = null)
    {
        if (isShown)
        {
            if (title == null) title = "ПАУЗА";
            if (message == null) message = "Для продовження гри натисніть кнопку";
            Time.timeScale = 0.0f;
            titleTMP.text = title;
            messageTMP.text = message;
            content.SetActive(true);
            if (GameState.sceneNumber >= GameState.sceneMax)
            {
                OnButton.SetActive(false);
            }
        }
        else
        {
            Time.timeScale = 1.0f;
            content.SetActive(false);
        }
    }

    public void OnGoButtonClick()
    {
        if (GameState.isLevelCompleted)
        {
            if (GameState.sceneNumber < GameState.sceneMax)
            {
                GameState.sceneNumber += 1;
                SceneManager.LoadScene(GameState.sceneNumber);
            }
            else
            {
                OnButton.SetActive(false);
            }
        }
        else
        {
            ShowModal(false);

        }
    }

    public void OnExitButtonClick()
    {
#if UNITY_STANDALONE
        Application.Quit();
#endif

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;

#endif
    }
}
