using UnityEngine;


namespace Assignment.StudentSolution.LCT01
{
    public class Car
    {
        public string Name;
        public string Speed;
        public string Color;
        
        public void Move()
        {
            Debug.Log("Move");
        }
        public void Trun()
        {
            Debug.Log("Trun");
        }
    }

    public class LCT01SyntaxClass
    {
        public void Start()
        {
            // Student code start HERE ...
            Car car1 = new Car();
            car1.Name = "Ferrari";
            car1.Speed = "100.0f";
 
            Car car2 = new ();
            car2.Name = "Toyota";
 
            car1.Move();
            car1.Trun();
            // Student code ends HERE 
        }
    }
}
