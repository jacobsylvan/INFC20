using System;
namespace GymShark.Properties
{
    public class Instructor
    {
        private string surName;
        private string lastName;
        private string phone;
        private string instructorId;

        public Instructor(string surName, string lastName, string phone, string instructorId){
            this.surName = surName;
            this.lastName = lastName;
            this.phone = phone;
            this.instructorId = instructorId;


        }

        public string SurName{
            get { return surName; }
            set { surName = value; }
        }
        public string LastName{
            get { return lastName; }
            set { lastName = value; }
        }
        public string Phone{
            get { return phone; }
            set { phone = value; }
        }
        public string InstructorId{
            get { return instructorId; }
            set { instructorId = value; }

        }


        public Instructor()
        {
        }
    }
}
