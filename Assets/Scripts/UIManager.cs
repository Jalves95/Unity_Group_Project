using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject resumeButton;
    public GameObject exitButton;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Pausing");
            if (!resumeButton.activeSelf)
            {
                resumeButton.SetActive(true);
                exitButton.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0;
            }
            else
            {
                resumeButton.SetActive(false);
                exitButton.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                Time.timeScale = 1;
            }
        }
    }

    public void OnCLick(string buttonName)
    {
        if (buttonName == "Exit")
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
        else if (buttonName == "Resume")
        {
            resumeButton.SetActive(false);
            exitButton.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1;
        }
    }
}
