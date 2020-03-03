using System;

namespace test {
    class Program {
        static void Main(string[] args) {

            Customers Gendy = new Customers {
                FirstName = "Andrew",
                LastName = "Gendy"
            };

            object[] array = new object[4];

            array[0] = 1;
            array[1] = 2.5;
            array[2] = "Hany";
            array[3] = Gendy;

            foreach (object obj in array) {

                Console.WriteLine(obj);
            }
        }

        public class Customers {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string GetFullName() {
                return this.FirstName + " " + this.LastName;
            }

            public override string ToString() {
                return this.GetFullName();
            }

        }
    }


}
