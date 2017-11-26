using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Car
    {
        private IEngine _engine;
        private IBody _body;
        private ISuspension _suspension;

        public IEngine GetEngine()
        {
            return _engine;
        }

        public void SetEngine(IEngine engine)
        {
            _engine = engine;
        }

        public IBody GetBody()
        {
            return _body;
        }

        public void SetBody(IBody body)
        {
            _body = body;
        }

        public ISuspension GetSuspension()
        {
            return _suspension;
        }

        public void SetSuspension(ISuspension suspension)
        {
            _suspension = suspension;
        }

        public void Description()
        {
            Console.WriteLine("Car description");
            Console.WriteLine($"Body color:{_body.GetColor()}");
            Console.WriteLine($"Body option:{_body.GetOption()}");
            Console.WriteLine($"Engine HP:{_engine.GetPower()}");
            Console.WriteLine($"Engine max speed:{_engine.GetMaxSpeed()}");
            Console.WriteLine($"Suspension height (cm) {_suspension.GetHeight()}");
            Console.WriteLine($"Suspension option {_suspension.GetType()}");
            Console.ReadKey();
        }
    }
}
