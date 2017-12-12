using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Classes
{
    class HourCalcReport
    {
        public DateTime Date { get; set; }
        public DayOfWeek Day { get; set; }
        public string Behavior { get; set; }//התנהגות חריגה (האם עבד או חופש)
        public float InWork1 { get; set; }//כניסה 1
        public float OutWork1 { get; set; }//יציאה 1
        public float InWork2 { get; set; }//כניסה 2
        public float OutWork2 { get; set; }//יציאה 2
        public float PresentWork { get; set; }//נוכח בפועל
        public float PresentWorkSalary { get; set; }//נוכח לשכר
        public float regularHours { get; set; }//שעות רגילות
        public float regularSatHol { get; set; }//שעות רגילות שבת חג
        public float overtime100 { get; set; }
        public float overtime125 { get; set; }
        public float overtime150 { get; set; }
        public float saturday150 { get; set; }
        public float saturday175 { get; set; }
        public float saturday200 { get; set; }
        public float saturdayadd50 { get; set; }
    }
}
