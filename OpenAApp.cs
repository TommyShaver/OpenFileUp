using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class OpenAApp : MonoBehaviour
{
    public void OpenNotePadAPP()
    {
        Process.Start("notepad");
    }
}
