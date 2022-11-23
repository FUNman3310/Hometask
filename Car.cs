using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLibrary
{
    internal class Car
    {
        private int _counter;
        public int Id;
        public string Name;
        public int Speed;
        public string CarCode;

        public Car(string name,int speed)
        {
            _counter++;
            this.Name = name;
            this.Speed = speed;
            this.Id = _counter;
            this.CarCode = name.Substring(0,2).ToUpper()+(1000+Id);
        }

        
    }
}
