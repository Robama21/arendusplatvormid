using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Homework {
    class Program {
        static void PotenetialCandidates(string Competition, Student student, int group, int heightMin, int WeightMax, string hobby) {
            if (student.Group >= group && student.Lenght < heightMin && student.Weight > WeightMax || student.Hobby == hobby) {
                Console.WriteLine(Competition);
                Console.WriteLine(student.Name);
            }
        }
        static void Main(string[] args) {
            List<Student> students = new List<Student>(6) {
                new Student(17, "Ernst Bismarck", 11, "Diving", 63, 183),
                new Student(16, "Roger Hood", 10, "Cricket", 75, 163),
                new Student(15, "Marc Missouri", 9, "Cricket", 86, 176),
                new Student(14, "Miyazato Yamato", 8, "Video Games", 85, 185),
                new Student(13, "Carlo Roma", 7, "Diving", 50, 156),
            };

            List<Competition> competitions = new List<Competition>(4) {
                new Competition(20, "E-Sports"),
                new Competition(30, "Swimming"),
                new Competition(40, "Baseball")
            };

            foreach (Student student in students) {
                PotenetialCandidates("E-Sports", student, 8, 130, 180, "Video Games");
                PotenetialCandidates("Swimming", student, 9, 140, 110, "Diving");
                PotenetialCandidates("Baseball", student, 10, 170, 120, "Cricket");
            }
        }
    }
}
