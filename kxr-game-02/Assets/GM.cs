using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    public GameObject panel;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameOver() {
        Time.timeScale = 0;
        panel.SetActive(true);
        Text t = panel.transform.Find("Text").GetComponent<Text>();
        t.text = "你挂了";
        audio.Stop();
    }

    public void Restart() {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void Finish() {
        Time.timeScale = 0;
        panel.SetActive(true);
        Text t = panel.transform.Find("Text").GetComponent<Text>();
        t.text = "你赢了";
        audio.Stop();
    }
}
