using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab3
{
    internal class PatientInfo
    {
        //for AddPatients screen 
        static internal List<string> PatientSymptoms = new List<string>();
        internal int id;
        internal string name;
        internal string surname;
        internal bool gender;
        internal DateTime birth_date;
        internal string email;
        internal int blood_sugar;
        internal string phone_number;
        internal List<byte> profile_image = new List<byte>();
        internal List<string> symptoms=new List<string>();// declaring string type but actually has only numbers like "1","2" that 
        //for patient feature
        public PatientInfo(int id,string name,string surname,bool gender,DateTime birth_date,string email,int blood_sugar,string phone_number,List<string> symptoms)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.gender = gender;
            this.birth_date = birth_date;
            this.email = email;
            this.blood_sugar = blood_sugar;
            this.phone_number = phone_number;
            //this.profile_image = profile_image;
            this.symptoms = symptoms;
        }
    }
}
