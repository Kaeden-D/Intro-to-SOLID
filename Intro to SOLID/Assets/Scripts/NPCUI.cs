using Unity.VisualScripting;
using UnityEngine;

public class NPCUI : MonoBehaviour
{
    
    [SerializeField]
    private StandardHealth standardHealth;
    [SerializeField]
    private NumberOfHitsHealth numHitsHealth;
    [SerializeField] 
    private ImmuneHealth immuneHealth;

    void OnGUI()
    {
        if (standardHealth != null && GUILayout.Button("Damage Standard Health"))
        {
            standardHealth.TakeDamage(10);
        }
        if (numHitsHealth != null && GUILayout.Button("Damage NumHits Health"))
        {
            numHitsHealth.TakeDamage(10);
        }
        if (immuneHealth != null && GUILayout.Button("Damage Immune Health"))
        {
            immuneHealth.TakeDamage(10);
        }

    }
}
