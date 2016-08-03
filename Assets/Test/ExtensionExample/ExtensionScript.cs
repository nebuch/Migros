using UnityEngine;
using System.Collections;

public static class ExtensionScript {

    public static void AnyFunction(this string theString)
    {
        Debug.Log(theString + " an extended string.");
    }
}
