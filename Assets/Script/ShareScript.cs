using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class ShareScript : MonoBehaviour
{
    public Text Basic_Text;
    public string Basic_String;

    public void Share ()
    {
        StartCoroutine ("TakeScreenShotAndShare");
    }

    IEnumerator TakeScreenShotAndShare ()
    {
        Basic_String = Basic_Text.text;

        yield return new WaitForEndOfFrame ();

        Texture2D tx = new Texture2D (Screen.width, Screen.height, TextureFormat.RGB24, false);
        tx.ReadPixels (new Rect (0, 0, Screen.width, Screen.height), 0, 0);
        tx.Apply ();

        string path = Path.Combine (Application.temporaryCachePath, "sharedImage.png");//image name
        File.WriteAllBytes (path, tx.EncodeToPNG ());

        Destroy (tx); //to avoid memory leaks

        new NativeShare ()
        .SetSubject (Basic_String)
        .SetText ("https://play.google.com/store/apps/details?id=com.Goriskop&hl=ru&gl=US")
        .Share ();
    }
}