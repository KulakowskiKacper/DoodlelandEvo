using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour
{
	public Vector3 pointB;
	
	IEnumerator Start()
	{
		var pointA = transform.position;
		while(true)
		{
			yield return StartCoroutine(MoveObjectM(transform, pointA, pointB, 3.0f));
			yield return StartCoroutine(MoveObjectM(transform, pointB, pointA, 3.0f));
		}
	}
	
	IEnumerator MoveObjectM(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
	{
		var i= 0.0f;
		var rate= 1.0f/time;
		while(i < 1.0f)
		{
			i += Time.deltaTime * rate;
			thisTransform.position = Vector3.Lerp(startPos, endPos, i);
			yield return null; 
		}
	}
}