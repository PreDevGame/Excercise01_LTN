using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level002 : MonoBehaviour
{
    public GameObject fadeIn;
    public GameObject guideTable;

    void Start()
    {
        RedirectTotalLevel.redirectTolLevel = 4;
        GlobalScore.currentScore = 0;
        StartCoroutine(FadeInOff());
    }

    IEnumerator FadeInOff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
        yield return new WaitForSeconds(0.0001f);
        guideTable.SetActive(true);
        yield return new WaitForSeconds(2);
        guideTable.SetActive(false);
    }

}
