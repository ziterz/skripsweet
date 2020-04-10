using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragStruk : MonoBehaviour, IDragHandler, IEndDragHandler 
{

    public GameObject item1, item2, item3, dragObject, target1, benar, salah, lanjutkan;
    Vector3 startpos, startpos1, startpos2, startpos3;

    // Start is called before the first frame update
    void Start()
    {
        startpos = dragObject.transform.position;
        startpos1 = item1.transform.position;
		startpos2 = item2.transform.position;
		startpos3 = item3.transform.position;
    }

    public void OnDrag(PointerEventData eventData)
	{
   		Vector3 newpos = Input.mousePosition - new Vector3 (Screen.width / 2f, Screen.height / 2f, 0f);
	    dragObject.transform.localPosition = newpos;
    }

    public void OnEndDrag(PointerEventData eventData)
	{
        float Dis1 = Vector3.Distance(dragObject.transform.position, target1.transform.position);

		if(Dis1<2)
        {
            if (item1.transform.position == target1.transform.position) {
                item1Back();
            } 
            else if (item2.transform.position == target1.transform.position) {
                item2Back();
            }
            else if (item3.transform.position == target1.transform.position) {
                item3Back();
            }
            dragObject.transform.position = target1.transform.position;
        }
        else 
        {
            dragObject.transform.position = startpos;
        }
    }

    void item1Back()
	{
		item1.transform.position = startpos1;
	}

	void item2Back()
	{
		item2.transform.position = startpos2;
	}

	void item3Back()
	{
		item3.transform.position = startpos3;
	}

}
