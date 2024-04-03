using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Project.Scripts.Core.Infrastructure
{
    public class SceneLoader
    {
        public void Load(string name)
        {
            SceneManager.LoadScene(name);
        }
    }
}
