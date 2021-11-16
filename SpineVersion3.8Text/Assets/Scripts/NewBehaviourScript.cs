using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform SpineTransform;


    private Vector3 StartVec3 = Vector3.zero;
    private Vector3 StartScale = Vector3.one;
    public void Awake()
    {
        StartVec3 = SpineTransform.transform.localPosition;
        StartScale = SpineTransform.transform.localScale;
    }

    public void OnMoveButtonClicked()
    {
        SpineTransform.DOKill();
        SpineTransform.DOLocalMove(StartVec3 + new Vector3(300, 300, 0), 10).SetLoops(-1, LoopType.Yoyo);
    }

    public void OnScaleButtonClicked()
    {
        SpineTransform.DOKill();
        SpineTransform.DOScale(0.3f, 10).SetLoops(-1, LoopType.Yoyo);
    }

}
