using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteData : MonoBehaviour
{
    // Start is called before the first frame update
    public void ResetData()
    {
        PlayerPrefs.DeleteAll(); // Обнуление всех переменных PlayerPrefs
    }
}
