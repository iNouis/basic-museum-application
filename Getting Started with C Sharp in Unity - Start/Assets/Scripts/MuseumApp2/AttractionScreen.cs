using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MuseumApp2
{


    public class AttractionScreen : MonoBehaviour
    {

        public void PointerEnter() {

            Debug.Log("Enter");
        }

        public void PointerExit()
        {

            Debug.Log("Exit");
        }

        public void PointerDown()
        {

            Debug.Log("Down");
        }

        public void PointerUp()
        {

            Debug.Log("Up");
        }

    }
}
