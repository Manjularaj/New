using System;

namespace Programming_120_Final
{
    class Program
    {
        
        static int numberOfStudents = 15; // You can change this, has to be 5 or higher. Code should work no matter what size

        // Data
        static string[] studentFirstName = new string[numberOfStudents];
        static string[] studentLastName = new string[numberOfStudents];
        static double[] csiGrades = new double[numberOfStudents];
        static double[] genEdGrades = new double[numberOfStudents];


        static void Main(string[] args)
        {
            CodeForTest_DontChange(); // !! Needs to first method in main, don't delete
            //----------------------------------------------
            // Place code below here
 


        } // Main


// -------------------------------------------------------------
// Code used to populate the arrays. Feel to look at them. But don't change them for the Final. 
// Make a copy of this project and break that code as much as you want

#region GenerateArrayCode
        public static void CodeForTest_DontChange() {
          PopulateArrays(numberOfStudents);
          CustomData();
        }

        public static void PopulateArrays(int count) {
            Random rand = new Random();

            string[] lastNames = {
                "Smith",
                "Johnson",
                "Williams",
                "Brown",
                "Jones",
                "Miller",
                "Davis",
                "Garcia",
                "Rodriguez",
                "Wilson",
                "Martinez",
                "Anderson",
                "Taylor",
                "Thomas",
                "Hernandez",
                "Moore",
                "Martin",
                "Jackson",
                "Thompson",
                "White"
            };

            string[] firstNames = {
                "James",
                "Mary",
                "Robert",
                "Patricia",
                "John",
                "Jennifer",
                "Michael",
                "Linda",
                "David",
                "Elizabeth",
                "William",
                "Elizabeth",
                "Barbara",
                "Richard",
                "Susan",
                "Joseph",
                "Jessica",
                "Thomas",
                "Sarah",
                "Charles",
                "Karen",
                "Christopher",
                "Lisa",
                "Daniel",
                "Nancy",
                "Matthew",
                "Betty",
                "Anthony",
                "Margaret",
                "Mark",
                "Sandra"
            };

            for(int i = 0; i < count; i++) {

                int fNameIndex = rand.Next(firstNames.Length);
                int lNameIndex = rand.Next(lastNames.Length);
            // System.Console.WriteLine("This ran");

                studentFirstName[i] = firstNames[fNameIndex];
                studentLastName[i] = lastNames[lNameIndex];
                csiGrades[i] = rand.Next(0, 101);
                genEdGrades[i] = rand.Next(0, 101);
            }


        } // PopulateArrays()

        public static void CustomData() {
            string[] stuFirst = {"Samuel", "Havelock", "Ford", "Authur"};
            string[] stuLast = {"Vimes", "Vetinari", "Prefect", "Dent"};
            int[] stuCSI = {100, 102, 42, 20};
            int[] stuGenEd = {45, 102, 75, 56};
            
            int[] indexes = new int[stuFirst.Length];

            Random rand = new Random();

            for (int i = 0; i < indexes.Length; i++)
            {
                
                int newIndex = rand.Next(studentFirstName.Length);

                while(MyContains(newIndex, indexes)) {
                    newIndex = rand.Next(studentFirstName.Length);
                }

                indexes[i] = newIndex;

                studentFirstName[newIndex] = stuFirst[i];
                studentLastName[newIndex] = stuLast[i];
                csiGrades[newIndex] = stuCSI[i];
                genEdGrades[newIndex] = stuGenEd[i];
            }
        }
        // 45
        // 45 17 21 0

        public static bool MyContains(int search, int[] arr) {
            foreach (int value in arr)
            {
                if(search == value) return true;
            }
            return false;
        } // MyContains

#endregion GenerateArrayCode
    
    } // class
}
