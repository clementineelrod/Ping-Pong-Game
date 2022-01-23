using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Score : MonoBehaviour
{
    public EventTrigger.TriggerEvent score;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if (ball != null)
        {
            BaseEventData eventdata = new BaseEventData(EventSystem.current);
            this.score.Invoke(eventdata);
        }
    }
}