using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Boss
    {
        private ICarBuilder _carBuilder;

        public Boss(ICarBuilder carBuilder)
        {
            _carBuilder = carBuilder;
        }

        public void BuildCar()
        {
            Console.WriteLine("We have new order, time to build new car! Let's move!");
            List<Task> taskList = new List<Task>();
            taskList.Add(Task.Factory.StartNew(() => _carBuilder.BuildBody()));
            taskList.Add(Task.Factory.StartNew(() => _carBuilder.BuildEngine()));
            taskList.Add(Task.Factory.StartNew(() => _carBuilder.BuildSuspension()));

            Console.WriteLine("How long do i have to wait on one car?!");
            Task.WaitAll(taskList.ToArray());
            Console.WriteLine("Finally, your car is ready sir");
        }

        public Car GetCar()
        {
            return _carBuilder.GetCar();
        }
    }
}
