using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPanel : MonoBehaviour
{
   protected UIPanelManager _panelManager;
   public void InitPanel(UIPanelManager manager)
   {
      _panelManager = manager;
   }
   public virtual void SetPanelActive(bool active)
   {
      gameObject.SetActive(active);
   }
}
