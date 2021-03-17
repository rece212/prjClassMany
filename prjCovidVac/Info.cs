using System;
using System.Collections.Generic;
using System.Text;

namespace prjCovidVac
{
    class Info
    {
        //Special Student Vars
        private static int iSizeArray = 0;
        private static int iCounter = 0;

        #region gets and sets for the main vars
        private static String strHospital_Name;
        private static String strAddress;
        private static bool bType;//private or public hospital
        private static char cProvince;
    
        public string Hospital_Name { get => strHospital_Name; set => strHospital_Name = value; }
        public string Address { get => strAddress; set => strAddress = value; }
        public bool Type { get => bType; set => bType = value; }
        public char Province { get => cProvince; set => cProvince = value; }

        #endregion

        #region arrays 
        private static String[] ID_Number;
        private static String[] MedicalAid;
        private static String[] Name;
        private static String[] Surname;
        private static String[] RefDr;
        private static Char[] BloodType;
        private static String[] Allergies;
        private static Boolean[] CovidPostive;
        private static String[] Vaccine;
        #endregion

        #region Set array size
        public void setArray(int num)
        {
            ID_Number = new String[num];
            MedicalAid = new String[num];
            Name = new String[num];
            Surname = new String[num];
            RefDr = new String[num];
            BloodType = new Char[num];
            Allergies = new String[num];
            CovidPostive = new Boolean[num];
            Vaccine = new String[num];

            iSizeArray = num;
        }
        #endregion

        public void addPerson(String strID, String strMedic,String strName , 
            String strSurname, 
            String strRefDr, Char cBloodType,
            String strAllergies, Boolean bCovid, String strVac)
        {

            ID_Number[iCounter] = strID;
            MedicalAid[iCounter] = strMedic;
            Name[iCounter] = strName;
            Surname[iCounter] = strSurname;
            RefDr[iCounter] = strRefDr;
            BloodType[iCounter] = cBloodType;
            Allergies[iCounter] = strAllergies;
            CovidPostive[iCounter] = bCovid;
            Vaccine[iCounter] = strVac;

            iCounter++;
    }

        public int size()
        {
            return iSizeArray;
        }

        #region Get values
        public String getIDNumber(int x)
        {
            return ID_Number[x];
        }

        public string getMedicalAid(int x)
        {
            return MedicalAid[x];
        }
        public string getName(int x)
        {
            return Name[x];
        }
        public string getSurname(int x)
        {
            return Surname[x];
        }
        public string getRefDr(int x)
        {
            return RefDr[x];
        }
        public char getBloodType(int x)
        {
            return BloodType[x];
        }
        public string getAllergies(int x)
        {
            return Allergies[x];
        }
        public Boolean getCovidPostive(int x)
        {
            return CovidPostive[x];
        }
        public String getVaccine(int x)
        {
            return Vaccine[x];
        }
        #endregion


    }
}
