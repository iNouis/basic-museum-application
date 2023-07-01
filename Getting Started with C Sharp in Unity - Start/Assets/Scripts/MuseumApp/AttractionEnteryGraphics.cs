using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AttractionEnteryGraphics : MonoBehaviour
{
    public Image thumbnail;

    public TMP_Text attractionTitle;
    public TMP_Text attractionLocation;

    private AttractionConfig attractionConfig;

    public void OnClick()
    {

        SceneManager.LoadScene("AttractionScreen", LoadSceneMode.Single);

    }

    public void Setup(AttractionConfig config)
    {
        attractionConfig = config;

        attractionTitle.text = attractionConfig.title;
        attractionLocation.text = attractionConfig.location;

        SetupThumbnails();
        //setup star rating system

    }

    private void SetupThumbnails()
    {

        thumbnail.sprite = attractionConfig.image;
        var rectTransform = thumbnail.GetComponent<RectTransform>();
        rectTransform.anchoredPosition3D = attractionConfig.thumbnailPosition;
        rectTransform.sizeDelta = attractionConfig.thumbnailSize;
    }
}