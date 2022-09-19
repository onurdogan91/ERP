using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentInformationSystem
{
    public class Student
    {
        public string NameSurname;
        public string LessonName;
        public int LessonCode;
        public int ScoreVize;
        public int ScoreFinal;
        public string Sonuc;

        public string GetProperties()
        {            
            string S1234Properties = String.Format("Ad Soyad:{0} Ders Adi:{1} Ders Kodu:{2} Sınav Notu Vize:{3} Sınav Notu Final:{4} ", NameSurname, LessonName, LessonCode, ScoreVize, ScoreFinal ); 
            return S1234Properties;
        }

        public string Calculations()
        {
            int Score = ((ScoreVize / 10) * 3) + ((ScoreFinal / 10) * 7); 

            if (Score >= 50)
            {
                Sonuc = "Gecti" + " " + Score;
            }
            else 
            {
                Sonuc = "Kaldi" + " " + Score;
            }
            return Sonuc;
        }



    }
}
