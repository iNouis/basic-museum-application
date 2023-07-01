
using UnityEngine;

[CreateAssetMenu(fileName = "New Attraction Config", menuName = "Configs1/AttractionConfig", order = 0)]
public class AttractionConfig : ScriptableObject
{
    //the data is basicly is variables

    public string id;
    public string title;
    public string author;
    public string description;
    public string location;

    public Sprite image;

    public Vector2 thumbnailSize;
    public Vector3 thumbnailPosition;

    public Vector2 headerImageSize;
    public Vector3 headerImagePosition;


}

