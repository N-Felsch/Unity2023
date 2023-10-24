using System.Globalization;
using TMPro;
using UnityEngine;


[RequireComponent(typeof(TMP_Text))]
public class NewBehaviourScript : MonoBehaviour
{
  public TMP_Text label;
  public FloatData dataObj;

  public void Start()
  {
      
      label = GetComponent<TMP_Text>();
      UpdateLabel();
  }
  
  public void UpdateLabel()
  {
      label.text = dataObj.value.ToString(CultureInfo.InvariantCulture);

  }
}



