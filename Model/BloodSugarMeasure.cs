using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab3.Model
{
    internal class BloodSugarMeasure
    {
        public int id { get; set; }
        public DateTime date_time { get; set; }
        public string period  { get; set; }
        public int blood_sugar  { get; set; }

        public BloodSugarMeasure(int id,DateTime date_time, string period, int blood_sugar)
        {
            this.id=id;
            this.date_time = date_time;
            this.period = period ?? throw new ArgumentNullException(nameof(period));
            this.blood_sugar = blood_sugar;
        }


        public BloodSugarMeasure()
        {
        }
        //public int MyProperty3 { get; set; }




    }
}
