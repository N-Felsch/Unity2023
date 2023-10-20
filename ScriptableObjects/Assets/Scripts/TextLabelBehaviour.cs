using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class NewBehaviourScript : MonoBehaviour
{
  public Text label;
  public FloatData dataObj;

  private void Start()
  {
      label = GetComponent<Text>();
      label.text = dataObj.value.ToString(CultureInfo.InvariantCulture);

  }
}
