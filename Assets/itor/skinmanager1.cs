using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.SceneManagement;

public class skinmanager1 : MonoBehaviour
{
    public SpriteRenderer sr;
    public List<Sprite> skins = new List<Sprite>();
    private int selectedskin = 0;
    public GameObject playerskin;

    public void next()
    {
        selectedskin = selectedskin + 1;
        if (selectedskin == skins.Count)
        {
            selectedskin = 0;
        }
        sr.sprite = skins[selectedskin];
    }

    public void back()
    {
        selectedskin = selectedskin - 1;
        if (selectedskin < 0)
        {
            selectedskin = skins.Count - 1;
        }
        sr.sprite = skins[selectedskin];
    }

  /*  public void playgame()
    {
#if UNITY_EDITOR
        PrefabUtility.SaveAsPrefabAsset(playerskin, "Assets/prefabs/parts/body.prefab");
#endif   
    }*/
}
