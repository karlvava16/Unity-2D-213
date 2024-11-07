using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModalScript : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private GameObject content;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = !content.activeInHierarchy ? 0.0f : 1.0f;
            content.SetActive(!content.activeInHierarchy);
        }
    }
}
