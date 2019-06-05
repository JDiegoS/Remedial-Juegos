using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    private bool isPause = false;
    private bool perdio = false;
    private int puntos = 0;
    public UnityEngine.UI.Text txt;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && perdio == false)
        {

            if (isPause)
            {
                Continue();

            }
            else
                Pause();


        }
    }
    public void Defeat()
    {

        Time.timeScale = 0.0f;
        transform.Find("Defeat").gameObject.SetActive(true);


    }
    public void Victory()
    {
        Time.timeScale = 0.0f;
        transform.Find("Victory").gameObject.SetActive(true);

    }
    public void Pause()
    {
        Time.timeScale = 0.0f;
        transform.Find("Pause").gameObject.SetActive(true);
        isPause = true;

    }
    public void Continue()
    {
        Time.timeScale = 1.0f;
        transform.Find("Pause").gameObject.SetActive(false);
        isPause = false;
    }
    public void Hit()
    {
        perdio = true;
    }
    public void Restart()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Level");
    }
    public void Punto()
    {
        puntos += 1;
        txt.text = "" + puntos;
    }
}

