using System;
using static Documentation.DocumentationAttribute;

namespace DocumentationAttribute
{
   
    [Document("A little detail about me")]
public class PersonalDetails
{
        public IPersonal myself;

        [Document("This adds the battery to the torchlight", "IBattery")]

    public PersonalDetails(IPersonal myself)
        {
            this.myself = myself;
        }

        [Document("DisplayBatteryName")]
        public void DisplayBatteryName()
        {
            Console.WriteLine(myself.brandName);
        }

        [Document("DisplayBatteryLife")]
        public void DisplayBatteryLife()
        {
            Console.WriteLine(myself.batteryLife);
        }

        [Document("This indicate that we can turn on the torchlight")]
        public bool CanTurnOn
        {
            get
            {
                return true;
            }
            set
            {

            }
        }

        [Document("This indicates the brightness of the battery")]
        public enum TorchBrightness
        {
            Low = 1,
            Medium = 2,
            High = 3
        }

    }

    public interface  IPersonal
    {
        public int Age { get; }

        public string Gender { get; }
    }

    [Document("This is a duracell battery that works with a torchlight")]
    public class Duracell : IPersonal
    {
        [Document("This is the brand name of the battery", "", "string")]
        public string Age
        {
            get
            {
                return "23";
            }
        }

        [Document("This is the life of the battery", "", "int")]
        public int Gender{
            get
            {
                return "Male";
            }
        }
    }


    [Document("This is a Tiger battery that works with a torchlight")]

    public class Tiger : IPersonal
    {

        [Document("This is the brand name of the battery", "", "string")]
        public string brandName
        {
            get
            {
                return "Tiger";
            }
        }


        [Document("This is the life of the battery", "", "int")]

        public int batteryLife
        {
            get
            {
                return 35;
            }
        }
    }
}

