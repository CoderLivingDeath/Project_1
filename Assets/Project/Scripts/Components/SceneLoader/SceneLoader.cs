using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Project.Scripts.Components.SceneLoader
{
    public class SceneLoader
    {
        public void Load(string name, LoadSceneMode mode = LoadSceneMode.Single)
        {
            SceneManager.LoadScene(name, mode);
        }

        public void Load(int index, LoadSceneMode mode = LoadSceneMode.Single)
        {
            SceneManager.LoadScene(index,mode);
        }
    }
}

