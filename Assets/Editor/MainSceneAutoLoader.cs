
using System;
using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

[InitializeOnLoad]
public static class MainSceneLoader
{
    private const string FIRST_SCENE_PATH = "Assets/Project/Scenes/Bootstrap.unity";
    private const string PREF_KEY_PREV_SCENE = "PREVIOUS SCENE";

    static MainSceneLoader()
    {
        EditorApplication.playModeStateChanged += EditorApplication_playModeStateChanged;
    }

    private static void EditorApplication_playModeStateChanged(PlayModeStateChange obj)
    {
        if (!EditorApplication.isPlaying && EditorApplication.isPlayingOrWillChangePlaymode)
        {
            if (SceneManager.GetActiveScene().buildIndex == 0) return;

            var currentScenePath = SceneManager.GetActiveScene().path;
            EditorPrefs.SetString(PREF_KEY_PREV_SCENE, currentScenePath);

            if(EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
            {
                try
                {
                    EditorSceneManager.OpenScene(FIRST_SCENE_PATH);
                }
                catch(Exception e)
                {
                    Debug.Log(e.Message);
                    EditorApplication.isPlaying = false;
                }
            }
            else
            {
                EditorApplication.isPlaying=false;
            }
        }
        if(!EditorApplication.isPlaying && !EditorApplication.isPlayingOrWillChangePlaymode)
        {
            try
            {
                var path = EditorPrefs.GetString(PREF_KEY_PREV_SCENE);
                EditorSceneManager.OpenScene(path);
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
                EditorApplication.isPlaying = false;
            }
        }
    }
}
