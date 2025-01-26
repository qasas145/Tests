using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Shouldly;

namespace Tests
{
    [Subject("starting car test ")]
    public class CarStartTest
    {
        const string type = "BMW";
        static Car car;
        Context CarInitilazation = () =>
        {
            new Car()
            {
                Type = type,
                Model = "2020"
            };
        };
        Because of = () => car.Start();
        ItShould isRunningBe = () => car.IsRunning.ShouldBe(true);
        ItShould modelBe = () => car.Model.ShouldBe("2020");

    }
    [Subject("stopping car test")]
    public class CarStopTest
    {

        static Car car = new Car();
        Context CarInitilazation = () => car = new Car()
        {
            Type = "BMW",
            Model = "2020"
        };
        Because of = () => car.Stop();
        ItShould isStoppedBe = () => car.IsRunning.ShouldBe(false);
        ItShould modelBe = () => car.Model.ShouldBe("2020");
    }
}
