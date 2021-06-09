using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class BubbleAnimator : MonoBehaviour
{
    public float tweenTime;

    private Transform anotherTransform;
    // Start is called before the first frame update
    void Awake()
    {
        anotherTransform = gameObject.transform;
        
        Tween();
    }
    public void Tween()
    {
        
        LeanTween.cancel(gameObject);
        transform.localScale = Vector3.one;
        LeanTween.moveY(gameObject, 7, 3).setEaseOutQuad();
        LeanTween.scale(gameObject, Vector3.one * 2, tweenTime).setEasePunch();
        StartCoroutine(DelayCall(3f));
    }

    private IEnumerator DelayCall(float i)
    {
        yield return new WaitForSeconds(i);
        Destroy(gameObject);
    }
    
}
