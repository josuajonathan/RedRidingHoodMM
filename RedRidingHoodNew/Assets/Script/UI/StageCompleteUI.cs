using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StageCompleteUI : MonoBehaviour
{
    public GameObject UIStageComplete;
    public TMP_Text jumlahKoin;

    public void setStageCompleteUI(string amount)
    {
        UIStageComplete.SetActive(true);
        jumlahKoin.text = amount;
    }
}
