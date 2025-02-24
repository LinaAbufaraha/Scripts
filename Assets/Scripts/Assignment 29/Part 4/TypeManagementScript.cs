using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{//Part4
    public class TypeManagementScript : MonoBehaviour
    {
        public class Animal
        {
            public virtual void MakeSound(){
                Debug.Log("Animal sound");
            }
            public void Move(){
                Debug.Log("Animal moves.");
            } 
        }

        public interface ICanFight
        {
            public void Attack();
        }

        public class Cat : Animal, ICanFight
        {
            public override void MakeSound() {
                Debug.Log("Meow!");
            } 
            public new void Move(){
                Debug.Log("Cat runs quickly.");
            } 
            public void Attack(){
                Debug.Log("Cat attacks with claws!");
            } 
        }

        public class Warrior : ICanFight
        {
            public void Attack(){
                Debug.Log("Warrior attacks with a sword!");
            } 
        }


        void Start()
        {
            Cat cat1 = new Cat();
            Animal animal =cat1;
            animal.MakeSound();
            animal.Move();

            Cat cat2 = animal as Cat;
            cat2?.MakeSound();
            cat2?.Move();

            List<ICanFight> fighters = new List<ICanFight> { new Cat(), new Warrior() };
            foreach (var fighter in fighters)
            {
                fighter.Attack();
                if (fighter is Cat)
                    Debug.Log("The object is a Cat.");
                else if (fighter is Warrior)
                    Debug.Log("The object is a Warrior.");
            }

            //Animal animal2 = new Animal();
            //Cat cat3 = animal2 as Cat; // This conversion is not possible because Animal is not Cat.

            //if (cat3 == null)
              //  Debug.Log("Conversion failed: animal2 is not a Cat.");
        
        }

        void Update()
        {
        
        }
    }
}
