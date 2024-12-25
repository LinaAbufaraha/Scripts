using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment26{
    public class CreatureManager : MonoBehaviour
    {
        List<Creature> creatures = new List<Creature>();
        List<IRunnable> runnables = new List<IRunnable>();
        List<IJumpable> jumpables = new List<IJumpable>();
        List<ISwimmable> swimmables = new List<ISwimmable>();
    
        void Start()
        {   
            Kangaroo kangaroo = new Kangaroo();
            Duck duck = new Duck();

            creatures.Add(kangaroo);
            creatures.Add(duck);

            runnables.Add(kangaroo);
            jumpables.Add(kangaroo);

            runnables.Add(duck);
            swimmables.Add(duck);

            Debug.Log("Speak for each creature");
            foreach(Creature i in creatures){
                i.Speak();
            }

            Debug.Log("Run for each IRunnable");
            foreach(IRunnable i in runnables){
                i.Run();
            }

            Debug.Log("Jump for each IJumpable");
            foreach(IJumpable i in jumpables){
                i.Jump();
            }

            Debug.Log("Swim for each ISwimmable");
            foreach(ISwimmable i in swimmables){
                i.Swim();
            }

        }

        void Update()
        {
        
        }
    }
}
