using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public SpriteRenderer sRenderer;

    public void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex != SceneManager.sceneCountInBuildSettings - 1)
            sRenderer = GetComponent<SpriteRenderer>();
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (sRenderer == null)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            else
                sRenderer.sortingOrder = 2;
        }
    }
}