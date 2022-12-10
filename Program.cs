using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Programming_120_Final

    //Manjula Rajan
    //12/10/2022
    //Fianal Exam
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

            Mainmenu();// Main menu
            

        } // Main

        static void Mainmenu()
        {
            //header
            Console.WriteLine("Renton Technical College - Student Database");
            Console.WriteLine("Teacher:Professor Manjula Rajan");

            bool Stop = false;
            while (!Stop)
            {   // Mainmenu
                Console.WriteLine("1. Display All students");
                Console.WriteLine("2. Check Student enrollment");
                Console.WriteLine("3. Student Lookup");
                Console.WriteLine("4. Update Student Info");
                Console.WriteLine("5. Display students with an Average Grade");
                Console.WriteLine("e - exit");

                //prompting the user for menu options
                Console.WriteLine("Enter an option:");
                string userOption = Console.ReadLine();

                switch (userOption)
                {

                    case "1":

                        Allstudents();//All Students info

                        break;

                    case "2":
                        checkstudentEnrollment();// Enrollment details

                        break;
                    case "3":
                        StudentLookup();// Student details

                        break;
                    case "4":
                        UpdateStudentInfo();

                        break;
                    case "5":
                        ViewStudentWithGrades();

                        break;

                    case "e":
                        Stop = true;// exit
                        break;
                }
                Console.WriteLine();
            }

        }

               

        static void checkstudentEnrollment()//........................................................2 – Check Student Enrollment.................
        {
            //prompting the user for Students first name
            Console.WriteLine("Please enter Student's First name");
            string fName= Console.ReadLine();

            //prompting the user for Students Last Name
            Console.WriteLine("Please enter Students's Last's name ");
            string lName = Console.ReadLine();

            //Boolean for checking students enrolled or not
            if (StudentEnrolled (fName, lName) == true)
            {
                Console.WriteLine(fName + "" + lName + "is enrolled in RTC");
            }
            else
            {
                Console.WriteLine(fName + "" + lName + "is not enrolled in RTC");
            }
            
        }
        static void Allstudents()//..............................................................................option 1.................
        {

            for (int i =0; i <numberOfStudents; i++)
            {

                FormatStudent(i);
            }
        }

        static bool StudentEnrolled(string fname, string lname) //...................................................Search (80 points).......
        {
            for (int i = 0; i < numberOfStudents; i++)
            {

                if (studentFirstName[i] == fname && studentLastName[i] == lname)
                {
                    return true;
                }
            }
            return false;
        }

        static void StudentLookup()//....................................................................       ......3 Student Kookup ......
        {
            Console.WriteLine("Display student Information");
            Console.ReadLine();

        }

        static void FormatStudent(int index)//..........................................formatstudent..............Related to solution 3............
        {
            string fname = studentFirstName[index];
            string lname = studentLastName[index];
            double csiGrade = csiGrades[index];
            double gened = genEdGrades[index];


            Console.WriteLine($"{index}{fname}{lname} - CSI Grade: {csiGrade} - Gen Ed: {gened}");
        }   

        static void DisplayStudentwithGrades(double min,double max)
        {
           for (int i =0; i <numberOfStudents; i++)
            {
                double average = GradeAverage(csiGrades[i], genEdGrades[i]);
                if (average > min && average < max)
                {

                    FormatStudent(i);
                }
            }
           
        }
        

        static double GradeAverage (double csi, double gen)//.......................................................calculation of average (math)
        {

            double average = (csi + gen );

            return average;
        }

        
       


        static void UpdateStudentInfo()//............................................................................4 -Student Lookup........
        {
            //Console.WriteLine("Update Student Information:");
            //Console.WriteLine("1.By Student Index");
            //Console.WriteLine("2.By Student Name");
            //Console.WriteLine("Option");
            //Console.ReadLine();
        }

        static void ViewStudentWithGrades()// ...............................................................5 
        {



        }


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
