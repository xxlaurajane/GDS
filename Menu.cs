using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Button playBtn;
    

    // Use this for initialization
    void Start()
    {
        playBtn.onClick.AddListener(() => { SceneManager.LoadScene("NewBeta"); });
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}