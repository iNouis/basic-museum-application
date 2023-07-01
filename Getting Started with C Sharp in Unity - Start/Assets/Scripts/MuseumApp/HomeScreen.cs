using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MuseumApp
{
    public class HomeScreen : MonoBehaviour
    {
        public RectTransform attractionEntriesParent;// the variable that's gonna hold our parent postion
        public AttractionEnteryGraphics attractionPrefab;//all our attraction prefabs instantiate onto
        public List<AttractionConfig> attractions;

        void Awake() //instantiate the object before the user is able to see it (before start up)
        {
            foreach (var attraction in attractions)
            {

                var newAttraction = Instantiate(attractionPrefab, attractionEntriesParent);
                //set up the attraction prefab with the scriptable object data

                newAttraction.Setup(attraction);
            }
        }
        public void Signup()
        {
            SceneManager.LoadScene("SignupPopup", LoadSceneMode.Additive);


        }
    }
}
