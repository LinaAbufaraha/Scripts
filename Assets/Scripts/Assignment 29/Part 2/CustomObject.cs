using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29{
    public class CustomObject 
    { //Part2
        private int _ID;
        private string _Name;

        public CustomObject(int id, string name)
        {
            this._Name = name;
            this._ID = id;
        }

        public int ID
        {
            get => _ID;
            set => _ID = value;
        }

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }

        public override string ToString()
        {
            return $"Object [ID: {_ID}, Name: {_Name}]";
        }

        public override bool Equals(object obj)
        {
            if (obj is CustomObject other)
            {
                return ID == other._ID && Name == other._Name;
            }
            return false;
        }
    
    }

}
