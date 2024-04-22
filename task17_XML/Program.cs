using System.Xml.Serialization;

namespace task17_XML
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Name = "Ramazan",
                Surname = "Asgerli",
                Age = 20
            };
            Student student1 = new Student()
            {
                Name = "Rehman",
                Surname = "Murselov",
                Age = 20
            };
            Student student2 = new Student()
            {
                Name = "Elnur",
                Surname = "Ferzaliyev",
                Age = 20
            };
            string xmlString;
            XmlSerializer serializeStudent = new XmlSerializer(typeof(Student));
            using (StringWriter writer = new StringWriter())
            {
                serializeStudent.Serialize(writer, student);
                serializeStudent.Serialize(writer, student1);
                serializeStudent.Serialize(writer, student2);
                xmlString = writer.ToString();
                Console.WriteLine(xmlString);
            }
            //using (StringReader reader = new StringReader(xmlString))
            //{
            //    Student deserialize = (Student)serializeStudent.Deserialize(reader);
            //    Console.WriteLine($"Student 1: {deserialize.Name} {deserialize.Surname} {deserialize.Age}");

            //    deserialize = (Student)serializeStudent.Deserialize(reader);
            //    Console.WriteLine($"Student 2: {deserialize.Name} {deserialize.Surname} {deserialize.Age}");

            //    deserialize = (Student)serializeStudent.Deserialize(reader);
            //    Console.WriteLine($"Student 3: {deserialize.Name} {deserialize.Surname} {deserialize.Age}");
            //}
        }


    }
    }
    public class Student 
    {
        public static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set;}

        public Student()
        {
            Id = ++_id;
        }
    }


