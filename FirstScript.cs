using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstScript : MonoBehaviour
{
    public Button buttonNext;
    public Button buttonBack;
    public Image image;
    public List<Sprite> images;
    public Image image1;
    private int indexer;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    public void PushOnForNext()
    {
        indexer++;
        if (indexer >= images.Count)
            indexer = 0;
        image.sprite = images[indexer];
    }

    public void PushOnForBack()
    {
        indexer--;
        if (indexer < 0)
            indexer = images.Count - 1;
        image.sprite = images[indexer];
    }

    public void PushOnStart()
    {
        if (image.gameObject.activeSelf == false)
        {
            image.gameObject.SetActive(true);
            buttonBack.gameObject.SetActive(true);
            buttonNext.gameObject.SetActive(true);
        }
        else
        {
            image.gameObject.SetActive(false);
            buttonBack.gameObject.SetActive(false);
            buttonNext.gameObject.SetActive(false);
        }


    }
}
