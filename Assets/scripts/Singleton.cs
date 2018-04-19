using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<DiskFactory> : MonoBehaviour where DiskFactory : MonoBehaviour
{

	protected static DiskFactory instance;

	public static DiskFactory Instance
    {
        get
        {
            if (instance == null)
            {
				instance = (DiskFactory)FindObjectOfType(typeof(DiskFactory));
                if (instance == null)
                {
					Debug.LogError("An instance of " + typeof(DiskFactory) +
                    " is needed in the scene, but there is none.");
                }
            }
            return instance;
        }
    }
}