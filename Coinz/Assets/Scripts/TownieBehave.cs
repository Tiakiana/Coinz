using UnityEngine;
using System.Collections;
using Behave.Runtime;
using Tree = Behave.Runtime.Tree;

public class TownieBehave : MonoBehaviour,IAgent {
    
    Tree m_Tree;

    //Dette er grundstenen i Behave. I stedet for BLNewBehaveLibrary, skriver man sit eget navn


    AIStats stats;


    IEnumerator Start() {
        m_Tree = BLNewBehaveLibrary0.InstantiateTree(
            BLNewBehaveLibrary0.TreeType.HeroAI1_NewTree1, this);
        stats = gameObject.GetComponent<AIStats>();
        stats.distanceToTarget = 10;
        stats.fatigue = 100;
        stats.oreCap = 150;
        while (Application.isPlaying && m_Tree != null) 
        {
            yield return new WaitForSeconds(1 / m_Tree.Frequency);
            AIUpdate();

        }
            
    }

    void AIUpdate() {
        m_Tree.Tick();
    }

    public BehaveResult Tick(Tree sender, bool init)
    {
        Debug.Log("Ticked Received by unhandled " +
        (BLNewBehaveLibrary0.IsAction(sender.ActiveID) ? "Action " :
        "Decorator ") +
        " ... " + (BLNewBehaveLibrary0.IsAction(sender.ActiveID) ?
        ((BLNewBehaveLibrary0.ActionType)sender.ActiveID).ToString() :
        ((BLNewBehaveLibrary0.DecoratorType)sender.ActiveID).ToString()));
        return BehaveResult.Success;
    }

    public void Reset(Tree sender) {

    }

    public int SelectTopPriority(Tree sender, params int [] IDs) {
        return 0;

    }

   

    // Use this for initialization
    
	
	// Update is called once per frame
	void Update () {
	
	}
}
