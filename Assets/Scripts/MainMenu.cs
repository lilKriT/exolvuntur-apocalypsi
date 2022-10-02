using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private Button playButton;
    private Button quitButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable(){
        var rootVisualElement = GetComponent<UIDocument>().rootVisualElement;

        playButton = rootVisualElement.Q<Button>("PlayButton");
        playButton.RegisterCallback<ClickEvent>(PlayGame);
        quitButton.RegisterCallback<ClickEvent>(QuitGame);
    }

    public void PlayGame(ClickEvent evt){
        // Debug.Log("Play");
        SceneManager.LoadScene("Level01");
    }

    public void QuitGame(ClickEvent evt){
            Application.Quit();
    }
}
