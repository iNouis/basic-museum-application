﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MuseumApp
{
    public class AttractionScreen : MonoBehaviour
    {
        public void OnClickBack()
        {
            SceneManager.LoadScene("HomeScreen", LoadSceneMode.Single);
        }
    }
}