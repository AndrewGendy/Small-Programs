using System;

namespace test {
    class Program {
        static void Main(string[] args) {

            Customers Ali = new Customers {
                FirstName = "Ali",
                LastName = "Muhamad"
            };

            object[] array = new object[4];

            array[0] = 1;
            array[1] = 2.5;
            array[2] = "Andrew";
            array[3] = Ali;

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
