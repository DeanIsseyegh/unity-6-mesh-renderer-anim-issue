using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AnimManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _stateTex;
    
    public void PlayAnimators()
    {
        _stateTex.text = "Playing";
        
        Animator[] animators = FindObjectsByType<Animator>(FindObjectsInactive.Include, FindObjectsSortMode.None);

        foreach (Animator animator in animators)
        {
            animator.SetTrigger("Play");
        }
    }
    
    public void IdleAnimators()
    {
        _stateTex.text = "Idling";
        
        Animator[] animators = FindObjectsByType<Animator>(FindObjectsInactive.Include, FindObjectsSortMode.None);

        foreach (Animator animator in animators)
        {
            animator.SetTrigger("Idle");
        }
    }
    
    public void DestroyAnimators()
    {
        _stateTex.text = "Animators Destroyed";
        
        Animator[] animators = FindObjectsByType<Animator>(FindObjectsInactive.Include, FindObjectsSortMode.None);

        foreach (Animator animator in animators)
        {
            Destroy(animator);
        }
        
        Button[] buttons = FindObjectsByType<UnityEngine.UI.Button>(FindObjectsInactive.Include, FindObjectsSortMode.None);
        
        foreach (Button button in buttons)
        {
            Destroy(button.gameObject);
        }
    }
}
